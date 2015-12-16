namespace Bug {
    partial class AddDialog {
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.mediaSlider1 = new MediaSlider.MediaSlider();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(72, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(424, 31);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Title: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(526, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 31);
            this.button1.TabIndex = 4;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(119, 198);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(539, 236);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(531, 200);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(531, 200);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // mediaSlider1
            // 
            this.mediaSlider1.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.mediaSlider1.Animated = false;
            this.mediaSlider1.AnimationSize = 0.2F;
            this.mediaSlider1.AnimationSpeed = MediaSlider.MediaSlider.AnimateSpeed.Normal;
            this.mediaSlider1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.mediaSlider1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.mediaSlider1.BackgroundImage = null;
            this.mediaSlider1.ButtonAccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mediaSlider1.ButtonBorderColor = System.Drawing.Color.PapayaWhip;
            this.mediaSlider1.ButtonColor = System.Drawing.Color.DeepPink;
            this.mediaSlider1.ButtonCornerRadius = ((uint)(2u));
            this.mediaSlider1.ButtonSize = new System.Drawing.Size(17, 17);
            this.mediaSlider1.ButtonStyle = MediaSlider.MediaSlider.ButtonType.Hybrid;
            this.mediaSlider1.ContextMenuStrip = null;
            this.mediaSlider1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.mediaSlider1.LargeChange = 1;
            this.mediaSlider1.Location = new System.Drawing.Point(256, 54);
            this.mediaSlider1.Maximum = 2;
            this.mediaSlider1.Minimum = 0;
            this.mediaSlider1.Name = "mediaSlider1";
            this.mediaSlider1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.mediaSlider1.ShowButtonOnHover = false;
            this.mediaSlider1.Size = new System.Drawing.Size(352, 35);
            this.mediaSlider1.SliderFlyOut = MediaSlider.MediaSlider.FlyOutStyle.None;
            this.mediaSlider1.SmallChange = 1;
            this.mediaSlider1.SmoothScrolling = false;
            this.mediaSlider1.TabIndex = 3;
            this.mediaSlider1.TickColor = System.Drawing.Color.DarkGray;
            this.mediaSlider1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.mediaSlider1.TickType = MediaSlider.MediaSlider.TickMode.Standard;
            this.mediaSlider1.TrackBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mediaSlider1.TrackDepth = 6;
            this.mediaSlider1.TrackFillColor = System.Drawing.Color.LightCoral;
            this.mediaSlider1.TrackProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(101)))), ((int)(((byte)(188)))));
            this.mediaSlider1.TrackShadow = false;
            this.mediaSlider1.TrackShadowColor = System.Drawing.Color.DarkGray;
            this.mediaSlider1.TrackStyle = MediaSlider.MediaSlider.TrackType.Value;
            this.mediaSlider1.Value = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(30, 68);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(381, 81);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // AddDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(837, 659);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mediaSlider1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddDialog";
            this.Text = "AddDialog";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private MediaSlider.MediaSlider mediaSlider1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}