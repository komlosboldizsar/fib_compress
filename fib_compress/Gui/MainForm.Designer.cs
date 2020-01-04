namespace fib_compress.Gui
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.header = new System.Windows.Forms.Panel();
            this.headerText = new System.Windows.Forms.Label();
            this.headerBorder = new System.Windows.Forms.Panel();
            this.tableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.originalFibTableContainerPanel = new System.Windows.Forms.Panel();
            this.originalFibTableContainer = new System.Windows.Forms.Panel();
            this.originalFibTable = new System.Windows.Forms.DataGridView();
            this.originalFibButtonsPanel = new System.Windows.Forms.Panel();
            this.loadButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.clearFibButton = new System.Windows.Forms.Button();
            this.addFibEntryButton = new System.Windows.Forms.Button();
            this.originalFibTree = new System.Windows.Forms.TreeView();
            this.compressedFibTree = new System.Windows.Forms.TreeView();
            this.compressedFibTableContainer = new System.Windows.Forms.Panel();
            this.compressedFibTable = new System.Windows.Forms.DataGridView();
            this.originalNextHopTableContainer = new System.Windows.Forms.Panel();
            this.originalNextHopTable = new System.Windows.Forms.DataGridView();
            this.compressedNextHopTableContainer = new System.Windows.Forms.Panel();
            this.compressedNextHopTable = new System.Windows.Forms.DataGridView();
            this.normalizedFibTableContainer = new System.Windows.Forms.Panel();
            this.normalizedFibTable = new System.Windows.Forms.DataGridView();
            this.normalizedNextHopTableContainer = new System.Windows.Forms.Panel();
            this.normalizedNextHopTable = new System.Windows.Forms.DataGridView();
            this.normalizedFibTree = new System.Windows.Forms.TreeView();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.header.SuspendLayout();
            this.tableLayout.SuspendLayout();
            this.originalFibTableContainerPanel.SuspendLayout();
            this.originalFibTableContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.originalFibTable)).BeginInit();
            this.originalFibButtonsPanel.SuspendLayout();
            this.compressedFibTableContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.compressedFibTable)).BeginInit();
            this.originalNextHopTableContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.originalNextHopTable)).BeginInit();
            this.compressedNextHopTableContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.compressedNextHopTable)).BeginInit();
            this.normalizedFibTableContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.normalizedFibTable)).BeginInit();
            this.normalizedNextHopTableContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.normalizedNextHopTable)).BeginInit();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.BackColor = System.Drawing.Color.Navy;
            this.header.Controls.Add(this.headerText);
            this.header.Controls.Add(this.headerBorder);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1482, 71);
            this.header.TabIndex = 0;
            // 
            // headerText
            // 
            this.headerText.AutoSize = true;
            this.headerText.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerText.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.headerText.ForeColor = System.Drawing.Color.White;
            this.headerText.Location = new System.Drawing.Point(0, 0);
            this.headerText.Name = "headerText";
            this.headerText.Padding = new System.Windows.Forms.Padding(10);
            this.headerText.Size = new System.Drawing.Size(304, 67);
            this.headerText.TabIndex = 1;
            this.headerText.Text = "FIB_COMPRESS";
            // 
            // headerBorder
            // 
            this.headerBorder.AutoSize = true;
            this.headerBorder.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.headerBorder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.headerBorder.Location = new System.Drawing.Point(0, 67);
            this.headerBorder.Name = "headerBorder";
            this.headerBorder.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.headerBorder.Size = new System.Drawing.Size(1482, 4);
            this.headerBorder.TabIndex = 0;
            // 
            // tableLayout
            // 
            this.tableLayout.ColumnCount = 3;
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayout.Controls.Add(this.originalFibTableContainerPanel, 0, 0);
            this.tableLayout.Controls.Add(this.originalFibTree, 1, 0);
            this.tableLayout.Controls.Add(this.compressedFibTree, 1, 2);
            this.tableLayout.Controls.Add(this.compressedFibTableContainer, 0, 2);
            this.tableLayout.Controls.Add(this.originalNextHopTableContainer, 2, 0);
            this.tableLayout.Controls.Add(this.compressedNextHopTableContainer, 2, 2);
            this.tableLayout.Controls.Add(this.normalizedFibTableContainer, 0, 1);
            this.tableLayout.Controls.Add(this.normalizedNextHopTableContainer, 2, 1);
            this.tableLayout.Controls.Add(this.normalizedFibTree, 1, 1);
            this.tableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout.Location = new System.Drawing.Point(0, 71);
            this.tableLayout.Name = "tableLayout";
            this.tableLayout.RowCount = 3;
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayout.Size = new System.Drawing.Size(1482, 882);
            this.tableLayout.TabIndex = 1;
            // 
            // originalFibTableContainerPanel
            // 
            this.originalFibTableContainerPanel.Controls.Add(this.originalFibTableContainer);
            this.originalFibTableContainerPanel.Controls.Add(this.originalFibButtonsPanel);
            this.originalFibTableContainerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.originalFibTableContainerPanel.Location = new System.Drawing.Point(3, 3);
            this.originalFibTableContainerPanel.Name = "originalFibTableContainerPanel";
            this.originalFibTableContainerPanel.Size = new System.Drawing.Size(488, 288);
            this.originalFibTableContainerPanel.TabIndex = 0;
            // 
            // originalFibTableContainer
            // 
            this.originalFibTableContainer.Controls.Add(this.originalFibTable);
            this.originalFibTableContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.originalFibTableContainer.Location = new System.Drawing.Point(0, 0);
            this.originalFibTableContainer.Name = "originalFibTableContainer";
            this.originalFibTableContainer.Size = new System.Drawing.Size(488, 240);
            this.originalFibTableContainer.TabIndex = 2;
            // 
            // originalFibTable
            // 
            this.originalFibTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.originalFibTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.originalFibTable.Location = new System.Drawing.Point(0, 0);
            this.originalFibTable.Name = "originalFibTable";
            this.originalFibTable.RowHeadersWidth = 51;
            this.originalFibTable.RowTemplate.Height = 24;
            this.originalFibTable.Size = new System.Drawing.Size(488, 240);
            this.originalFibTable.TabIndex = 1;
            // 
            // originalFibButtonsPanel
            // 
            this.originalFibButtonsPanel.AutoSize = true;
            this.originalFibButtonsPanel.Controls.Add(this.loadButton);
            this.originalFibButtonsPanel.Controls.Add(this.saveButton);
            this.originalFibButtonsPanel.Controls.Add(this.clearFibButton);
            this.originalFibButtonsPanel.Controls.Add(this.addFibEntryButton);
            this.originalFibButtonsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.originalFibButtonsPanel.Location = new System.Drawing.Point(0, 240);
            this.originalFibButtonsPanel.Name = "originalFibButtonsPanel";
            this.originalFibButtonsPanel.Padding = new System.Windows.Forms.Padding(5);
            this.originalFibButtonsPanel.Size = new System.Drawing.Size(488, 48);
            this.originalFibButtonsPanel.TabIndex = 0;
            // 
            // loadButton
            // 
            this.loadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.loadButton.Location = new System.Drawing.Point(340, 8);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(67, 32);
            this.loadButton.TabIndex = 3;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Location = new System.Drawing.Point(413, 8);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(67, 32);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // clearFibButton
            // 
            this.clearFibButton.Location = new System.Drawing.Point(122, 8);
            this.clearFibButton.Name = "clearFibButton";
            this.clearFibButton.Size = new System.Drawing.Size(107, 32);
            this.clearFibButton.TabIndex = 1;
            this.clearFibButton.Text = "Clear FIB";
            this.clearFibButton.UseVisualStyleBackColor = true;
            this.clearFibButton.Click += new System.EventHandler(this.clearFibButton_Click);
            // 
            // addFibEntryButton
            // 
            this.addFibEntryButton.Location = new System.Drawing.Point(9, 8);
            this.addFibEntryButton.Name = "addFibEntryButton";
            this.addFibEntryButton.Size = new System.Drawing.Size(107, 31);
            this.addFibEntryButton.TabIndex = 0;
            this.addFibEntryButton.Text = "Add FIB entry";
            this.addFibEntryButton.UseVisualStyleBackColor = true;
            this.addFibEntryButton.Click += new System.EventHandler(this.addFibEntryButton_Click);
            // 
            // originalFibTree
            // 
            this.originalFibTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.originalFibTree.Location = new System.Drawing.Point(497, 3);
            this.originalFibTree.Name = "originalFibTree";
            this.originalFibTree.Size = new System.Drawing.Size(488, 288);
            this.originalFibTree.TabIndex = 2;
            // 
            // compressedFibTree
            // 
            this.compressedFibTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.compressedFibTree.Location = new System.Drawing.Point(497, 591);
            this.compressedFibTree.Name = "compressedFibTree";
            this.compressedFibTree.Size = new System.Drawing.Size(488, 288);
            this.compressedFibTree.TabIndex = 3;
            // 
            // compressedFibTableContainer
            // 
            this.compressedFibTableContainer.Controls.Add(this.compressedFibTable);
            this.compressedFibTableContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.compressedFibTableContainer.Location = new System.Drawing.Point(3, 591);
            this.compressedFibTableContainer.Name = "compressedFibTableContainer";
            this.compressedFibTableContainer.Size = new System.Drawing.Size(488, 288);
            this.compressedFibTableContainer.TabIndex = 6;
            // 
            // compressedFibTable
            // 
            this.compressedFibTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.compressedFibTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.compressedFibTable.Location = new System.Drawing.Point(0, 0);
            this.compressedFibTable.Name = "compressedFibTable";
            this.compressedFibTable.RowHeadersWidth = 51;
            this.compressedFibTable.RowTemplate.Height = 24;
            this.compressedFibTable.Size = new System.Drawing.Size(488, 288);
            this.compressedFibTable.TabIndex = 0;
            // 
            // originalNextHopTableContainer
            // 
            this.originalNextHopTableContainer.Controls.Add(this.originalNextHopTable);
            this.originalNextHopTableContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.originalNextHopTableContainer.Location = new System.Drawing.Point(991, 3);
            this.originalNextHopTableContainer.Name = "originalNextHopTableContainer";
            this.originalNextHopTableContainer.Size = new System.Drawing.Size(488, 288);
            this.originalNextHopTableContainer.TabIndex = 7;
            // 
            // originalNextHopTable
            // 
            this.originalNextHopTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.originalNextHopTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.originalNextHopTable.Location = new System.Drawing.Point(0, 0);
            this.originalNextHopTable.Name = "originalNextHopTable";
            this.originalNextHopTable.RowHeadersWidth = 51;
            this.originalNextHopTable.RowTemplate.Height = 24;
            this.originalNextHopTable.Size = new System.Drawing.Size(488, 288);
            this.originalNextHopTable.TabIndex = 0;
            // 
            // compressedNextHopTableContainer
            // 
            this.compressedNextHopTableContainer.Controls.Add(this.compressedNextHopTable);
            this.compressedNextHopTableContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.compressedNextHopTableContainer.Location = new System.Drawing.Point(991, 591);
            this.compressedNextHopTableContainer.Name = "compressedNextHopTableContainer";
            this.compressedNextHopTableContainer.Size = new System.Drawing.Size(488, 288);
            this.compressedNextHopTableContainer.TabIndex = 8;
            // 
            // compressedNextHopTable
            // 
            this.compressedNextHopTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.compressedNextHopTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.compressedNextHopTable.Location = new System.Drawing.Point(0, 0);
            this.compressedNextHopTable.Name = "compressedNextHopTable";
            this.compressedNextHopTable.RowHeadersWidth = 51;
            this.compressedNextHopTable.RowTemplate.Height = 24;
            this.compressedNextHopTable.Size = new System.Drawing.Size(488, 288);
            this.compressedNextHopTable.TabIndex = 0;
            // 
            // normalizedFibTableContainer
            // 
            this.normalizedFibTableContainer.Controls.Add(this.normalizedFibTable);
            this.normalizedFibTableContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.normalizedFibTableContainer.Location = new System.Drawing.Point(3, 297);
            this.normalizedFibTableContainer.Name = "normalizedFibTableContainer";
            this.normalizedFibTableContainer.Size = new System.Drawing.Size(488, 288);
            this.normalizedFibTableContainer.TabIndex = 9;
            // 
            // normalizedFibTable
            // 
            this.normalizedFibTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.normalizedFibTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.normalizedFibTable.Location = new System.Drawing.Point(0, 0);
            this.normalizedFibTable.Name = "normalizedFibTable";
            this.normalizedFibTable.RowHeadersWidth = 51;
            this.normalizedFibTable.RowTemplate.Height = 24;
            this.normalizedFibTable.Size = new System.Drawing.Size(488, 288);
            this.normalizedFibTable.TabIndex = 0;
            // 
            // normalizedNextHopTableContainer
            // 
            this.normalizedNextHopTableContainer.Controls.Add(this.normalizedNextHopTable);
            this.normalizedNextHopTableContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.normalizedNextHopTableContainer.Location = new System.Drawing.Point(991, 297);
            this.normalizedNextHopTableContainer.Name = "normalizedNextHopTableContainer";
            this.normalizedNextHopTableContainer.Size = new System.Drawing.Size(488, 288);
            this.normalizedNextHopTableContainer.TabIndex = 11;
            // 
            // normalizedNextHopTable
            // 
            this.normalizedNextHopTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.normalizedNextHopTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.normalizedNextHopTable.Location = new System.Drawing.Point(0, 0);
            this.normalizedNextHopTable.Name = "normalizedNextHopTable";
            this.normalizedNextHopTable.RowHeadersWidth = 51;
            this.normalizedNextHopTable.RowTemplate.Height = 24;
            this.normalizedNextHopTable.Size = new System.Drawing.Size(488, 288);
            this.normalizedNextHopTable.TabIndex = 0;
            // 
            // normalizedFibTree
            // 
            this.normalizedFibTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.normalizedFibTree.Location = new System.Drawing.Point(497, 297);
            this.normalizedFibTree.Name = "normalizedFibTree";
            this.normalizedFibTree.Size = new System.Drawing.Size(488, 288);
            this.normalizedFibTree.TabIndex = 12;
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "CSV files|*.csv|All files|*.*";
            this.openFileDialog.Title = "Open FIB table";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "CSV files|*.csv|All files|*.*";
            this.saveFileDialog.Title = "Save FIB table";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 953);
            this.Controls.Add(this.tableLayout);
            this.Controls.Add(this.header);
            this.Name = "MainForm";
            this.Text = "FIB_COMPRESS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.tableLayout.ResumeLayout(false);
            this.originalFibTableContainerPanel.ResumeLayout(false);
            this.originalFibTableContainerPanel.PerformLayout();
            this.originalFibTableContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.originalFibTable)).EndInit();
            this.originalFibButtonsPanel.ResumeLayout(false);
            this.compressedFibTableContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.compressedFibTable)).EndInit();
            this.originalNextHopTableContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.originalNextHopTable)).EndInit();
            this.compressedNextHopTableContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.compressedNextHopTable)).EndInit();
            this.normalizedFibTableContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.normalizedFibTable)).EndInit();
            this.normalizedNextHopTableContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.normalizedNextHopTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Label headerText;
        private System.Windows.Forms.Panel headerBorder;
        private System.Windows.Forms.TableLayoutPanel tableLayout;
        private System.Windows.Forms.Panel originalFibTableContainerPanel;
        private System.Windows.Forms.Panel originalFibButtonsPanel;
        private System.Windows.Forms.Button addFibEntryButton;
        private System.Windows.Forms.DataGridView originalFibTable;
        private System.Windows.Forms.TreeView originalFibTree;
        private System.Windows.Forms.TreeView compressedFibTree;
        private System.Windows.Forms.Button clearFibButton;
        private System.Windows.Forms.Panel originalFibTableContainer;
        private System.Windows.Forms.Panel compressedFibTableContainer;
        private System.Windows.Forms.DataGridView compressedFibTable;
        private System.Windows.Forms.Panel originalNextHopTableContainer;
        private System.Windows.Forms.DataGridView originalNextHopTable;
        private System.Windows.Forms.Panel compressedNextHopTableContainer;
        private System.Windows.Forms.DataGridView compressedNextHopTable;
        private System.Windows.Forms.Panel normalizedFibTableContainer;
        private System.Windows.Forms.DataGridView normalizedFibTable;
        private System.Windows.Forms.Panel normalizedNextHopTableContainer;
        private System.Windows.Forms.DataGridView normalizedNextHopTable;
        private System.Windows.Forms.TreeView normalizedFibTree;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

