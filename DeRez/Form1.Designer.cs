namespace DeRez {
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
            if ( disposing && (components != null) ) {
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
            this.src = new System.Windows.Forms.PictureBox();
            this.dest = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.targetWidth = new System.Windows.Forms.TextBox();
            this.targetHeight = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pixelSizeUpDown = new System.Windows.Forms.NumericUpDown();
            this.darkThresholdUpDown = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.animationSpeedTrackBar = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.numFramesUpDown = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.src)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pixelSizeUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.darkThresholdUpDown)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.animationSpeedTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFramesUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // src
            // 
            this.src.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.src.Location = new System.Drawing.Point(25, 12);
            this.src.Name = "src";
            this.src.Size = new System.Drawing.Size(339, 324);
            this.src.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.src.TabIndex = 1;
            this.src.TabStop = false;
            // 
            // dest
            // 
            this.dest.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dest.Location = new System.Drawing.Point(379, 12);
            this.dest.Name = "dest";
            this.dest.Size = new System.Drawing.Size(345, 324);
            this.dest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.dest.TabIndex = 2;
            this.dest.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Select input file";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Pixel size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Dark threshold";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // targetWidth
            // 
            this.targetWidth.Location = new System.Drawing.Point(511, 32);
            this.targetWidth.Name = "targetWidth";
            this.targetWidth.Size = new System.Drawing.Size(100, 20);
            this.targetWidth.TabIndex = 8;
            this.targetWidth.TextChanged += new System.EventHandler(this.targetWidth_TextChanged);
            // 
            // targetHeight
            // 
            this.targetHeight.Location = new System.Drawing.Point(511, 58);
            this.targetHeight.Name = "targetHeight";
            this.targetHeight.Size = new System.Drawing.Size(100, 20);
            this.targetHeight.TabIndex = 9;
            this.targetHeight.TextChanged += new System.EventHandler(this.targetHeight_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(421, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Target width";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(421, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Target height";
            // 
            // pixelSizeUpDown
            // 
            this.pixelSizeUpDown.Location = new System.Drawing.Point(100, 30);
            this.pixelSizeUpDown.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.pixelSizeUpDown.Name = "pixelSizeUpDown";
            this.pixelSizeUpDown.Size = new System.Drawing.Size(69, 20);
            this.pixelSizeUpDown.TabIndex = 11;
            this.pixelSizeUpDown.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.pixelSizeUpDown.ValueChanged += new System.EventHandler(this.pixelSizeUpDown_ValueChanged);
            // 
            // darkThresholdUpDown
            // 
            this.darkThresholdUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.darkThresholdUpDown.Location = new System.Drawing.Point(100, 62);
            this.darkThresholdUpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.darkThresholdUpDown.Name = "darkThresholdUpDown";
            this.darkThresholdUpDown.Size = new System.Drawing.Size(69, 20);
            this.darkThresholdUpDown.TabIndex = 11;
            this.darkThresholdUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.darkThresholdUpDown.ValueChanged += new System.EventHandler(this.darkThresholdUpDown_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.animationSpeedTrackBar);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.darkThresholdUpDown);
            this.panel1.Controls.Add(this.numFramesUpDown);
            this.panel1.Controls.Add(this.pixelSizeUpDown);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.targetHeight);
            this.panel1.Controls.Add(this.targetWidth);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(13, 342);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(713, 112);
            this.panel1.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(225, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Preview speed";
            // 
            // animationSpeedTrackBar
            // 
            this.animationSpeedTrackBar.Location = new System.Drawing.Point(199, 56);
            this.animationSpeedTrackBar.Maximum = 20;
            this.animationSpeedTrackBar.Name = "animationSpeedTrackBar";
            this.animationSpeedTrackBar.Size = new System.Drawing.Size(152, 45);
            this.animationSpeedTrackBar.TabIndex = 13;
            this.animationSpeedTrackBar.Scroll += new System.EventHandler(this.animationSpeedTrackBar_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(196, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Num Frames";
            // 
            // numFramesUpDown
            // 
            this.numFramesUpDown.Location = new System.Drawing.Point(282, 30);
            this.numFramesUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numFramesUpDown.Name = "numFramesUpDown";
            this.numFramesUpDown.Size = new System.Drawing.Size(69, 20);
            this.numFramesUpDown.TabIndex = 11;
            this.numFramesUpDown.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numFramesUpDown.ValueChanged += new System.EventHandler(this.numFramesUpDown_ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(376, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Export Images";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(738, 466);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dest);
            this.Controls.Add(this.src);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.src)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pixelSizeUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.darkThresholdUpDown)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.animationSpeedTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFramesUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox src;
        private System.Windows.Forms.PictureBox dest;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox targetWidth;
        private System.Windows.Forms.TextBox targetHeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown pixelSizeUpDown;
        private System.Windows.Forms.NumericUpDown darkThresholdUpDown;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar animationSpeedTrackBar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numFramesUpDown;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

