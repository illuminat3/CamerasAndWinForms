using OpenCvSharp;
using OpenCvSharp.Extensions;

namespace CamerasAndWinForms
{
    public partial class Form1 : Form
    {
        private VideoCapture _videoCapture = new();
        private bool _isCameraRunning;
        private Mat _frame = new();

        public Form1()
        {
            InitializeComponent();
            ComboBox1_Click(new object(), EventArgs.Empty);
        }

        // Call when a camera is updated, idk what happens when 2 cameras are available
        private void StartCamera(int cameraIndex)
        {

            if (!_isCameraRunning)
            {
                _videoCapture.Open(cameraIndex);
                if (_videoCapture.IsOpened())
                {
                    _isCameraRunning = true;
                    Application.Idle += ProcessFrame;
                }
                else
                {
                    MessageBox.Show("Failed to open camera.");
                }
            }
            else
            {
                Application.Idle -= ProcessFrame;
                _videoCapture.Release();
                _isCameraRunning = false;
            }
        }

        // Fake display a video (only way to do it live in winforms)
        private void ProcessFrame(object? sender, EventArgs e)
        {
            if (_videoCapture.Read(_frame))
            {
                pictureBox1.Image = _frame.ToBitmap();
            }
        }

        private void ComboBox1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Select a camera");
            int deviceIndex = 0;
            while (true)
            {
                using (var capture = new VideoCapture(deviceIndex))
                {
                    if (!capture.IsOpened())
                        break;

                    var deviceName = $"Webcam {deviceIndex + 1}";
                    comboBox1.Items.Add(deviceName);
                }
                deviceIndex++;
            }

            comboBox1.SelectedIndex = 0;
        }

        // Call when selecting a new camera
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox1.SelectedIndex;
            if (index > 0)
            {
                StartCamera(index - 1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_isCameraRunning)
                pictureBox2.Image = _frame.ToBitmap();
        }
    }
}
