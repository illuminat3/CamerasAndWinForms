using OpenCvSharp;
using OpenCvSharp.Extensions;

namespace CamerasAndWinForms
{
    public partial class CameraTest : Form
    {
        private const string ImageFolderPath = "./images";

        private VideoCapture _videoCapture = new();
        private bool _isCameraRunning;
        private Mat _frame = new();

        public CameraTest()
        {
            InitializeComponent();

            if (Directory.Exists(ImageFolderPath) == false)
            {
                Directory.CreateDirectory(ImageFolderPath);
            }

            deviceListBox_Click(new object(), EventArgs.Empty);
            
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
                videoBox.Image = _frame.ToBitmap();
            }
        }

        private void deviceListBox_Click(object sender, EventArgs e)
        {
            deviceListBox.Items.Clear();
            deviceListBox.Items.Add("Select a camera");
            int deviceIndex = 0;
            while (true)
            {
                using (var capture = new VideoCapture(deviceIndex))
                {
                    if (!capture.IsOpened())
                        break;

                    var deviceName = $"Webcam {deviceIndex + 1}";
                    deviceListBox.Items.Add(deviceName);
                }
                deviceIndex++;
            }

            deviceListBox.SelectedIndex = 0;
        }

        // Call when selecting a new camera
        private void deviceListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = deviceListBox.SelectedIndex;
            if (index > 0)
            {
                StartCamera(index - 1);
            }
        }

        private void takePhotoButton_Click(object sender, EventArgs e)
        {
            if (_isCameraRunning)
            {
                savedImageBox.Image = _frame.ToBitmap();
                string filePath = Path.Combine(ImageFolderPath, "test.png");
                Cv2.ImWrite(filePath, _frame);
            }
        }
    }
}
