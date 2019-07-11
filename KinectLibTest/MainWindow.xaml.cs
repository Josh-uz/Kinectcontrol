using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using KinectLib;
using Microsoft.Kinect;

namespace KinectLibTest
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑 the Interact logic gor MainWindow
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += new RoutedEventHandler(MainWindow_Loaded);
            this.Closing += new System.ComponentModel.CancelEventHandler(MainWindow_Closing);
        }

        void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                Kinect20.KinectClosing();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            //连接kinect的参数 parameters for connecting the kinect
           Kinect20.DisplayVideoFrame = true;//是否显示颜色视频背景 DisplayVideo
            Kinect20._receivepoints += new receivePoints(Kinect20__receivepoints);
           Kinect20._receiveVideoSource += new PassVideoSource(Kinect20__receiveVideoSource);
           Kinect20._receiveGesture += new PassGesture(Kinect20__receiveGesture);
           Kinect20.Start2Connect();//开始连接
        }

        void Kinect20__receiveGesture(Hands hand, KinectGesture gesture)
        {
            if (hand == Hands.Left)//left hand
            {
                switch (gesture)
                {
                    case KinectGesture.LeftToRight:
                        this.txtGesture.Text = "Left Hand:LeftToRight";
                        break;
                    //case KinectGesture.RightToLeft:
                    //    this.txtGesture.Text = "Left Hand:RightToLeft";
                    //    break;
                    case KinectGesture.FrontToBack:
                        this.txtGesture.Text = "Left Hand:FrontToBack";
                        break;
                    //case KinectGesture.BackToFront:
                    //    this.txtGesture.Text = "Left Hand:BackToFront";
                    //    break;
                }
            }
            else if (hand == Hands.Right)//right hand
            {
                switch (gesture)
                {
                    //case KinectGesture.LeftToRight:
                    //    this.txtGesture.Text = "Right Hand:LeftToRight";
                    //    break;
                    case KinectGesture.RightToLeft:
                        this.txtGesture.Text = "Right Hand:RightToLeft";
                        break;
                    case KinectGesture.FrontToBack:
                        this.txtGesture.Text = "Right Hand:FrontToBack";
                        break;
                    //case KinectGesture.BackToFront:
                    //    this.txtGesture.Text = "Right Hand:BackToFront";
                    //    break;
                }
            }
        }

        void Kinect20__receiveVideoSource(BitmapSource source)
        {
            ImageBrush brush = new ImageBrush();
            brush.ImageSource = source;
            this.iCanvas.Background = brush;
        }

        void Kinect20__receivepoints(Microsoft.Kinect.JointType jt, double x, double y, double z)
        {
            switch (jt)
            { 
                case JointType.HandLeft://左手 HandLeft
                    Canvas.SetLeft(this.leftHand, x);
                    Canvas.SetTop(this.leftHand, y);
                    break;
                case JointType.HandRight://右手 HandRight
                    Canvas.SetLeft(this.rightHand, x);
                    Canvas.SetTop(this.rightHand, y);
                    break;
            }
            //其他骨骼数据
            //show other joints data
            if (jt == JointType.HipLeft) { this.textBlock1.Text = "HipLeft X:" + x.ToString() + " Y:" + y.ToString() + " Z:" + z.ToString(); }
            else if (jt == JointType.SpineBase) { this.textBlock2.Text = "SpineBase X:" + x.ToString() + " Y:" + y.ToString() + " Z:" + z.ToString(); }
            else if (jt == JointType.ShoulderLeft) { this.textBlock3.Text = "ShoulderLeft X:" + x.ToString() + " Y:" + y.ToString() + " Z:" + z.ToString(); }
            else if (jt == JointType.Head) { this.textBlock4.Text = "Head X:" + x.ToString() + " Y:" + y.ToString() + " Z:" + z.ToString(); }
            else if (jt == JointType.ShoulderLeft) { this.textBlock5.Text = "ShoulderLeft X:" + x.ToString() + " Y:" + y.ToString() + " Z:" + z.ToString(); }
            else if (jt == JointType.ElbowLeft) { this.textBlock6.Text = "ElbowLeft X:" + x.ToString() + " Y:" + y.ToString() + " Z:" + z.ToString(); }
            else if (jt == JointType.WristLeft) { this.textBlock7.Text = "WristLeft X:" + x.ToString() + " Y:" + y.ToString() + " Z:" + z.ToString(); }
            else if (jt == JointType.ShoulderRight) { this.textBlock8.Text = "ShoulderRight X:" + x.ToString() + " Y:" + y.ToString() + " Z:" + z.ToString(); }
            else if (jt == JointType.ElbowRight) { this.textBlock9.Text = "ElbowRight X:" + x.ToString() + " Y:" + y.ToString() + " Z:" + z.ToString(); }
            else if (jt == JointType.WristRight) { this.textBlock10.Text = "WristRight X:" + x.ToString() + " Y:" + y.ToString() + " Z:" + z.ToString(); }
            else if (jt == JointType.HipLeft) { this.textBlock11.Text = "HipLeft X:" + x.ToString() + " Y:" + y.ToString() + " Z:" + z.ToString(); }
            else if (jt == JointType.KneeLeft) { this.textBlock12.Text = "KneeLeft X:" + x.ToString() + " Y:" + y.ToString() + " Z:" + z.ToString(); }
            else if (jt == JointType.AnkleLeft) { this.textBlock13.Text = "AnkleLeft X:" + x.ToString() + " Y:" + y.ToString() + " Z:" + z.ToString(); }
            else if (jt == JointType.FootLeft) { this.textBlock14.Text = "FootLeft X:" + x.ToString() + " Y:" + y.ToString() + " Z:" + z.ToString(); }
            else if (jt == JointType.HipRight) { this.textBlock15.Text = "HipRight X:" + x.ToString() + " Y:" + y.ToString() + " Z:" + z.ToString(); }
            else if(jt == JointType.KneeRight) { this.textBlock16.Text = "KneeRight X:" + x.ToString() + " Y:" + y.ToString() + " Z:" + z.ToString(); }
        }

        private void checkBox1_Click(object sender, RoutedEventArgs e)
        {
            if (this.checkBox1.IsChecked == true)
            {
                Kinect20.DisplayVideoFrame = true;
            }
            else
            {
                Kinect20.DisplayVideoFrame = false;
                this.iCanvas.Background = null;
            }
        }
    }
}
