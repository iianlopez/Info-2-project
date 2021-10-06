using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlightLib;

namespace SimulatorConsole
{

    public partial class Form1 : Form
       
    {
    
        //Creates a public list of flightplans where the data is going to be saved
        public static FlightPlanList list = new FlightPlanList();
        PictureBox distance1 = new PictureBox();
        PictureBox distance2 = new PictureBox();
        Point inicio1 = new Point(0, 0);
        Point final1 = new Point(0, 0);
        Point inicio2 = new Point(0, 0);
        Point final2 = new Point(0, 0);



        public Form1()
        {
            InitializeComponent();
        }



        //Makes the background of a label transparent
        public void TransparetBackground(Control C)
        {
            C.Visible = false;

            C.Refresh();
            Application.DoEvents();

            Rectangle screenRectangle = RectangleToScreen(this.ClientRectangle);
            int titleHeight = screenRectangle.Top - this.Top;
            int Right = screenRectangle.Left - this.Left;

            Bitmap bmp = new Bitmap(this.Width, this.Height);
            this.DrawToBitmap(bmp, new Rectangle(0, 0, this.Width, this.Height));
            Bitmap bmpImage = new Bitmap(bmp);
            bmp = bmpImage.Clone(new Rectangle(C.Location.X + Right, C.Location.Y + titleHeight, C.Width, C.Height), bmpImage.PixelFormat);
            C.BackgroundImage = bmp;

            C.Visible = true;
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            aircraft1.Visible = false;
            aircraft2.Visible = false;
            startbutton.Visible = false;
            destino1.Visible = false;
            destino2.Visible = false;
            departure1.Visible = false;
            departure2.Visible = false;
            start.Visible = false;
            Restart.Visible = false;
            conflict.Visible = false;
            TransparetBackground(titulo);
        }



        private void button1_Click(object sender, EventArgs e)
        {
            start.Visible = true;
            Restart.Visible = true;
            background.Visible = false;
            startbutton.Visible = false;
            SetData.Visible = false;
            titulo.Visible = false;

            aircraft1.BackColor = Color.Transparent;
            aircraft2.BackColor = Color.Transparent;
            departure1.BackColor = Color.Transparent;
            departure2.BackColor = Color.Transparent;
            destino1.BackColor = Color.Transparent;
            destino2.BackColor = Color.Transparent;
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            
            list.GetFlightPlan(0).Mover(1);
            list.GetFlightPlan(1).Mover(1);
            aircraft1.Location = new Point((int)list.GetFlightPlan(0).GetPosition().GetX() - 15, (int)list.GetFlightPlan(0).GetPosition().GetY() - 15);
            aircraft2.Location = new Point((int)list.GetFlightPlan(1).GetPosition().GetX() - 15, (int)list.GetFlightPlan(1).GetPosition().GetY() - 15);
            distance1.Location = new Point((int)list.GetFlightPlan(0).GetPosition().GetX() - ((int)list.GetFlightPlan(0).GetDistance() / 2), ((int)list.GetFlightPlan(0).GetPosition().GetY() - (int)list.GetFlightPlan(0).GetDistance() / 2));
            distance2.Location = new Point((int)list.GetFlightPlan(1).GetPosition().GetX() - ((int)list.GetFlightPlan(1).GetDistance() / 2), ((int)list.GetFlightPlan(1).GetPosition().GetY() - (int)list.GetFlightPlan(1).GetDistance() / 2));
            if (list.GetFlightPlan(0).Conflicto(list.GetFlightPlan(1)) || list.GetFlightPlan(1).Conflicto(list.GetFlightPlan(0)))
            {
                conflict.Visible = true;
                timer1.Stop();
            }
        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Graphics graphics = e.Graphics;
            Pen myPen = new Pen(Color.Red,2);
            graphics.DrawLine(myPen, inicio1, final1);
            graphics.DrawLine(myPen, inicio2, final2);
        }




        private void SetData_Click(object sender, EventArgs e)
        {
            Form2 F2 = new Form2();
            F2.ShowDialog();
            startbutton.Visible = true;
        }



