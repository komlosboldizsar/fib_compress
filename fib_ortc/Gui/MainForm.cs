using fib_ortc.Gui.GeneralComponents.Tables;
using fib_ortc.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fib_ortc.Gui
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private FibTable mFibTableOriginal;
        private FibTable mFibTableOrtc;
        private FibTree mFibTreeOriginal;
        private FibTree mFibTreeOrtc;

        private void MainForm_Load(object sender, EventArgs e)
        {
            initModel();
            initTables();
            initTrees();
            updateModel();
        }

        private void initModel()
        {
            mFibTableOriginal = new FibTable();
            mFibTableOrtc = new FibTable();
            mFibTreeOriginal = new FibTree();
            mFibTreeOrtc = new FibTree();
            mFibTableOriginal.CollectionChanged += MFibTableOriginal_CollectionChanged;
            mFibTreeOriginal.TreeChanged += MFibTreeOriginal_TreeChanged;
            mFibTreeOrtc.TreeChanged += MFibTreeOrtc_TreeChanged;
        }

        private void MFibTableOriginal_CollectionChanged()
            => updateModel();

        private void MFibTreeOriginal_TreeChanged()
            => visualizeTree(mFibTreeOriginal, originalFibTree);

        private void MFibTreeOrtc_TreeChanged()
            => visualizeTree(mFibTreeOrtc, ortcFibTree);
        
        private void updateModel()
        {
            mFibTreeOriginal.CreateFromFibTable(mFibTableOriginal);
            mFibTreeOrtc.CreateFromFibTreeByOrtc(mFibTreeOriginal);
            mFibTableOrtc.CreateFromFibTree(mFibTreeOrtc);
        }

        private void initTables()
        {
            initFibTable(ref originalFibTable, ref _originalFibTable, originalFibTableContainer, true, mFibTableOriginal);
            initFibTable(ref ortcFibTable, ref _ortcFibTable, ortcFibTableContainer, false, mFibTableOrtc);
            initNextHopTable(ref originalNextHopTable, ref _originalNextHopTable, originalNextHopTableContainer, mFibTreeOriginal);
            initNextHopTable(ref ortcNextHopTable, ref _ortcNextHopTable, ortcNextHopTableContainer, mFibTreeOrtc);
        }

        private CustomDataGridView<FibEntry> _originalFibTable;
        private CustomDataGridView<FibEntry> _ortcFibTable;
        private CustomDataGridView<FibTreeLabel> _originalNextHopTable;
        private CustomDataGridView<FibTreeLabel> _ortcNextHopTable;

        protected DataGridViewCellStyle BOLD_TEXT_CELL_STYLE
        {
            get
            {
                DataGridViewCellStyle boldTextCellStyle = originalFibTable.DefaultCellStyle.Clone();
                boldTextCellStyle.Font = new Font(originalFibTable.DefaultCellStyle.Font, FontStyle.Bold);
                return boldTextCellStyle;
            }
        }

        protected const int DEFAULT_DIVIDER_WIDTH = 3;

        private void initFibTable(ref DataGridView originalTable, ref CustomDataGridView<FibEntry> customMember, Panel container, bool canDelete, FibTable fibTable)
        {

            customMember = CreateTable<FibEntry>(ref originalTable, container);

            CustomDataGridViewColumnDescriptorBuilder<FibEntry> builder;

            // Column: prefix, IP format
            builder = new CustomDataGridViewColumnDescriptorBuilder<FibEntry>(customMember);
            builder.Type(DataGridViewColumnType.TextBox);
            builder.Header("Prefix");
            builder.Width(120);
            builder.UpdaterMethod((entry, cell) => { cell.Value = entry.IpForm; });
            builder.AddChangeEvent(nameof(FibEntry.IpForm));
            builder.BuildAndAdd();

            // Column: next hop
            builder = new CustomDataGridViewColumnDescriptorBuilder<FibEntry>(customMember);
            builder.Type(DataGridViewColumnType.TextBox);
            builder.Header("Next hop");
            builder.Width(100);
            builder.UpdaterMethod((entry, cell) => { cell.Value = entry.NextHop; });
            builder.AddChangeEvent(nameof(FibEntry.NextHop));
            builder.BuildAndAdd();

            if (canDelete)
            {
                // Column: delete button
                builder = new CustomDataGridViewColumnDescriptorBuilder<FibEntry>(customMember);
                builder.Type(DataGridViewColumnType.Button);
                builder.Header("Delete");
                builder.Width(70);
                builder.ButtonText("Delete");
                builder.CellContentClickHandlerMethod((entry, cell, e) =>
                {
                    string msgBoxText = string.Format("Do you really want to delete this prefix?\n{0}", entry.IpForm);
                    var confirm = MessageBox.Show(msgBoxText, "Delete confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirm == DialogResult.Yes)
                        fibTable.RemoveEntry(entry);
                });
                builder.BuildAndAdd();
            }

            // Bind database
            customMember.BoundCollection = fibTable;

        }

        private void initNextHopTable(ref DataGridView originalTable, ref CustomDataGridView<FibTreeLabel> customMember, Panel container, FibTree fibTree)
        {

            customMember = CreateTable<FibTreeLabel>(ref originalTable, container);

            CustomDataGridViewColumnDescriptorBuilder<FibTreeLabel> builder;

            // Column: prefix, IP format
            builder = new CustomDataGridViewColumnDescriptorBuilder<FibTreeLabel>(customMember);
            builder.Type(DataGridViewColumnType.TextBox);
            builder.Header("Label");
            builder.Width(60);
            builder.UpdaterMethod((entry, cell) => { cell.Value = entry.Text; });
            builder.AddChangeEvent(nameof(FibEntry.IpForm));
            builder.BuildAndAdd();

            // Column: next hop
            builder = new CustomDataGridViewColumnDescriptorBuilder<FibTreeLabel>(customMember);
            builder.Type(DataGridViewColumnType.TextBox);
            builder.Header("IP address");
            builder.Width(120);
            builder.UpdaterMethod((entry, cell) => { cell.Value = entry.NextHop; });
            builder.AddChangeEvent(nameof(FibEntry.NextHop));
            builder.BuildAndAdd();

            // Bind database
            customMember.BoundCollection = fibTree.Labels;

        }

        public CustomDataGridView<T> CreateTable<T>(ref DataGridView insteadOf, Panel conainer)
            where T : class
        {
            var customTable = new CustomDataGridView<T>();
            conainer.Controls.Clear();
            conainer.Controls.Add(customTable);
            customTable.Dock = DockStyle.Fill;
            insteadOf = customTable;
            return customTable;
        }

        private void addFibEntryButton_Click(object sender, EventArgs e)
        {
            AddFibEntryDialog dialog = new AddFibEntryDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    mFibTableOriginal.AddEntry(new FibEntry(dialog.Prefix, dialog.NextHop, null));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "User input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void clearFibButton_Click(object sender, EventArgs e)
        {
            mFibTableOriginal.ClearEntries();
        }

        private void initTrees()
        {
            originalFibTree.Nodes.Clear();
            ortcFibTree.Nodes.Clear();
        }

        private void visualizeTree(FibTree tree, TreeView treeView)
        {
            treeView.Nodes.Clear();
            addNodeWithChildren(tree.Root, treeView, null, "");
            treeView.ExpandAll();
        }

        private void addNodeWithChildren(FibTreeNode node, TreeView treeView, TreeNode parent, string edgeLabel)
        {
            TreeNodeCollection parentCollection = parent?.Nodes ?? treeView.Nodes;
            string newNodeText = string.Format("{0}{1}",
                (!string.IsNullOrEmpty(edgeLabel) ? string.Format("-{0}->", edgeLabel) : "(root)"),
                ((node.Label != null) ? string.Format(": {0} [{1}]", node.Label.Text, node.Label.NextHop) : ""));
            TreeNode newNode = parentCollection.Add(newNodeText);
            if (node.Child0 != null)
                addNodeWithChildren(node.Child0, treeView, newNode, "0");
            if (node.Child1 != null)
                addNodeWithChildren(node.Child1, treeView, newNode, "1");
        }

    }
}
