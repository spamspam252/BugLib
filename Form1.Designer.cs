namespace Bug {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.impBtn = new System.Windows.Forms.Button();
            this.expBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.solutionBrowser = new System.Windows.Forms.WebBrowser();
            this.descipTextBox = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search: ";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(92, 17);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(285, 31);
            this.searchTextBox.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 23;
            this.listBox1.Location = new System.Drawing.Point(16, 69);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(361, 809);
            this.listBox1.TabIndex = 2;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(409, 16);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(117, 32);
            this.addBtn.TabIndex = 3;
            this.addBtn.Text = "ADD";
            this.addBtn.UseVisualStyleBackColor = true;
            // 
            // impBtn
            // 
            this.impBtn.Location = new System.Drawing.Point(617, 17);
            this.impBtn.Name = "impBtn";
            this.impBtn.Size = new System.Drawing.Size(117, 32);
            this.impBtn.TabIndex = 4;
            this.impBtn.Text = "IMPORT";
            this.impBtn.UseVisualStyleBackColor = true;
            // 
            // expBtn
            // 
            this.expBtn.Location = new System.Drawing.Point(821, 16);
            this.expBtn.Name = "expBtn";
            this.expBtn.Size = new System.Drawing.Size(117, 32);
            this.expBtn.TabIndex = 5;
            this.expBtn.Text = "EXPORT";
            this.expBtn.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.solutionBrowser);
            this.panel1.Location = new System.Drawing.Point(398, 217);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(866, 661);
            this.panel1.TabIndex = 6;
            // 
            // solutionBrowser
            // 
            this.solutionBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.solutionBrowser.Location = new System.Drawing.Point(0, 0);
            this.solutionBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.solutionBrowser.Name = "solutionBrowser";
            this.solutionBrowser.Size = new System.Drawing.Size(866, 661);
            this.solutionBrowser.TabIndex = 0;
            this.solutionBrowser.Url = new System.Uri("file:///F:/OneDrive/Temp/Code%20Format%20Web/test.html", System.UriKind.Absolute);
            // 
            // descipTextBox
            // 
            this.descipTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.descipTextBox.Location = new System.Drawing.Point(409, 69);
            this.descipTextBox.Name = "descipTextBox";
            this.descipTextBox.ReadOnly = true;
            this.descipTextBox.Size = new System.Drawing.Size(855, 142);
            this.descipTextBox.TabIndex = 7;
            this.descipTextBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1276, 893);
            this.Controls.Add(this.descipTextBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.expBtn);
            this.Controls.Add(this.impBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button impBtn;
        private System.Windows.Forms.Button expBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.WebBrowser solutionBrowser;
        private System.Windows.Forms.RichTextBox descipTextBox;
    }
}

