using OpenCvSharp;
using Point = System.Drawing.Point;
using Size = System.Drawing.Size;

namespace CamerasAndWinForms
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
            comboBox1 = new ComboBox();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(329, 284);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 0;
            comboBox1.DropDown += ComboBox1_Click;
            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(283, 68);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(205, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(329, 255);
            button1.Name = "button1";
            button1.Size = new Size(121, 23);
            button1.TabIndex = 2;
            button1.Text = "Take Photo";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(595, 284);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(183, 157);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(comboBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBox1;
        private PictureBox pictureBox1;
        private Button button1;
        private PictureBox pictureBox2;
    }
}
