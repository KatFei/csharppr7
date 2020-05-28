using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Vector;
using System.Windows.Forms;

namespace CSharpLab6_RunBut
{
    //struct Vector
    //{
    //    public int X;
    //    public int Y;
    //    public void Length()
    //    {
    //        Console.WriteLine("Vector");
    //    }

    //};
    public partial class Form1 : Form
    {
        int i = 0;
        int span = 50; //расстояние на которое кнопка будет удаляться
        // предыдущее положение мыши
        int mouseX, mouseY;
        
        public Form1()
        {
            InitializeComponent();
            mouseX = MousePosition.X;
            mouseY = MousePosition.Y;
        }

        private Double Distance(Double x1, Double x2, Double y1, Double y2) {
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

        private void butPushMe_MouseMove(object sender, MouseEventArgs e)
        {
            int cornerX = butPushMe.Location.X + butPushMe.Width;
            int cornerY = butPushMe.Location.Y + butPushMe.Height;
            // упрощенный вариант
            int centerX = butPushMe.Location.X + butPushMe.Width/2;
            int centerY = butPushMe.Location.Y + butPushMe.Height/2;
            
            //System.Windows.Vector vectorMouse = new System.Windows.Vector(MousePosition.X 
            //    - mouseX, MousePosition.Y - mouseY);
            // 
            System.Windows.Vector vectorMouse = new System.Windows.Vector(e.X - mouseX, e.Y - mouseY);

            // определяем какой угол=> надо ли учитывать H W кнопки
            // метд  MoveButton To 
            // чтобы вычислять новые координаты
            //Control.MouseMove mouse = (MouseMove)e;
            //MessageBox.Show("X = " + e.X + " Y = " + e.Y);
            //missedLabel.Visible = false;
            Double vMouseLength = Distance(e.X, mouseX, e.Y, mouseY);
            int MouseXdirection = (e.X - mouseX)>0? 1 : -1;
            int MouseYdirection = (e.Y - mouseY)>0? 1 : -1;
            Double distance = Distance(e.X, centerX, e.Y, centerY);
            if (distance < span) {
                int newX, newY;
                //так чтобы Distance был = span 

                // а не каждая из координат + 100
                newX = butPushMe.Location.X + MouseXdirection*(int)(vectorMouse.X * (span - distance) / vectorMouse.Length);
                newY = butPushMe.Location.Y + MouseYdirection*(int)(vectorMouse.Y * (span - distance) / vectorMouse.Length);
                
                //newX = (int)(MouseXproection * (span - distance) / vMouseLength);
                //newY = (int)(MouseYproection * (span - distance) / vMouseLength);
                //Point formClientSize = new Point(ClientSize);
                //if((newX>formClientSize.X) || (newX < 0))
                if ((newX + butPushMe.Width > ClientSize.Width) || (newX - butPushMe.Width < 0))
                {
                    newX = Math.Abs(ClientSize.Width- Math.Abs(newX));
                    //смещаемся по Y так чтобы расстояние было равно span
                }
                //if ((newY > ClientSize.Height) || (newY < 0))
                if ((newY + butPushMe.Height > ClientSize.Height) || (newY - butPushMe.Height < 0))
                {
                    newY = Math.Abs(ClientSize.Height - Math.Abs(newY));
                    //смещаемся по X так чтобы расстояние было равно span
                }
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
                butPushMe.Location = new Point(newX, newY);
            }
            mouseX = MousePosition.X;
            mouseY = MousePosition.Y;
        }
    }
}