        private void start_Click(object sender, EventArgs e)
        {
            destino1.Visible = true;
            destino2.Visible = true;
            departure1.Visible = true;
            departure2.Visible = true;
            aircraft1.BackColor = new Color();

            //Starts the timer
            timer1.Interval = 10;
            timer1.Start();


            //Set the security distance of each plane
            Bitmap distance = new Bitmap("distance.png");
            distance1.Image = (Image)distance;
            panel1.Controls.Add(distance1);
            distance1.SizeMode = PictureBoxSizeMode.StretchImage;
            distance1.BackColor = Color.Transparent;
            distance1.Size = new Size((int)list.GetFlightPlan(0).GetDistance(), (int)list.GetFlightPlan(0).GetDistance());
            distance1.Location = new Point((int)list.GetFlightPlan(0).GetPosition().GetX(), (int)list.GetFlightPlan(0).GetPosition().GetY());

            Bitmap secdistance = new Bitmap("distance.png");
            distance2.Image = (Image)secdistance;
            panel1.Controls.Add(distance2);
            distance2.SizeMode = PictureBoxSizeMode.StretchImage;
            distance2.BackColor = Color.Transparent;
            distance2.Size = new Size((int)list.GetFlightPlan(0).GetDistance(), (int)list.GetFlightPlan(0).GetDistance());
            distance2.Location = new Point((int)list.GetFlightPlan(1).GetPosition().GetX(), (int)list.GetFlightPlan(1).GetPosition().GetY());

            //point where the image will be shown
            aircraft1.Visible = true;
            aircraft1.Location = new Point((int)list.GetFlightPlan(0).GetPosition().GetX(), (int)list.GetFlightPlan(0).GetPosition().GetY());

            aircraft1.SizeMode = PictureBoxSizeMode.StretchImage;

            inicio1 = new Point((int)list.GetFlightPlan(0).GetInitialPosition().GetX(), (int)list.GetFlightPlan(0).GetInitialPosition().GetY());
            departure1.Location = new Point((int)list.GetFlightPlan(0).GetInitialPosition().GetX() - 15, (int)list.GetFlightPlan(0).GetInitialPosition().GetY() - 15);
            final1 = new Point((int)list.GetFlightPlan(0).GetFinalPosition().GetX(), (int)list.GetFlightPlan(0).GetFinalPosition().GetY());
            destino1.Location = new Point((int)list.GetFlightPlan(0).GetFinalPosition().GetX() - 15, (int)list.GetFlightPlan(0).GetFinalPosition().GetY() - 15);

            //=======================================================

            aircraft2.Visible = true;
            //point where the image will be shown
            aircraft2.Location = new Point((int)list.GetFlightPlan(1).GetPosition().GetX(), (int)list.GetFlightPlan(1).GetPosition().GetY());

            aircraft2.SizeMode = PictureBoxSizeMode.StretchImage;

            inicio2 = new Point((int)list.GetFlightPlan(1).GetInitialPosition().GetX(), (int)list.GetFlightPlan(1).GetInitialPosition().GetY());
            departure2.Location = new Point((int)list.GetFlightPlan(1).GetInitialPosition().GetX() - 15, (int)list.GetFlightPlan(1).GetInitialPosition().GetY() - 15);
            final2 = new Point((int)list.GetFlightPlan(1).GetFinalPosition().GetX(), (int)list.GetFlightPlan(1).GetFinalPosition().GetY());
            destino2.Location = new Point((int)list.GetFlightPlan(1).GetFinalPosition().GetX() - 15, (int)list.GetFlightPlan(1).GetFinalPosition().GetY() - 15);

        }


        private void Restart_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            list.GetFlightPlan(0).Restart();
            list.GetFlightPlan(1).Restart();
            aircraft1.Location = new Point((int)list.GetFlightPlan(0).GetPosition().GetX() - 15, (int)list.GetFlightPlan(0).GetPosition().GetY() - 15);
            aircraft2.Location = new Point((int)list.GetFlightPlan(1).GetPosition().GetX() - 15, (int)list.GetFlightPlan(1).GetPosition().GetY() - 15);
            distance1.Location = new Point((int)list.GetFlightPlan(0).GetPosition().GetX() - ((int)list.GetFlightPlan(0).GetDistance() / 2), ((int)list.GetFlightPlan(0).GetPosition().GetY() - (int)list.GetFlightPlan(0).GetDistance() / 2));
            distance2.Location = new Point((int)list.GetFlightPlan(1).GetPosition().GetX() - ((int)list.GetFlightPlan(1).GetDistance() / 2), ((int)list.GetFlightPlan(1).GetPosition().GetY() - (int)list.GetFlightPlan(1).GetDistance() / 2));
            panel1.Invalidate();
        }


        private void closeAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(0);
        }

    }
}
