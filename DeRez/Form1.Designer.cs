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
            this.button1 = new System.Windows.Forms.Button();
            this.src = new System.Windows.Forms.PictureBox();
            this.dest = new System.Windows.Forms.PictureBox();
            this.pixelSize = new System.Windows.Forms.TextBox();
            this.darkThreshold = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.targetWidth = new System.Windows.Forms.TextBox();
            this.targetHeight = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.src)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dest)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 467);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Go";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // pixelSize
            // 
            this.pixelSize.Location = new System.Drawing.Point(157, 390);
            this.pixelSize.Name = "pixelSize";
            this.pixelSize.Size = new System.Drawing.Size(100, 20);
            this.pixelSize.TabIndex = 3;
            this.pixelSize.TextChanged += new System.EventHandler(this.pixelSize_TextChanged);
            // 
            // darkThreshold
            // 
            this.darkThreshold.Location = new System.Drawing.Point(157, 416);
            this.darkThreshold.Name = "darkThreshold";
            this.darkThreshold.Size = new System.Drawing.Size(100, 20);
            this.darkThreshold.TabIndex = 4;
            this.darkThreshold.TextChanged += new System.EventHandler(this.darkThreshold_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(25, 342);
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
            this.label1.Location = new System.Drawing.Point(71, 390);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Pixel size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 423);
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
            this.targetWidth.Location = new System.Drawing.Point(568, 389);
            this.targetWidth.Name = "targetWidth";
            this.targetWidth.Size = new System.Drawing.Size(100, 20);
            this.targetWidth.TabIndex = 8;
            this.targetWidth.TextChanged += new System.EventHandler(this.targetWidth_TextChanged);
            // 
            // targetHeight
            // 
            this.targetHeight.Location = new System.Drawing.Point(568, 415);
            this.targetHeight.Name = "targetHeight";
            this.targetHeight.Size = new System.Drawing.Size(100, 20);
            this.targetHeight.TabIndex = 9;
            this.targetHeight.TextChanged += new System.EventHandler(this.targetHeight_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(478, 389);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Target width";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(478, 423);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Target height";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 579);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.targetHeight);
            this.Controls.Add(this.targetWidth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.darkThreshold);
            this.Controls.Add(this.pixelSize);
            this.Controls.Add(this.dest);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.src);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.src)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox src;
        private System.Windows.Forms.PictureBox dest;
        private System.Windows.Forms.TextBox pixelSize;
        private System.Windows.Forms.TextBox darkThreshold;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox targetWidth;
        private System.Windows.Forms.TextBox targetHeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

