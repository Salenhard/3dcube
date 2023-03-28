namespace GraphicRotate
{
    partial class Form1
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
            this.buttonLine = new System.Windows.Forms.Button();
            this.buttonElips = new System.Windows.Forms.Button();
            this.buttonRotateRight = new System.Windows.Forms.Button();
            this.buttonRotateLeft = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonAutoRotate = new System.Windows.Forms.Button();
            this.textBoxGrad = new System.Windows.Forms.TextBox();
            this.labelGrad = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.labelY1 = new System.Windows.Forms.Label();
            this.labelX1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLine
            // 
            this.buttonLine.Location = new System.Drawing.Point(12, 12);
            this.buttonLine.Name = "buttonLine";
            this.buttonLine.Size = new System.Drawing.Size(75, 23);
            this.buttonLine.TabIndex = 0;
            this.buttonLine.Text = "Line";
            this.buttonLine.UseVisualStyleBackColor = true;
            this.buttonLine.Click += new System.EventHandler(this.buttonLine_Click);
            // 
            // buttonElips
            // 
            this.buttonElips.Location = new System.Drawing.Point(12, 41);
            this.buttonElips.Name = "buttonElips";
            this.buttonElips.Size = new System.Drawing.Size(75, 23);
            this.buttonElips.TabIndex = 1;
            this.buttonElips.Text = "Elips";
            this.buttonElips.UseVisualStyleBackColor = true;
            this.buttonElips.Click += new System.EventHandler(this.buttonElips_Click);
            // 
            // buttonRotateRight
            // 
            this.buttonRotateRight.Location = new System.Drawing.Point(12, 128);
            this.buttonRotateRight.Name = "buttonRotateRight";
            this.buttonRotateRight.Size = new System.Drawing.Size(75, 23);
            this.buttonRotateRight.TabIndex = 2;
            this.buttonRotateRight.Text = "->";
            this.buttonRotateRight.UseVisualStyleBackColor = true;
            this.buttonRotateRight.Click += new System.EventHandler(this.buttonRotateRight_Click);
            // 
            // buttonRotateLeft
            // 
            this.buttonRotateLeft.Location = new System.Drawing.Point(12, 99);
            this.buttonRotateLeft.Name = "buttonRotateLeft";
            this.buttonRotateLeft.Size = new System.Drawing.Size(75, 23);
            this.buttonRotateLeft.TabIndex = 3;
            this.buttonRotateLeft.Text = "<-";
            this.buttonRotateLeft.UseVisualStyleBackColor = true;
            this.buttonRotateLeft.Click += new System.EventHandler(this.buttonRotateLeft_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Location = new System.Drawing.Point(89, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(862, 536);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1MouseHover);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // buttonAutoRotate
            // 
            this.buttonAutoRotate.Location = new System.Drawing.Point(12, 200);
            this.buttonAutoRotate.Name = "buttonAutoRotate";
            this.buttonAutoRotate.Size = new System.Drawing.Size(75, 23);
            this.buttonAutoRotate.TabIndex = 5;
            this.buttonAutoRotate.Text = "AutoRotate";
            this.buttonAutoRotate.UseVisualStyleBackColor = true;
            this.buttonAutoRotate.Click += new System.EventHandler(this.buttonAutoRotate_Click);
            // 
            // textBoxGrad
            // 
            this.textBoxGrad.Location = new System.Drawing.Point(12, 171);
            this.textBoxGrad.Name = "textBoxGrad";
            this.textBoxGrad.Size = new System.Drawing.Size(75, 23);
            this.textBoxGrad.TabIndex = 6;
            this.textBoxGrad.Text = "5";
            // 
            // labelGrad
            // 
            this.labelGrad.AutoSize = true;
            this.labelGrad.Location = new System.Drawing.Point(12, 154);
            this.labelGrad.Name = "labelGrad";
            this.labelGrad.Size = new System.Drawing.Size(32, 15);
            this.labelGrad.TabIndex = 7;
            this.labelGrad.Text = "Grad";
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(12, 336);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(17, 15);
            this.labelX.TabIndex = 8;
            this.labelX.Text = "X:";
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Location = new System.Drawing.Point(12, 351);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(17, 15);
            this.labelY.TabIndex = 9;
            this.labelY.Text = "Y:";
            // 
            // labelY1
            // 
            this.labelY1.AutoSize = true;
            this.labelY1.Location = new System.Drawing.Point(12, 381);
            this.labelY1.Name = "labelY1";
            this.labelY1.Size = new System.Drawing.Size(17, 15);
            this.labelY1.TabIndex = 11;
            this.labelY1.Text = "Y:";
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            this.labelX1.Location = new System.Drawing.Point(12, 366);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(17, 15);
            this.labelX1.TabIndex = 10;
            this.labelX1.Text = "X:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "X";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 242);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(75, 23);
            this.textBox1.TabIndex = 12;
            this.textBox1.Text = "100";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Y";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 283);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(75, 23);
            this.textBox2.TabIndex = 14;
            this.textBox2.Text = "100";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Hand";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 560);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelY1);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.labelGrad);
            this.Controls.Add(this.textBoxGrad);
            this.Controls.Add(this.buttonAutoRotate);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonRotateLeft);
            this.Controls.Add(this.buttonRotateRight);
            this.Controls.Add(this.buttonElips);
            this.Controls.Add(this.buttonLine);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonLine;
        private Button buttonElips;
        private Button buttonRotateRight;
        private Button buttonRotateLeft;
        private PictureBox pictureBox1;
        private Button buttonAutoRotate;
        private TextBox textBoxGrad;
        private Label labelGrad;
        private Label labelX;
        private Label labelY;
        private Label labelY1;
        private Label labelX1;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Button button1;
    }
}