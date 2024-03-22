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
            deviceListBox = new ComboBox();
            videoBox = new PictureBox();
            takePhotoButton = new Button();
            savedImageBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)videoBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)savedImageBox).BeginInit();
            SuspendLayout();
            // 
            // deviceListBox
            // 
            deviceListBox.FormattingEnabled = true;
            deviceListBox.Location = new Point(329, 284);
            deviceListBox.Name = "deviceListBox";
            deviceListBox.Size = new Size(121, 23);
            deviceListBox.TabIndex = 0;
            deviceListBox.DropDown += deviceListBox_Click;
            deviceListBox.SelectedIndexChanged += deviceListBox_SelectedIndexChanged;
            // 
            // videoBox
            // 
            videoBox.Location = new Point(283, 68);
            videoBox.Name = "videoBox";
            videoBox.Size = new Size(205, 150);
            videoBox.SizeMode = PictureBoxSizeMode.Zoom;
            videoBox.TabIndex = 1;
            videoBox.TabStop = false;
            // 
            // takePhotoButton
            // 
            takePhotoButton.Location = new Point(329, 255);
            takePhotoButton.Name = "takePhotoButton";
            takePhotoButton.Size = new Size(121, 23);
            takePhotoButton.TabIndex = 2;
            takePhotoButton.Text = "Take Photo";
            takePhotoButton.UseVisualStyleBackColor = true;
            takePhotoButton.Click += takePhotoButton_Click;
            // 
            // savedImageBox
            // 
            savedImageBox.Location = new Point(595, 284);
            savedImageBox.Name = "savedImageBox";
            savedImageBox.Size = new Size(183, 157);
            savedImageBox.TabIndex = 3;
            savedImageBox.TabStop = false;
            savedImageBox.SizeMode = PictureBoxSizeMode.Zoom;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(savedImageBox);
            Controls.Add(takePhotoButton);
            Controls.Add(videoBox);
            Controls.Add(deviceListBox);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)videoBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)savedImageBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox deviceListBox;
        private PictureBox videoBox;
        private Button takePhotoButton;
        private PictureBox savedImageBox;
    }
}
