﻿namespace fib_compress.Gui
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
            this.sortFibButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.clearFibButton = new System.Windows.Forms.Button();
            this.addFibEntryButton = new System.Windows.Forms.Button();
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
            this.ipLookupContainer = new System.Windows.Forms.Panel();
            this.ipLookupStatisticsTableContainer = new System.Windows.Forms.Panel();
            this.ipLookupStatisticsTable = new System.Windows.Forms.DataGridView();
            this.ipLookupButtonsPanel = new System.Windows.Forms.Panel();
            this.clearVisualizationButton = new System.Windows.Forms.Button();
            this.clearIpLookupTableButton = new System.Windows.Forms.Button();
            this.doLookupButton = new System.Windows.Forms.Button();
            this.originalFibTreeContainer = new System.Windows.Forms.Panel();
            this.originalFibTree = new System.Windows.Forms.TreeView();
            this.originalFibTreeInfoPanel = new System.Windows.Forms.Panel();
            this.originalFibTreeInfoLabel = new System.Windows.Forms.Label();
            this.normalizedFibTreeContainer = new System.Windows.Forms.Panel();
            this.normalizedFibTree = new System.Windows.Forms.TreeView();
            this.normalizedFibTreeInfoPanel = new System.Windows.Forms.Panel();
            this.normalizedFibTreeInfoLabel = new System.Windows.Forms.Label();
            this.compressedFibTreeContainer = new System.Windows.Forms.Panel();
            this.compressedFibTree = new System.Windows.Forms.TreeView();
            this.compressedFibTreeInfoPanel = new System.Windows.Forms.Panel();
            this.compressedFibTreeInfoLabel = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.originalRowLabel = new System.Windows.Forms.Label();
            this.normalizedRowLabel = new System.Windows.Forms.Label();
            this.compressedRowLabel = new System.Windows.Forms.Label();
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
            this.ipLookupContainer.SuspendLayout();
            this.ipLookupStatisticsTableContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ipLookupStatisticsTable)).BeginInit();
            this.ipLookupButtonsPanel.SuspendLayout();
            this.originalFibTreeContainer.SuspendLayout();
            this.originalFibTreeInfoPanel.SuspendLayout();
            this.normalizedFibTreeContainer.SuspendLayout();
            this.normalizedFibTreeInfoPanel.SuspendLayout();
            this.compressedFibTreeContainer.SuspendLayout();
            this.compressedFibTreeInfoPanel.SuspendLayout();
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
            this.header.Size = new System.Drawing.Size(1582, 71);
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
            this.headerBorder.Size = new System.Drawing.Size(1582, 4);
            this.headerBorder.TabIndex = 0;
            // 
            // tableLayout
            // 
            this.tableLayout.ColumnCount = 4;
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33444F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33444F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33111F));
            this.tableLayout.Controls.Add(this.compressedRowLabel, 0, 2);
            this.tableLayout.Controls.Add(this.normalizedRowLabel, 0, 1);
            this.tableLayout.Controls.Add(this.originalFibTableContainerPanel, 1, 0);
            this.tableLayout.Controls.Add(this.compressedFibTableContainer, 1, 2);
            this.tableLayout.Controls.Add(this.originalNextHopTableContainer, 3, 0);
            this.tableLayout.Controls.Add(this.compressedNextHopTableContainer, 3, 2);
            this.tableLayout.Controls.Add(this.normalizedFibTableContainer, 1, 1);
            this.tableLayout.Controls.Add(this.normalizedNextHopTableContainer, 3, 1);
            this.tableLayout.Controls.Add(this.ipLookupContainer, 0, 3);
            this.tableLayout.Controls.Add(this.originalFibTreeContainer, 2, 0);
            this.tableLayout.Controls.Add(this.normalizedFibTreeContainer, 2, 1);
            this.tableLayout.Controls.Add(this.compressedFibTreeContainer, 2, 2);
            this.tableLayout.Controls.Add(this.originalRowLabel, 0, 0);
            this.tableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout.Location = new System.Drawing.Point(0, 71);
            this.tableLayout.Name = "tableLayout";
            this.tableLayout.RowCount = 4;
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayout.Size = new System.Drawing.Size(1582, 882);
            this.tableLayout.TabIndex = 1;
            // 
            // originalFibTableContainerPanel
            // 
            this.originalFibTableContainerPanel.Controls.Add(this.originalFibTableContainer);
            this.originalFibTableContainerPanel.Controls.Add(this.originalFibButtonsPanel);
            this.originalFibTableContainerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.originalFibTableContainerPanel.Location = new System.Drawing.Point(37, 3);
            this.originalFibTableContainerPanel.Name = "originalFibTableContainerPanel";
            this.originalFibTableContainerPanel.Size = new System.Drawing.Size(510, 214);
            this.originalFibTableContainerPanel.TabIndex = 0;
            // 
            // originalFibTableContainer
            // 
            this.originalFibTableContainer.Controls.Add(this.originalFibTable);
            this.originalFibTableContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.originalFibTableContainer.Location = new System.Drawing.Point(0, 0);
            this.originalFibTableContainer.Name = "originalFibTableContainer";
            this.originalFibTableContainer.Size = new System.Drawing.Size(510, 166);
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
            this.originalFibTable.Size = new System.Drawing.Size(510, 166);
            this.originalFibTable.TabIndex = 1;
            // 
            // originalFibButtonsPanel
            // 
            this.originalFibButtonsPanel.AutoSize = true;
            this.originalFibButtonsPanel.Controls.Add(this.sortFibButton);
            this.originalFibButtonsPanel.Controls.Add(this.loadButton);
            this.originalFibButtonsPanel.Controls.Add(this.saveButton);
            this.originalFibButtonsPanel.Controls.Add(this.clearFibButton);
            this.originalFibButtonsPanel.Controls.Add(this.addFibEntryButton);
            this.originalFibButtonsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.originalFibButtonsPanel.Location = new System.Drawing.Point(0, 166);
            this.originalFibButtonsPanel.Name = "originalFibButtonsPanel";
            this.originalFibButtonsPanel.Padding = new System.Windows.Forms.Padding(5);
            this.originalFibButtonsPanel.Size = new System.Drawing.Size(510, 48);
            this.originalFibButtonsPanel.TabIndex = 0;
            // 
            // sortFibButton
            // 
            this.sortFibButton.Location = new System.Drawing.Point(235, 8);
            this.sortFibButton.Name = "sortFibButton";
            this.sortFibButton.Size = new System.Drawing.Size(107, 32);
            this.sortFibButton.TabIndex = 4;
            this.sortFibButton.Text = "Sort FIB";
            this.sortFibButton.UseVisualStyleBackColor = true;
            this.sortFibButton.Click += new System.EventHandler(this.sortFibButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.loadButton.Location = new System.Drawing.Point(362, 8);
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
            this.saveButton.Location = new System.Drawing.Point(435, 8);
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
            // compressedFibTableContainer
            // 
            this.compressedFibTableContainer.Controls.Add(this.compressedFibTable);
            this.compressedFibTableContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.compressedFibTableContainer.Location = new System.Drawing.Point(37, 443);
            this.compressedFibTableContainer.Name = "compressedFibTableContainer";
            this.compressedFibTableContainer.Size = new System.Drawing.Size(510, 214);
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
            this.compressedFibTable.Size = new System.Drawing.Size(510, 214);
            this.compressedFibTable.TabIndex = 0;
            // 
            // originalNextHopTableContainer
            // 
            this.originalNextHopTableContainer.Controls.Add(this.originalNextHopTable);
            this.originalNextHopTableContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.originalNextHopTableContainer.Location = new System.Drawing.Point(1069, 3);
            this.originalNextHopTableContainer.Name = "originalNextHopTableContainer";
            this.originalNextHopTableContainer.Size = new System.Drawing.Size(510, 214);
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
            this.originalNextHopTable.Size = new System.Drawing.Size(510, 214);
            this.originalNextHopTable.TabIndex = 0;
            // 
            // compressedNextHopTableContainer
            // 
            this.compressedNextHopTableContainer.Controls.Add(this.compressedNextHopTable);
            this.compressedNextHopTableContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.compressedNextHopTableContainer.Location = new System.Drawing.Point(1069, 443);
            this.compressedNextHopTableContainer.Name = "compressedNextHopTableContainer";
            this.compressedNextHopTableContainer.Size = new System.Drawing.Size(510, 214);
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
            this.compressedNextHopTable.Size = new System.Drawing.Size(510, 214);
            this.compressedNextHopTable.TabIndex = 0;
            // 
            // normalizedFibTableContainer
            // 
            this.normalizedFibTableContainer.Controls.Add(this.normalizedFibTable);
            this.normalizedFibTableContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.normalizedFibTableContainer.Location = new System.Drawing.Point(37, 223);
            this.normalizedFibTableContainer.Name = "normalizedFibTableContainer";
            this.normalizedFibTableContainer.Size = new System.Drawing.Size(510, 214);
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
            this.normalizedFibTable.Size = new System.Drawing.Size(510, 214);
            this.normalizedFibTable.TabIndex = 0;
            // 
            // normalizedNextHopTableContainer
            // 
            this.normalizedNextHopTableContainer.Controls.Add(this.normalizedNextHopTable);
            this.normalizedNextHopTableContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.normalizedNextHopTableContainer.Location = new System.Drawing.Point(1069, 223);
            this.normalizedNextHopTableContainer.Name = "normalizedNextHopTableContainer";
            this.normalizedNextHopTableContainer.Size = new System.Drawing.Size(510, 214);
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
            this.normalizedNextHopTable.Size = new System.Drawing.Size(510, 214);
            this.normalizedNextHopTable.TabIndex = 0;
            // 
            // ipLookupContainer
            // 
            this.tableLayout.SetColumnSpan(this.ipLookupContainer, 4);
            this.ipLookupContainer.Controls.Add(this.ipLookupStatisticsTableContainer);
            this.ipLookupContainer.Controls.Add(this.ipLookupButtonsPanel);
            this.ipLookupContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ipLookupContainer.Location = new System.Drawing.Point(3, 663);
            this.ipLookupContainer.Name = "ipLookupContainer";
            this.ipLookupContainer.Size = new System.Drawing.Size(1576, 216);
            this.ipLookupContainer.TabIndex = 13;
            // 
            // ipLookupStatisticsTableContainer
            // 
            this.ipLookupStatisticsTableContainer.Controls.Add(this.ipLookupStatisticsTable);
            this.ipLookupStatisticsTableContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ipLookupStatisticsTableContainer.Location = new System.Drawing.Point(0, 0);
            this.ipLookupStatisticsTableContainer.Name = "ipLookupStatisticsTableContainer";
            this.ipLookupStatisticsTableContainer.Size = new System.Drawing.Size(1576, 169);
            this.ipLookupStatisticsTableContainer.TabIndex = 2;
            // 
            // ipLookupStatisticsTable
            // 
            this.ipLookupStatisticsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ipLookupStatisticsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ipLookupStatisticsTable.Location = new System.Drawing.Point(0, 0);
            this.ipLookupStatisticsTable.Name = "ipLookupStatisticsTable";
            this.ipLookupStatisticsTable.RowHeadersWidth = 51;
            this.ipLookupStatisticsTable.RowTemplate.Height = 24;
            this.ipLookupStatisticsTable.Size = new System.Drawing.Size(1576, 169);
            this.ipLookupStatisticsTable.TabIndex = 0;
            // 
            // ipLookupButtonsPanel
            // 
            this.ipLookupButtonsPanel.AutoSize = true;
            this.ipLookupButtonsPanel.Controls.Add(this.clearVisualizationButton);
            this.ipLookupButtonsPanel.Controls.Add(this.clearIpLookupTableButton);
            this.ipLookupButtonsPanel.Controls.Add(this.doLookupButton);
            this.ipLookupButtonsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ipLookupButtonsPanel.Location = new System.Drawing.Point(0, 169);
            this.ipLookupButtonsPanel.Name = "ipLookupButtonsPanel";
            this.ipLookupButtonsPanel.Padding = new System.Windows.Forms.Padding(5);
            this.ipLookupButtonsPanel.Size = new System.Drawing.Size(1576, 47);
            this.ipLookupButtonsPanel.TabIndex = 1;
            // 
            // clearVisualizationButton
            // 
            this.clearVisualizationButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clearVisualizationButton.Location = new System.Drawing.Point(1054, 9);
            this.clearVisualizationButton.Name = "clearVisualizationButton";
            this.clearVisualizationButton.Size = new System.Drawing.Size(163, 30);
            this.clearVisualizationButton.TabIndex = 2;
            this.clearVisualizationButton.Text = "Clear visualization";
            this.clearVisualizationButton.UseVisualStyleBackColor = true;
            this.clearVisualizationButton.Click += new System.EventHandler(this.clearVisualizationButton_Click);
            // 
            // clearIpLookupTableButton
            // 
            this.clearIpLookupTableButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clearIpLookupTableButton.Location = new System.Drawing.Point(1323, 9);
            this.clearIpLookupTableButton.Name = "clearIpLookupTableButton";
            this.clearIpLookupTableButton.Size = new System.Drawing.Size(119, 30);
            this.clearIpLookupTableButton.TabIndex = 1;
            this.clearIpLookupTableButton.Text = "Clear";
            this.clearIpLookupTableButton.UseVisualStyleBackColor = true;
            this.clearIpLookupTableButton.Click += new System.EventHandler(this.clearIpLookupTableButton_Click);
            // 
            // doLookupButton
            // 
            this.doLookupButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.doLookupButton.Location = new System.Drawing.Point(1448, 9);
            this.doLookupButton.Name = "doLookupButton";
            this.doLookupButton.Size = new System.Drawing.Size(119, 30);
            this.doLookupButton.TabIndex = 0;
            this.doLookupButton.Text = "Do lookup";
            this.doLookupButton.UseVisualStyleBackColor = true;
            this.doLookupButton.Click += new System.EventHandler(this.doLookupButton_Click);
            // 
            // originalFibTreeContainer
            // 
            this.originalFibTreeContainer.Controls.Add(this.originalFibTree);
            this.originalFibTreeContainer.Controls.Add(this.originalFibTreeInfoPanel);
            this.originalFibTreeContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.originalFibTreeContainer.Location = new System.Drawing.Point(553, 3);
            this.originalFibTreeContainer.Name = "originalFibTreeContainer";
            this.originalFibTreeContainer.Size = new System.Drawing.Size(510, 214);
            this.originalFibTreeContainer.TabIndex = 14;
            // 
            // originalFibTree
            // 
            this.originalFibTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.originalFibTree.Location = new System.Drawing.Point(0, 0);
            this.originalFibTree.Name = "originalFibTree";
            this.originalFibTree.Size = new System.Drawing.Size(510, 181);
            this.originalFibTree.TabIndex = 2;
            // 
            // originalFibTreeInfoPanel
            // 
            this.originalFibTreeInfoPanel.AutoSize = true;
            this.originalFibTreeInfoPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.originalFibTreeInfoPanel.Controls.Add(this.originalFibTreeInfoLabel);
            this.originalFibTreeInfoPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.originalFibTreeInfoPanel.Location = new System.Drawing.Point(0, 181);
            this.originalFibTreeInfoPanel.Name = "originalFibTreeInfoPanel";
            this.originalFibTreeInfoPanel.Padding = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.originalFibTreeInfoPanel.Size = new System.Drawing.Size(510, 33);
            this.originalFibTreeInfoPanel.TabIndex = 3;
            // 
            // originalFibTreeInfoLabel
            // 
            this.originalFibTreeInfoLabel.AutoSize = true;
            this.originalFibTreeInfoLabel.Location = new System.Drawing.Point(8, 8);
            this.originalFibTreeInfoLabel.Name = "originalFibTreeInfoLabel";
            this.originalFibTreeInfoLabel.Size = new System.Drawing.Size(70, 17);
            this.originalFibTreeInfoLabel.TabIndex = 0;
            this.originalFibTreeInfoLabel.Text = "(tree info)";
            // 
            // normalizedFibTreeContainer
            // 
            this.normalizedFibTreeContainer.Controls.Add(this.normalizedFibTree);
            this.normalizedFibTreeContainer.Controls.Add(this.normalizedFibTreeInfoPanel);
            this.normalizedFibTreeContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.normalizedFibTreeContainer.Location = new System.Drawing.Point(553, 223);
            this.normalizedFibTreeContainer.Name = "normalizedFibTreeContainer";
            this.normalizedFibTreeContainer.Size = new System.Drawing.Size(510, 214);
            this.normalizedFibTreeContainer.TabIndex = 15;
            // 
            // normalizedFibTree
            // 
            this.normalizedFibTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.normalizedFibTree.Location = new System.Drawing.Point(0, 0);
            this.normalizedFibTree.Name = "normalizedFibTree";
            this.normalizedFibTree.Size = new System.Drawing.Size(510, 181);
            this.normalizedFibTree.TabIndex = 12;
            // 
            // normalizedFibTreeInfoPanel
            // 
            this.normalizedFibTreeInfoPanel.AutoSize = true;
            this.normalizedFibTreeInfoPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.normalizedFibTreeInfoPanel.Controls.Add(this.normalizedFibTreeInfoLabel);
            this.normalizedFibTreeInfoPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.normalizedFibTreeInfoPanel.Location = new System.Drawing.Point(0, 181);
            this.normalizedFibTreeInfoPanel.Name = "normalizedFibTreeInfoPanel";
            this.normalizedFibTreeInfoPanel.Padding = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.normalizedFibTreeInfoPanel.Size = new System.Drawing.Size(510, 33);
            this.normalizedFibTreeInfoPanel.TabIndex = 13;
            // 
            // normalizedFibTreeInfoLabel
            // 
            this.normalizedFibTreeInfoLabel.AutoSize = true;
            this.normalizedFibTreeInfoLabel.Location = new System.Drawing.Point(8, 8);
            this.normalizedFibTreeInfoLabel.Name = "normalizedFibTreeInfoLabel";
            this.normalizedFibTreeInfoLabel.Size = new System.Drawing.Size(70, 17);
            this.normalizedFibTreeInfoLabel.TabIndex = 0;
            this.normalizedFibTreeInfoLabel.Text = "(tree info)";
            // 
            // compressedFibTreeContainer
            // 
            this.compressedFibTreeContainer.Controls.Add(this.compressedFibTree);
            this.compressedFibTreeContainer.Controls.Add(this.compressedFibTreeInfoPanel);
            this.compressedFibTreeContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.compressedFibTreeContainer.Location = new System.Drawing.Point(553, 443);
            this.compressedFibTreeContainer.Name = "compressedFibTreeContainer";
            this.compressedFibTreeContainer.Size = new System.Drawing.Size(510, 214);
            this.compressedFibTreeContainer.TabIndex = 16;
            // 
            // compressedFibTree
            // 
            this.compressedFibTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.compressedFibTree.Location = new System.Drawing.Point(0, 0);
            this.compressedFibTree.Name = "compressedFibTree";
            this.compressedFibTree.Size = new System.Drawing.Size(510, 181);
            this.compressedFibTree.TabIndex = 3;
            // 
            // compressedFibTreeInfoPanel
            // 
            this.compressedFibTreeInfoPanel.AutoSize = true;
            this.compressedFibTreeInfoPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.compressedFibTreeInfoPanel.Controls.Add(this.compressedFibTreeInfoLabel);
            this.compressedFibTreeInfoPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.compressedFibTreeInfoPanel.Location = new System.Drawing.Point(0, 181);
            this.compressedFibTreeInfoPanel.Name = "compressedFibTreeInfoPanel";
            this.compressedFibTreeInfoPanel.Padding = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.compressedFibTreeInfoPanel.Size = new System.Drawing.Size(510, 33);
            this.compressedFibTreeInfoPanel.TabIndex = 4;
            // 
            // compressedFibTreeInfoLabel
            // 
            this.compressedFibTreeInfoLabel.AutoSize = true;
            this.compressedFibTreeInfoLabel.Location = new System.Drawing.Point(8, 8);
            this.compressedFibTreeInfoLabel.Name = "compressedFibTreeInfoLabel";
            this.compressedFibTreeInfoLabel.Size = new System.Drawing.Size(70, 17);
            this.compressedFibTreeInfoLabel.TabIndex = 0;
            this.compressedFibTreeInfoLabel.Text = "(tree info)";
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
            // originalRowLabel
            // 
            this.originalRowLabel.AutoSize = true;
            this.originalRowLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.originalRowLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.originalRowLabel.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.originalRowLabel.ForeColor = System.Drawing.Color.Navy;
            this.originalRowLabel.Location = new System.Drawing.Point(3, 0);
            this.originalRowLabel.Name = "originalRowLabel";
            this.originalRowLabel.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.originalRowLabel.Size = new System.Drawing.Size(28, 220);
            this.originalRowLabel.TabIndex = 17;
            this.originalRowLabel.Text = "O\r\nR\r\nI\r\nG\r\nI\r\nN\r\nA\r\nL";
            this.originalRowLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // normalizedRowLabel
            // 
            this.normalizedRowLabel.AutoSize = true;
            this.normalizedRowLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.normalizedRowLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.normalizedRowLabel.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.normalizedRowLabel.ForeColor = System.Drawing.Color.Navy;
            this.normalizedRowLabel.Location = new System.Drawing.Point(3, 220);
            this.normalizedRowLabel.Name = "normalizedRowLabel";
            this.normalizedRowLabel.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.normalizedRowLabel.Size = new System.Drawing.Size(28, 220);
            this.normalizedRowLabel.TabIndex = 18;
            this.normalizedRowLabel.Text = "N\r\nO\r\nR\r\nM\r\nA\r\nL\r\nI\r\nZ\r\nE\r\nD";
            this.normalizedRowLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // compressedRowLabel
            // 
            this.compressedRowLabel.AutoSize = true;
            this.compressedRowLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.compressedRowLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.compressedRowLabel.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.compressedRowLabel.ForeColor = System.Drawing.Color.Navy;
            this.compressedRowLabel.Location = new System.Drawing.Point(3, 440);
            this.compressedRowLabel.Name = "compressedRowLabel";
            this.compressedRowLabel.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.compressedRowLabel.Size = new System.Drawing.Size(28, 220);
            this.compressedRowLabel.TabIndex = 19;
            this.compressedRowLabel.Text = "C\r\nO\r\nM\r\nP\r\nR\r\nE\r\nS\r\nS\r\nE\r\nD";
            this.compressedRowLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 953);
            this.Controls.Add(this.tableLayout);
            this.Controls.Add(this.header);
            this.Name = "MainForm";
            this.Text = "FIB_COMPRESS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.tableLayout.ResumeLayout(false);
            this.tableLayout.PerformLayout();
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
            this.ipLookupContainer.ResumeLayout(false);
            this.ipLookupContainer.PerformLayout();
            this.ipLookupStatisticsTableContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ipLookupStatisticsTable)).EndInit();
            this.ipLookupButtonsPanel.ResumeLayout(false);
            this.originalFibTreeContainer.ResumeLayout(false);
            this.originalFibTreeContainer.PerformLayout();
            this.originalFibTreeInfoPanel.ResumeLayout(false);
            this.originalFibTreeInfoPanel.PerformLayout();
            this.normalizedFibTreeContainer.ResumeLayout(false);
            this.normalizedFibTreeContainer.PerformLayout();
            this.normalizedFibTreeInfoPanel.ResumeLayout(false);
            this.normalizedFibTreeInfoPanel.PerformLayout();
            this.compressedFibTreeContainer.ResumeLayout(false);
            this.compressedFibTreeContainer.PerformLayout();
            this.compressedFibTreeInfoPanel.ResumeLayout(false);
            this.compressedFibTreeInfoPanel.PerformLayout();
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
        private System.Windows.Forms.Button sortFibButton;
        private System.Windows.Forms.Panel ipLookupContainer;
        private System.Windows.Forms.Panel ipLookupButtonsPanel;
        private System.Windows.Forms.Button doLookupButton;
        private System.Windows.Forms.DataGridView ipLookupStatisticsTable;
        private System.Windows.Forms.Panel ipLookupStatisticsTableContainer;
        private System.Windows.Forms.Button clearIpLookupTableButton;
        private System.Windows.Forms.Button clearVisualizationButton;
        private System.Windows.Forms.Panel originalFibTreeContainer;
        private System.Windows.Forms.Panel normalizedFibTreeContainer;
        private System.Windows.Forms.Panel compressedFibTreeContainer;
        private System.Windows.Forms.Panel originalFibTreeInfoPanel;
        private System.Windows.Forms.Label originalFibTreeInfoLabel;
        private System.Windows.Forms.Panel normalizedFibTreeInfoPanel;
        private System.Windows.Forms.Label normalizedFibTreeInfoLabel;
        private System.Windows.Forms.Panel compressedFibTreeInfoPanel;
        private System.Windows.Forms.Label compressedFibTreeInfoLabel;
        private System.Windows.Forms.Label originalRowLabel;
        private System.Windows.Forms.Label compressedRowLabel;
        private System.Windows.Forms.Label normalizedRowLabel;
    }
}

