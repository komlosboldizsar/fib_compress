namespace fib_ortc
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
            this.originalFibTable = new System.Windows.Forms.DataGridView();
            this.originalFibButtonsPanel = new System.Windows.Forms.Panel();
            this.clearFibButton = new System.Windows.Forms.Button();
            this.addFibEntryButton = new System.Windows.Forms.Button();
            this.ortcFibTable = new System.Windows.Forms.DataGridView();
            this.originalFibTree = new System.Windows.Forms.TreeView();
            this.ortcFibTree = new System.Windows.Forms.TreeView();
            this.originalNextHopTable = new System.Windows.Forms.DataGridView();
            this.ortcNextHopTable = new System.Windows.Forms.DataGridView();
            this.header.SuspendLayout();
            this.tableLayout.SuspendLayout();
            this.originalFibTableContainerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.originalFibTable)).BeginInit();
            this.originalFibButtonsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ortcFibTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.originalNextHopTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ortcNextHopTable)).BeginInit();
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
            this.header.Size = new System.Drawing.Size(982, 71);
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
            this.headerText.Size = new System.Drawing.Size(216, 67);
            this.headerText.TabIndex = 1;
            this.headerText.Text = "FIB_ORTC";
            // 
            // headerBorder
            // 
            this.headerBorder.AutoSize = true;
            this.headerBorder.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.headerBorder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.headerBorder.Location = new System.Drawing.Point(0, 67);
            this.headerBorder.Name = "headerBorder";
            this.headerBorder.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.headerBorder.Size = new System.Drawing.Size(982, 4);
            this.headerBorder.TabIndex = 0;
            // 
            // tableLayout
            // 
            this.tableLayout.ColumnCount = 3;
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayout.Controls.Add(this.originalFibTableContainerPanel, 0, 0);
            this.tableLayout.Controls.Add(this.ortcFibTable, 0, 1);
            this.tableLayout.Controls.Add(this.originalFibTree, 1, 0);
            this.tableLayout.Controls.Add(this.ortcFibTree, 1, 1);
            this.tableLayout.Controls.Add(this.originalNextHopTable, 2, 0);
            this.tableLayout.Controls.Add(this.ortcNextHopTable, 2, 1);
            this.tableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout.Location = new System.Drawing.Point(0, 71);
            this.tableLayout.Name = "tableLayout";
            this.tableLayout.RowCount = 2;
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout.Size = new System.Drawing.Size(982, 582);
            this.tableLayout.TabIndex = 1;
            // 
            // originalFibTableContainerPanel
            // 
            this.originalFibTableContainerPanel.Controls.Add(this.originalFibTable);
            this.originalFibTableContainerPanel.Controls.Add(this.originalFibButtonsPanel);
            this.originalFibTableContainerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.originalFibTableContainerPanel.Location = new System.Drawing.Point(3, 3);
            this.originalFibTableContainerPanel.Name = "originalFibTableContainerPanel";
            this.originalFibTableContainerPanel.Size = new System.Drawing.Size(321, 285);
            this.originalFibTableContainerPanel.TabIndex = 0;
            // 
            // originalFibTable
            // 
            this.originalFibTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.originalFibTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.originalFibTable.Location = new System.Drawing.Point(0, 0);
            this.originalFibTable.Name = "originalFibTable";
            this.originalFibTable.RowHeadersWidth = 51;
            this.originalFibTable.RowTemplate.Height = 24;
            this.originalFibTable.Size = new System.Drawing.Size(321, 237);
            this.originalFibTable.TabIndex = 1;
            // 
            // originalFibButtonsPanel
            // 
            this.originalFibButtonsPanel.AutoSize = true;
            this.originalFibButtonsPanel.Controls.Add(this.clearFibButton);
            this.originalFibButtonsPanel.Controls.Add(this.addFibEntryButton);
            this.originalFibButtonsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.originalFibButtonsPanel.Location = new System.Drawing.Point(0, 237);
            this.originalFibButtonsPanel.Name = "originalFibButtonsPanel";
            this.originalFibButtonsPanel.Padding = new System.Windows.Forms.Padding(5);
            this.originalFibButtonsPanel.Size = new System.Drawing.Size(321, 48);
            this.originalFibButtonsPanel.TabIndex = 0;
            // 
            // clearFibButton
            // 
            this.clearFibButton.Location = new System.Drawing.Point(122, 8);
            this.clearFibButton.Name = "clearFibButton";
            this.clearFibButton.Size = new System.Drawing.Size(107, 32);
            this.clearFibButton.TabIndex = 1;
            this.clearFibButton.Text = "Clear FIB";
            this.clearFibButton.UseVisualStyleBackColor = true;
            // 
            // addFibEntryButton
            // 
            this.addFibEntryButton.Location = new System.Drawing.Point(9, 8);
            this.addFibEntryButton.Name = "addFibEntryButton";
            this.addFibEntryButton.Size = new System.Drawing.Size(107, 31);
            this.addFibEntryButton.TabIndex = 0;
            this.addFibEntryButton.Text = "Add FIB entry";
            this.addFibEntryButton.UseVisualStyleBackColor = true;
            // 
            // ortcFibTable
            // 
            this.ortcFibTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ortcFibTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ortcFibTable.Location = new System.Drawing.Point(3, 294);
            this.ortcFibTable.Name = "ortcFibTable";
            this.ortcFibTable.RowHeadersWidth = 51;
            this.ortcFibTable.RowTemplate.Height = 24;
            this.ortcFibTable.Size = new System.Drawing.Size(321, 285);
            this.ortcFibTable.TabIndex = 1;
            // 
            // originalFibTree
            // 
            this.originalFibTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.originalFibTree.Location = new System.Drawing.Point(330, 3);
            this.originalFibTree.Name = "originalFibTree";
            this.originalFibTree.Size = new System.Drawing.Size(321, 285);
            this.originalFibTree.TabIndex = 2;
            // 
            // ortcFibTree
            // 
            this.ortcFibTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ortcFibTree.Location = new System.Drawing.Point(330, 294);
            this.ortcFibTree.Name = "ortcFibTree";
            this.ortcFibTree.Size = new System.Drawing.Size(321, 285);
            this.ortcFibTree.TabIndex = 3;
            // 
            // originalNextHopTable
            // 
            this.originalNextHopTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.originalNextHopTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.originalNextHopTable.Location = new System.Drawing.Point(657, 3);
            this.originalNextHopTable.Name = "originalNextHopTable";
            this.originalNextHopTable.RowHeadersWidth = 51;
            this.originalNextHopTable.RowTemplate.Height = 24;
            this.originalNextHopTable.Size = new System.Drawing.Size(322, 285);
            this.originalNextHopTable.TabIndex = 4;
            // 
            // ortcNextHopTable
            // 
            this.ortcNextHopTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ortcNextHopTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ortcNextHopTable.Location = new System.Drawing.Point(657, 294);
            this.ortcNextHopTable.Name = "ortcNextHopTable";
            this.ortcNextHopTable.RowHeadersWidth = 51;
            this.ortcNextHopTable.RowTemplate.Height = 24;
            this.ortcNextHopTable.Size = new System.Drawing.Size(322, 285);
            this.ortcNextHopTable.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.tableLayout);
            this.Controls.Add(this.header);
            this.Name = "MainForm";
            this.Text = "FIB_ORTC";
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.tableLayout.ResumeLayout(false);
            this.originalFibTableContainerPanel.ResumeLayout(false);
            this.originalFibTableContainerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.originalFibTable)).EndInit();
            this.originalFibButtonsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ortcFibTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.originalNextHopTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ortcNextHopTable)).EndInit();
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
        private System.Windows.Forms.DataGridView ortcFibTable;
        private System.Windows.Forms.TreeView originalFibTree;
        private System.Windows.Forms.TreeView ortcFibTree;
        private System.Windows.Forms.DataGridView originalNextHopTable;
        private System.Windows.Forms.DataGridView ortcNextHopTable;
        private System.Windows.Forms.Button clearFibButton;
    }
}

