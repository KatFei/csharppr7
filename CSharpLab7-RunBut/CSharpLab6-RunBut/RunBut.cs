using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
//using System.Runtime.InteropServices; //для Optional
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Vector;
using System.Windows.Forms;
//using System.Windows;

namespace CSharpLab6_RunBut
{
    struct Vector
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Vector(int x, int y)
        {
            X = x;
            Y = y;
        }
        public double Length
        {
            get { return RunBut.Distance(X, Y); }
        }

    };

    public partial class RunBut : Form
    {
        Size oldSize;
        //int clientWidth = 0;
        //int clientHeight = 0;
        int span = 50; //расстояние на которое кнопка будет удаляться
        // предыдущее положение мыши
        int mouseX, mouseY;
        // предыдущее направление движения кнопки
        int butDirX, butDirY;

        public RunBut()
        {
            InitializeComponent();
            oldSize.Width = this.Width;
            oldSize.Height = this.Height;
            mouseX = this.PointToClient(MousePosition).X;
            mouseY = this.PointToClient(MousePosition).Y;
            butDirX = 1;// butPushMe.Location.X;
            butDirY = 1;//butPushMe.Location.Y;
        }

        public static Double Distance(Double x1, Double x2 = 0, Double y1 = 0, Double y2 = 0) {
            return Math.Sqrt((Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)));
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //successLabel.Visible = true;
            butPushMe.Enabled = false;
        }

        //private void Form1_Click(object sender, EventArgs e)
        //{
        //    if (successLabel.Visible == false) missedLabel.Visible = true;
        //}

        private void Form1_Load(object sender, EventArgs e)
        {
            //центрирование кнопки
            //butPushMe.Location = new Point(this.Width/2, this.Height/2);
            //successLabel.Visible = missedLabel.Visible = false;
            //timer1.Enabled = true;
            //progressBar1.Value = progressBar1.Minimum;
        }

        //private void timer1_Tick(object sender, EventArgs e)
        //{
        //    timer1.Interval = 1000;
        //    if (progressBar1.Value == progressBar1.Maximum)
        //    {
        //        gameOverLabel.Visible = true;
        //        this.Enabled = false;
        //        timer1.Enabled = false;
        //        Form1_MouseClick(sender, e);
        //    }
        //    else
        //    {
        //        gameOverLabel.Visible = false;
        //        progressBar1.PerformStep();
        //    }
        //}

        //private void Form1_MouseClick(object sender, EventArgs e)
        //{
        //    i++;
        //    gameOverLabel.Text = "Game over, you failed!" + Environment.NewLine + "Clicks:" + i.ToString();
        //}
        private void InitializeStatusBar(int mX, int mY, double dist)
        {
            lblMXval.Text = mX.ToString();
            lblMYval.Text = mY.ToString();

            lblDistval.Text = Math.Round(dist).ToString();
        }
        private void InitializeStatusBar(int bX, int bY, int nX, int nY)
        {
            lblBXval.Text = bX.ToString();
            lblBYval.Text = bY.ToString();
            lblNewXval.Text = nX.ToString();
            lblNewYval.Text = nY.ToString();

            //lblDistval.Text = dist.ToString();
        }
        private void InitializeStatusBar(int mpX, int mpY)
        {
            lblMousePosition.Text = mpX.ToString()+":"+mpY.ToString();
        }

        //private void Form1_Resize(object sender, System.EventArgs e)
        //{
        //    Control control = (Control)sender;

        //    // Ensure the Form remains square (Height = Width).
        //    if (control.Size.Height != control.Size.Width)
        //    {
        //        control.Size = new Size(control.Size.Width, control.Size.Width);
        //    }
        //}
        private void RunBut_ResizeEnd(object sender, EventArgs e)
        {
            butPushMe.Location = new Point((int)butPushMe.Location.X * this.Width / oldSize.Width
            , (int)butPushMe.Location.Y * this.Height / oldSize.Height);//((Form)sender).
            oldSize = this.Size;
        }

        private void butPushMe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Поздравляем! Вы смогли нажать на кнопку!", " ", MessageBoxButtons.OK);
        }

        private void RunBut_Resize(object sender, EventArgs e)
        {
            //Control control = (Control)sender;

            //butPushMe.Location = new Point((int)butPushMe.Location.X * control.Size.Width / oldSize.Width
            //, (int)butPushMe.Location.Y * control.Size.Height / oldSize.Height);//((Form)sender).
            //oldSize = this.Size;
        }

        private void butPushMe_MouseMove(object sender, MouseEventArgs e)
        {
            InitializeStatusBar(mouseX, mouseY);
            int cornerX = butPushMe.Location.X + butPushMe.Width;
            int cornerY = butPushMe.Location.Y + butPushMe.Height;
            // упрощенный вариант
            int centerX = butPushMe.Location.X + butPushMe.Width/2;
            int centerY = butPushMe.Location.Y + butPushMe.Height/2;
            Point realE = e.Location;

            //System.Windows.Vector vectorMouse = new System.Windows.Vector(MousePosition.X 
            //    - mouseX, MousePosition.Y - mouseY);

            //c вектором из WPF
            //System.Windows.Vector vectorMouse = new System.Windows.Vector(realE.X - mouseX, realE.Y - mouseY);
            Vector vectorMouse = new Vector(realE.X - mouseX, realE.Y - mouseY);
            // определяем какой угол=> надо ли учитывать H W кнопки
            // метд  MoveButton To 
            // чтобы вычислять новые координаты
            //Control.MouseMove mouse = (MouseMove)e;
            //MessageBox.Show("X = " + e.X + " Y = " + e.Y);
            //missedLabel.Visible = false;
            Double vMouseLength = Distance(realE.X, mouseX, realE.Y, mouseY);
            int MouseXdirection = (realE.X - mouseX) == 0 ? 0: (realE.X - mouseX)>0? 1 : -1;
            int MouseYdirection = (realE.Y - mouseY) == 0 ? 0 : (realE.Y - mouseY)> 0? 1 : -1;
            Double distance = Distance(realE.X, centerX, realE.Y, centerY);

            //
            InitializeStatusBar(realE.X, realE.Y, distance);
            if (distance < span) {

                int newX, newY;
                //так чтобы Distance был = span 
                newX = centerX + MouseXdirection * (int)Math.Round(vectorMouse.X * (span - distance + 10) / vectorMouse.Length);
                // а не каждая из координат + 100
                newX = MouseXdirection;
                newY = MouseYdirection;
                InitializeStatusBar(centerX, centerY, newX, newY);
                //newX = centerX + MouseXdirection * (int)Math.Round(vectorMouse.X * (span - distance + 10) / vectorMouse.Length);
                //newY = centerY + MouseYdirection * (int)Math.Round(vectorMouse.Y * (span - distance + 10) / vectorMouse.Length);
                
                newX = MouseXdirection * (span - (int)Math.Round(distance) + 10);
                newY = MouseYdirection * (span - (int)Math.Round(distance) + 10);
                //newX = (int)(MouseXproection * (span - distance) / vMouseLength);
                //newY = (int)(MouseYproection * (span - distance) / vMouseLength);
                //Point formClientSize = new Point(ClientSize);
                //if((newX>formClientSize.X) || (newX < 0))
                //if ((newX + butPushMe.Width / 2 > ClientSize.Width) || (newX - butPushMe.Width / 2 < 0))
                bool border = true;
                int i= 0;
                do
                {
                    if ((newX + butPushMe.Location.X + butPushMe.Width > ClientSize.Width) ||
                        (butPushMe.Location.X + newX < 0))
                    {
                        border = true;
                        newY = newX * butDirY;//newX = Math.Abs(ClientSize.Width- Math.Abs(newX));
                        newX = 0;//смещаемся по Y так чтобы расстояние было равно span
                        i++;
                    }
                    else border = false;
                    //if ((newY > ClientSize.Height) || (newY < 0))
                    //if ((newY + butPushMe.Height / 2 > ClientSize.Height) || (newY - butPushMe.Height / 2 < 0))
                    if ((newY + butPushMe.Location.Y + butPushMe.Height > ClientSize.Height
                        - statusStrip1.Height) ||
                        (newY + butPushMe.Location.Y < 0))
                    {
                        border = true;
                        newX = newY * butDirX;//newY = Math.Abs(ClientSize.Height - Math.Abs(newY));
                        newY = 0;//смещаемся по X так чтобы расстояние было равно span
                        i++;
                    }
                    else border = false;
                    if (i >= 4)
                    {
                        int spanMouseX = ClientSize.Width - e.X > e.X ? e.X : ClientSize.Height - e.X;
                        int spanMouseY = ClientSize.Height - statusStrip1.Height - e.Y > e.Y ? e.Y : ClientSize.Height - statusStrip1.Height - e.Y;
                        if (spanMouseX > spanMouseY)
                        {
                            newY = -butDirY * (span - (int)Math.Round(distance) + 10);
                        }
                        else
                            newX = -butDirX * (span - (int)Math.Round(distance) + 10);

                    }
                } while (border);
                //Random rnd = new Random();
                //do
                //{
                //    x = rnd.Next(0, formClientSize.X - butPushMe.Width);
                //}
                //while (x >= butPushMe.Left - butPushMe.Width && x <= butPushMe.Right) ;
                //do
                //{
                //    y = rnd.Next(0, formClientSize.Y - butPushMe.Height);
                //}
                //while (y >= butPushMe.Top - butPushMe.Height && y <= butPushMe.Bottom) ;
                newX += centerX;
                newY += centerY;
                butPushMe.Location = new Point(newX - butPushMe.Width / 2, newY - butPushMe.Height / 2);
                // куда двигалась кнопка
                butDirX = MouseXdirection == 0 ? butDirX : MouseXdirection;
                butDirY = MouseYdirection == 0 ? butDirY : MouseYdirection;
            }
            mouseX = this.PointToClient(MousePosition).X;
            mouseY = this.PointToClient(MousePosition).Y;
        }
    }
}
