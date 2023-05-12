namespace ori_save_tool
{
    partial class Form1
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
            this.basePanel = new System.Windows.Forms.Panel();
            this.statusTextLabel = new System.Windows.Forms.Label();
            this.selectReplaceOrInsertTable = new System.Windows.Forms.TableLayoutPanel();
            this.replaceButton = new System.Windows.Forms.Button();
            this.insertButton = new System.Windows.Forms.Button();
            this.selectReplaceOrInsertActionLabel = new System.Windows.Forms.Label();
            this.replacementFileSelectionTable = new System.Windows.Forms.TableLayoutPanel();
            this.chooseReplacementFilePaddingPanel = new System.Windows.Forms.Panel();
            this.readonlyReplacementFileTextBox = new System.Windows.Forms.TextBox();
            this.chooseReplacementFileButton = new System.Windows.Forms.Button();
            this.selectReplacementLabel = new System.Windows.Forms.Label();
            this.basicControlsTable = new System.Windows.Forms.TableLayoutPanel();
            this.downShiftButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.upShiftButton = new System.Windows.Forms.Button();
            this.basicControlsLabel = new System.Windows.Forms.Label();
            this.initialFileSelectionTable = new System.Windows.Forms.TableLayoutPanel();
            this.chooseInitialFilePaddingPanel = new System.Windows.Forms.Panel();
            this.readOnlyInitialFileTextBox = new System.Windows.Forms.TextBox();
            this.chooseInitialFileButton = new System.Windows.Forms.Button();
            this.selectInitialLabel = new System.Windows.Forms.Label();
            this.basePanel.SuspendLayout();
            this.selectReplaceOrInsertTable.SuspendLayout();
            this.replacementFileSelectionTable.SuspendLayout();
            this.chooseReplacementFilePaddingPanel.SuspendLayout();
            this.basicControlsTable.SuspendLayout();
            this.initialFileSelectionTable.SuspendLayout();
            this.chooseInitialFilePaddingPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // basePanel
            // 
            this.basePanel.AutoSize = true;
            this.basePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.basePanel.Controls.Add(this.statusTextLabel);
            this.basePanel.Controls.Add(this.selectReplaceOrInsertTable);
            this.basePanel.Controls.Add(this.selectReplaceOrInsertActionLabel);
            this.basePanel.Controls.Add(this.replacementFileSelectionTable);
            this.basePanel.Controls.Add(this.selectReplacementLabel);
            this.basePanel.Controls.Add(this.basicControlsTable);
            this.basePanel.Controls.Add(this.basicControlsLabel);
            this.basePanel.Controls.Add(this.initialFileSelectionTable);
            this.basePanel.Controls.Add(this.selectInitialLabel);
            this.basePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.basePanel.Location = new System.Drawing.Point(0, 0);
            this.basePanel.Name = "basePanel";
            this.basePanel.Padding = new System.Windows.Forms.Padding(5);
            this.basePanel.Size = new System.Drawing.Size(283, 432);
            this.basePanel.TabIndex = 2;
            // 
            // statusTextLabel
            // 
            this.statusTextLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusTextLabel.AutoSize = true;
            this.statusTextLabel.Location = new System.Drawing.Point(107, 207);
            this.statusTextLabel.Name = "statusTextLabel";
            this.statusTextLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.statusTextLabel.Size = new System.Drawing.Size(51, 16);
            this.statusTextLabel.TabIndex = 16;
            this.statusTextLabel.Text = "Fuck you";
            // 
            // selectReplaceOrInsertTable
            // 
            this.selectReplaceOrInsertTable.AutoSize = true;
            this.selectReplaceOrInsertTable.ColumnCount = 2;
            this.selectReplaceOrInsertTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.selectReplaceOrInsertTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.selectReplaceOrInsertTable.Controls.Add(this.replaceButton, 0, 0);
            this.selectReplaceOrInsertTable.Controls.Add(this.insertButton, 1, 0);
            this.selectReplaceOrInsertTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.selectReplaceOrInsertTable.Location = new System.Drawing.Point(5, 167);
            this.selectReplaceOrInsertTable.Name = "selectReplaceOrInsertTable";
            this.selectReplaceOrInsertTable.RowCount = 1;
            this.selectReplaceOrInsertTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.selectReplaceOrInsertTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.selectReplaceOrInsertTable.Size = new System.Drawing.Size(273, 29);
            this.selectReplaceOrInsertTable.TabIndex = 15;
            // 
            // replaceButton
            // 
            this.replaceButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.replaceButton.Location = new System.Drawing.Point(3, 3);
            this.replaceButton.Name = "replaceButton";
            this.replaceButton.Size = new System.Drawing.Size(130, 23);
            this.replaceButton.TabIndex = 0;
            this.replaceButton.Text = "Replace";
            this.replaceButton.UseVisualStyleBackColor = true;
            // 
            // insertButton
            // 
            this.insertButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.insertButton.Location = new System.Drawing.Point(139, 3);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(131, 23);
            this.insertButton.TabIndex = 1;
            this.insertButton.Text = "Insert";
            this.insertButton.UseVisualStyleBackColor = true;
            // 
            // selectReplaceOrInsertActionLabel
            // 
            this.selectReplaceOrInsertActionLabel.AutoSize = true;
            this.selectReplaceOrInsertActionLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.selectReplaceOrInsertActionLabel.Location = new System.Drawing.Point(5, 148);
            this.selectReplaceOrInsertActionLabel.Name = "selectReplaceOrInsertActionLabel";
            this.selectReplaceOrInsertActionLabel.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.selectReplaceOrInsertActionLabel.Size = new System.Drawing.Size(69, 19);
            this.selectReplaceOrInsertActionLabel.TabIndex = 14;
            this.selectReplaceOrInsertActionLabel.Text = "Select action";
            // 
            // replacementFileSelectionTable
            // 
            this.replacementFileSelectionTable.AutoSize = true;
            this.replacementFileSelectionTable.ColumnCount = 2;
            this.replacementFileSelectionTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.replacementFileSelectionTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.replacementFileSelectionTable.Controls.Add(this.chooseReplacementFilePaddingPanel, 0, 0);
            this.replacementFileSelectionTable.Controls.Add(this.chooseReplacementFileButton, 0, 0);
            this.replacementFileSelectionTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.replacementFileSelectionTable.Location = new System.Drawing.Point(5, 118);
            this.replacementFileSelectionTable.Name = "replacementFileSelectionTable";
            this.replacementFileSelectionTable.RowCount = 1;
            this.replacementFileSelectionTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.replacementFileSelectionTable.Size = new System.Drawing.Size(273, 30);
            this.replacementFileSelectionTable.TabIndex = 13;
            // 
            // chooseReplacementFilePaddingPanel
            // 
            this.chooseReplacementFilePaddingPanel.AutoSize = true;
            this.chooseReplacementFilePaddingPanel.Controls.Add(this.readonlyReplacementFileTextBox);
            this.chooseReplacementFilePaddingPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.chooseReplacementFilePaddingPanel.Location = new System.Drawing.Point(84, 3);
            this.chooseReplacementFilePaddingPanel.Name = "chooseReplacementFilePaddingPanel";
            this.chooseReplacementFilePaddingPanel.Padding = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.chooseReplacementFilePaddingPanel.Size = new System.Drawing.Size(186, 24);
            this.chooseReplacementFilePaddingPanel.TabIndex = 8;
            // 
            // readonlyReplacementFileTextBox
            // 
            this.readonlyReplacementFileTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.readonlyReplacementFileTextBox.Location = new System.Drawing.Point(3, 1);
            this.readonlyReplacementFileTextBox.Name = "readonlyReplacementFileTextBox";
            this.readonlyReplacementFileTextBox.ReadOnly = true;
            this.readonlyReplacementFileTextBox.Size = new System.Drawing.Size(180, 20);
            this.readonlyReplacementFileTextBox.TabIndex = 0;
            // 
            // chooseReplacementFileButton
            // 
            this.chooseReplacementFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chooseReplacementFileButton.Location = new System.Drawing.Point(3, 3);
            this.chooseReplacementFileButton.Name = "chooseReplacementFileButton";
            this.chooseReplacementFileButton.Size = new System.Drawing.Size(75, 23);
            this.chooseReplacementFileButton.TabIndex = 0;
            this.chooseReplacementFileButton.Text = "Choose";
            this.chooseReplacementFileButton.UseVisualStyleBackColor = true;
            // 
            // selectReplacementLabel
            // 
            this.selectReplacementLabel.AutoSize = true;
            this.selectReplacementLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.selectReplacementLabel.Location = new System.Drawing.Point(5, 99);
            this.selectReplacementLabel.Margin = new System.Windows.Forms.Padding(0);
            this.selectReplacementLabel.Name = "selectReplacementLabel";
            this.selectReplacementLabel.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.selectReplacementLabel.Size = new System.Drawing.Size(142, 19);
            this.selectReplacementLabel.TabIndex = 12;
            this.selectReplacementLabel.Text = "Select replacement/insertion";
            // 
            // basicControlsTable
            // 
            this.basicControlsTable.AutoSize = true;
            this.basicControlsTable.ColumnCount = 3;
            this.basicControlsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.basicControlsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.basicControlsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.basicControlsTable.Controls.Add(this.downShiftButton, 0, 0);
            this.basicControlsTable.Controls.Add(this.deleteButton, 1, 0);
            this.basicControlsTable.Controls.Add(this.upShiftButton, 2, 0);
            this.basicControlsTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.basicControlsTable.Location = new System.Drawing.Point(5, 70);
            this.basicControlsTable.Name = "basicControlsTable";
            this.basicControlsTable.RowCount = 1;
            this.basicControlsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.basicControlsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.basicControlsTable.Size = new System.Drawing.Size(273, 29);
            this.basicControlsTable.TabIndex = 11;
            // 
            // downShiftButton
            // 
            this.downShiftButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.downShiftButton.Location = new System.Drawing.Point(3, 3);
            this.downShiftButton.Name = "downShiftButton";
            this.downShiftButton.Size = new System.Drawing.Size(85, 23);
            this.downShiftButton.TabIndex = 0;
            this.downShiftButton.Text = "Down (-1)";
            this.downShiftButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.Location = new System.Drawing.Point(94, 3);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(85, 23);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // upShiftButton
            // 
            this.upShiftButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.upShiftButton.Location = new System.Drawing.Point(185, 3);
            this.upShiftButton.Name = "upShiftButton";
            this.upShiftButton.Size = new System.Drawing.Size(85, 23);
            this.upShiftButton.TabIndex = 2;
            this.upShiftButton.Text = "Up (+1)";
            this.upShiftButton.UseVisualStyleBackColor = true;
            // 
            // basicControlsLabel
            // 
            this.basicControlsLabel.AutoSize = true;
            this.basicControlsLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.basicControlsLabel.Location = new System.Drawing.Point(5, 51);
            this.basicControlsLabel.Name = "basicControlsLabel";
            this.basicControlsLabel.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.basicControlsLabel.Size = new System.Drawing.Size(123, 19);
            this.basicControlsLabel.TabIndex = 10;
            this.basicControlsLabel.Text = "Basic controls for this file";
            // 
            // initialFileSelectionTable
            // 
            this.initialFileSelectionTable.AutoSize = true;
            this.initialFileSelectionTable.ColumnCount = 2;
            this.initialFileSelectionTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.initialFileSelectionTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.initialFileSelectionTable.Controls.Add(this.chooseInitialFilePaddingPanel, 0, 0);
            this.initialFileSelectionTable.Controls.Add(this.chooseInitialFileButton, 0, 0);
            this.initialFileSelectionTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.initialFileSelectionTable.Location = new System.Drawing.Point(5, 21);
            this.initialFileSelectionTable.Name = "initialFileSelectionTable";
            this.initialFileSelectionTable.RowCount = 1;
            this.initialFileSelectionTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.initialFileSelectionTable.Size = new System.Drawing.Size(273, 30);
            this.initialFileSelectionTable.TabIndex = 9;
            // 
            // chooseInitialFilePaddingPanel
            // 
            this.chooseInitialFilePaddingPanel.AutoSize = true;
            this.chooseInitialFilePaddingPanel.Controls.Add(this.readOnlyInitialFileTextBox);
            this.chooseInitialFilePaddingPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.chooseInitialFilePaddingPanel.Location = new System.Drawing.Point(84, 3);
            this.chooseInitialFilePaddingPanel.Name = "chooseInitialFilePaddingPanel";
            this.chooseInitialFilePaddingPanel.Padding = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.chooseInitialFilePaddingPanel.Size = new System.Drawing.Size(186, 24);
            this.chooseInitialFilePaddingPanel.TabIndex = 8;
            // 
            // readOnlyInitialFileTextBox
            // 
            this.readOnlyInitialFileTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.readOnlyInitialFileTextBox.Location = new System.Drawing.Point(3, 1);
            this.readOnlyInitialFileTextBox.Name = "readOnlyInitialFileTextBox";
            this.readOnlyInitialFileTextBox.ReadOnly = true;
            this.readOnlyInitialFileTextBox.Size = new System.Drawing.Size(180, 20);
            this.readOnlyInitialFileTextBox.TabIndex = 0;
            // 
            // chooseInitialFileButton
            // 
            this.chooseInitialFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chooseInitialFileButton.Location = new System.Drawing.Point(3, 3);
            this.chooseInitialFileButton.Name = "chooseInitialFileButton";
            this.chooseInitialFileButton.Size = new System.Drawing.Size(75, 23);
            this.chooseInitialFileButton.TabIndex = 0;
            this.chooseInitialFileButton.Text = "Choose";
            this.chooseInitialFileButton.UseVisualStyleBackColor = true;
            this.chooseInitialFileButton.Click += new System.EventHandler(this.chooseInitialFileButton_Click);
            // 
            // selectInitialLabel
            // 
            this.selectInitialLabel.AutoSize = true;
            this.selectInitialLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.selectInitialLabel.Location = new System.Drawing.Point(5, 5);
            this.selectInitialLabel.Margin = new System.Windows.Forms.Padding(0);
            this.selectInitialLabel.Name = "selectInitialLabel";
            this.selectInitialLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.selectInitialLabel.Size = new System.Drawing.Size(127, 16);
            this.selectInitialLabel.TabIndex = 0;
            this.selectInitialLabel.Text = "Select file to replace/shift";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(283, 432);
            this.Controls.Add(this.basePanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.basePanel.ResumeLayout(false);
            this.basePanel.PerformLayout();
            this.selectReplaceOrInsertTable.ResumeLayout(false);
            this.replacementFileSelectionTable.ResumeLayout(false);
            this.replacementFileSelectionTable.PerformLayout();
            this.chooseReplacementFilePaddingPanel.ResumeLayout(false);
            this.chooseReplacementFilePaddingPanel.PerformLayout();
            this.basicControlsTable.ResumeLayout(false);
            this.initialFileSelectionTable.ResumeLayout(false);
            this.initialFileSelectionTable.PerformLayout();
            this.chooseInitialFilePaddingPanel.ResumeLayout(false);
            this.chooseInitialFilePaddingPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel basePanel;

        private System.Windows.Forms.Label selectInitialLabel;
        private System.Windows.Forms.TableLayoutPanel initialFileSelectionTable;
        private System.Windows.Forms.Button chooseInitialFileButton;
        private System.Windows.Forms.Panel chooseInitialFilePaddingPanel;
        private System.Windows.Forms.TextBox readOnlyInitialFileTextBox;

        private System.Windows.Forms.Label basicControlsLabel;
        private System.Windows.Forms.TableLayoutPanel basicControlsTable;
        private System.Windows.Forms.Button downShiftButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button upShiftButton;

        private System.Windows.Forms.Label selectReplaceOrInsertActionLabel;
        private System.Windows.Forms.TableLayoutPanel selectReplaceOrInsertTable;
        private System.Windows.Forms.Button replaceButton;
        private System.Windows.Forms.Button insertButton;

        private System.Windows.Forms.Label selectReplacementLabel;
        private System.Windows.Forms.TableLayoutPanel replacementFileSelectionTable;
        private System.Windows.Forms.Button chooseReplacementFileButton;
        private System.Windows.Forms.Panel chooseReplacementFilePaddingPanel;
        private System.Windows.Forms.TextBox readonlyReplacementFileTextBox;

        private System.Windows.Forms.Label statusTextLabel;
    }
}

