namespace Kzz.Heic.Converter
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LabelSrc = new System.Windows.Forms.Label();
            this.LabelDest = new System.Windows.Forms.Label();
            this.src = new System.Windows.Forms.TextBox();
            this.FindSource = new System.Windows.Forms.Button();
            this.FindDest = new System.Windows.Forms.Button();
            this.ConvertButton = new System.Windows.Forms.Button();
            this.dest = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.LabelSrc, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.LabelDest, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.src, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.FindSource, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.FindDest, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.ConvertButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.dest, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(756, 177);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // LabelSrc
            // 
            this.LabelSrc.AutoSize = true;
            this.LabelSrc.ForeColor = System.Drawing.SystemColors.WindowText;
            this.LabelSrc.Location = new System.Drawing.Point(10, 10);
            this.LabelSrc.Margin = new System.Windows.Forms.Padding(10);
            this.LabelSrc.Name = "LabelSrc";
            this.LabelSrc.Size = new System.Drawing.Size(103, 15);
            this.LabelSrc.TabIndex = 0;
            this.LabelSrc.Text = "Source folder";
            // 
            // LabelDest
            // 
            this.LabelDest.AutoSize = true;
            this.LabelDest.ForeColor = System.Drawing.SystemColors.WindowText;
            this.LabelDest.Location = new System.Drawing.Point(389, 10);
            this.LabelDest.Margin = new System.Windows.Forms.Padding(10);
            this.LabelDest.Name = "LabelDest";
            this.LabelDest.Size = new System.Drawing.Size(107, 15);
            this.LabelDest.TabIndex = 1;
            this.LabelDest.Text = "Destination folder";
            // 
            // src
            // 
            this.src.ForeColor = System.Drawing.SystemColors.WindowText;
            this.src.Location = new System.Drawing.Point(10, 45);
            this.src.Margin = new System.Windows.Forms.Padding(10);
            this.src.Name = "src";
            this.src.Size = new System.Drawing.Size(314, 23);
            this.src.TabIndex = 2;
            // 
            // FindSource
            // 
            this.FindSource.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FindSource.Location = new System.Drawing.Point(344, 45);
            this.FindSource.Margin = new System.Windows.Forms.Padding(10);
            this.FindSource.Name = "FindSource";
            this.FindSource.Size = new System.Drawing.Size(25, 25);
            this.FindSource.TabIndex = 4;
            this.FindSource.Text = "...";
            this.FindSource.UseVisualStyleBackColor = true;
            this.FindSource.Click += new System.EventHandler(this.FindSource_Click);
            // 
            // FindDest
            // 
            this.FindDest.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FindDest.Location = new System.Drawing.Point(723, 45);
            this.FindDest.Margin = new System.Windows.Forms.Padding(10);
            this.FindDest.Name = "FindDest";
            this.FindDest.Size = new System.Drawing.Size(25, 25);
            this.FindDest.TabIndex = 5;
            this.FindDest.Text = "...";
            this.FindDest.UseVisualStyleBackColor = true;
            this.FindDest.Click += new System.EventHandler(this.FindDest_Click);
            // 
            // ConvertButton
            // 
            this.ConvertButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConvertButton.BackColor = System.Drawing.Color.LimeGreen;
            this.tableLayoutPanel1.SetColumnSpan(this.ConvertButton, 4);
            this.ConvertButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.ConvertButton.FlatAppearance.BorderSize = 2;
            this.ConvertButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConvertButton.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ConvertButton.ForeColor = System.Drawing.Color.Black;
            this.ConvertButton.Location = new System.Drawing.Point(20, 100);
            this.ConvertButton.Margin = new System.Windows.Forms.Padding(20);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(718, 60);
            this.ConvertButton.TabIndex = 6;
            this.ConvertButton.Text = "HEIC >> JPG";
            this.ConvertButton.UseVisualStyleBackColor = false;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // dest
            // 
            this.dest.ForeColor = System.Drawing.SystemColors.WindowText;
            this.dest.Location = new System.Drawing.Point(389, 45);
            this.dest.Margin = new System.Windows.Forms.Padding(10);
            this.dest.Name = "dest";
            this.dest.Size = new System.Drawing.Size(314, 23);
            this.dest.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 177);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Heic Converter";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label LabelSrc;
        private System.Windows.Forms.Label LabelDest;
        private System.Windows.Forms.TextBox src;
        private System.Windows.Forms.TextBox dest;
        private System.Windows.Forms.Button FindSource;
        private System.Windows.Forms.Button FindDest;
        private System.Windows.Forms.Button ConvertButton;
    }
}

