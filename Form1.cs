using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private TextBox userInputTextBox;
        private Label timeLabel;
        public Form1()
        {
            InitializeComponent();
            //    this.timeLabel = new Label();
            //    this.timeLabel.Location = new Point(this.Width / 2 - 33, this.Height / 2 - 12);
            //    this.timeLabel.Size = new System.Drawing.Size(67, 24);
            //    this.Controls.Add(timeLabel);
            //    Timer timer = new Timer();
            //    timer.Tick += (timerEventSender, timerEventArgs) => {
            //        DateTime dateTimeNow = DateTime.Now;
            //        int hours = dateTimeNow.Hour;
            //        int minutes = dateTimeNow.Minute;
            //        int seconds = dateTimeNow.Second;
            //        this.timeLabel.Text = $"{hours}:{minutes}:{seconds}";
            //    };
            //    timer.Interval = 1000;
            //    timer.Start();
            //}

            //private void helpButton_Click(object sender, EventArgs e)
            //{

            //    // MessageBox.Show("Form1 App Help. ...");
            //    // Console.WriteLine("Form1 App Console Help. ...");
            //    // Console.WriteLine(((Button)sender).Name);
            //    ((Button)sender).Enabled = false;
            //    Timer timer = new Timer();
            //    timer.Tick += (timerEventSender, timerEventArgs) => {
            //        Console.WriteLine("((Button)sender).Enabled = true;");
            //        ((Button)sender).Enabled = true;
            //        timer.Dispose();
            //    };
            //    timer.Interval = 5000;
            //    timer.Start();
            //    this.resultLabel.Text = "Result: some text ...";
            //    if (this.userInputTextBox == null)
            //    {
            //        this.userInputTextBox = new TextBox();
            //        this.userInputTextBox.Size = new Size(150, 25);
            //        this.userInputTextBox.Top = 42;
            //        this.userInputTextBox.Left = 13;
            //        this.userInputTextBox.TextChanged += (textChangedSender, textChangedEventArgs) => {
            //            this.resultLabel.Text = this.userInputTextBox.Text;
            //        };
            //        this.Controls.Add(this.userInputTextBox);
            //    }
            //}

            //protected override void OnSizeChanged(EventArgs e)
            //{
            //    base.OnSizeChanged(e);
            //    if (this.timeLabel != null)
            //    {
            //        this.timeLabel.Location = new Point(this.Width / 2 - 33, this.Height / 2 - 12);
            //    }
            //}



        }

        private void rectangle_MouseClick(object sender, MouseEventArgs e)
        {
            if (Control.ModifierKeys == Keys.Control)
            {
                Application.Exit();
            }
            if (e.Button == MouseButtons.Right)
            {
                this.Text = "Size - X: " + this.Size.Width + " Y: " + this.Size.Height;
                Thread.Sleep(1000);
            }
            else
            {
                MessageBox.Show("В пределах прямоугольника");
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (Control.ModifierKeys == Keys.Control)
            {
                Application.Exit();
            }
            if (e.Button == MouseButtons.Right)
            {
                this.Text = "Size - X: " + this.Size.Width + " Y: " + this.Size.Height;
                Thread.Sleep(1000);
            }
            else
            {
                MessageBox.Show("За пределами");
            }
        }
       

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = "Coords: X: " + e.X + " Y: " + e.Y;
        }

        private void rectangle_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = "Coords: X: " + e.X + " Y: " + e.Y;
        }
    }
}
