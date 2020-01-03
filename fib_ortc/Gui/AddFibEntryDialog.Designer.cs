namespace fib_ortc.Gui
{
    partial class AddFibEntryDialog
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.prefixLabel = new System.Windows.Forms.Label();
            this.nextHopLabel = new System.Windows.Forms.Label();
            this.prefixTextBox = new System.Windows.Forms.TextBox();
            this.nextHopTextBox = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.prefixLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.nextHopLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.prefixTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.nextHopTextBox, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(356, 56);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // prefixLabel
            // 
            this.prefixLabel.AutoSize = true;
            this.prefixLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.prefixLabel.Location = new System.Drawing.Point(3, 0);
            this.prefixLabel.Name = "prefixLabel";
            this.prefixLabel.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.prefixLabel.Size = new System.Drawing.Size(57, 28);
            this.prefixLabel.TabIndex = 0;
            this.prefixLabel.Text = "Prefix:";
            this.prefixLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nextHopLabel
            // 
            this.nextHopLabel.AutoSize = true;
            this.nextHopLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.nextHopLabel.Location = new System.Drawing.Point(3, 28);
            this.nextHopLabel.Name = "nextHopLabel";
            this.nextHopLabel.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.nextHopLabel.Size = new System.Drawing.Size(78, 28);
            this.nextHopLabel.TabIndex = 1;
            this.nextHopLabel.Text = "Next hop:";
            this.nextHopLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // prefixTextBox
            // 
            this.prefixTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.prefixTextBox.Location = new System.Drawing.Point(87, 3);
            this.prefixTextBox.Name = "prefixTextBox";
            this.prefixTextBox.Size = new System.Drawing.Size(266, 22);
            this.prefixTextBox.TabIndex = 1;
            // 
            // nextHopTextBox
            // 
            this.nextHopTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.nextHopTextBox.Location = new System.Drawing.Point(87, 31);
            this.nextHopTextBox.Name = "nextHopTextBox";
            this.nextHopTextBox.Size = new System.Drawing.Size(266, 22);
            this.nextHopTextBox.TabIndex = 2;
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(265, 71);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(79, 36);
            this.okButton.TabIndex = 3;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(180, 71);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(79, 36);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // AddFibEntryDialog
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(356, 119);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddFibEntryDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Add FIB entry";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label prefixLabel;
        private System.Windows.Forms.Label nextHopLabel;
        private System.Windows.Forms.TextBox prefixTextBox;
        private System.Windows.Forms.TextBox nextHopTextBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
    }
}