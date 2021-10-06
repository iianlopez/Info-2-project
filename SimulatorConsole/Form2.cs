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

    public partial class Form2 : Form
    {


        public Form2()
        {
            InitializeComponent();
        }



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



        private void Form2_Load(object sender, EventArgs e)
        {
            //makes invisible the error texts when the form is loaded

            error.Visible = false;
            error2.Visible = false;
            loaded1.Visible = false;
            loaded2.Visible = false;

            TransparetBackground(titulo1);
            TransparetBackground(titulo2);
            TransparetBackground(label2);
            TransparetBackground(label3);
            TransparetBackground(label4);
            TransparetBackground(label5);
            TransparetBackground(label6);
            TransparetBackground(label7);
            TransparetBackground(label8);
            TransparetBackground(label9);
            TransparetBackground(label10);
            TransparetBackground(label11);
            TransparetBackground(label12);
            TransparetBackground(label13);
            TransparetBackground(label14);
            TransparetBackground(label15);
            TransparetBackground(label16);
            TransparetBackground(label17);
            TransparetBackground(label19);
            TransparetBackground(label20);
        }
        


        private void button1_Click(object sender, EventArgs e)
        {
            //Tries to create the Flightplan with the information of the textboxes
            //If the data introduced has a format error or is not introduced yet, it shows the message error
            try
            {
                String identificador = id1.Text;
                Double ix = Convert.ToDouble(xi1.Text);
                Double iy = Convert.ToDouble(yi1.Text);
                Double fx = Convert.ToDouble(xf1.Text);
                Double fy = Convert.ToDouble(yf1.Text);
                Double velocidad = Convert.ToDouble(speed1.Text);
                Double distancia = Convert.ToDouble(distance1.Text);
                FlightPlan Airplane1 = new FlightPlan(identificador, ix, iy, fx, fy, velocidad, distancia);
                Form1.list.AddFlightPlan(Airplane1);
                loaded1.Visible = true;
            }
            catch
            {
                error.Visible = true;
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            //Tries to create the Flightplan with the information of the textboxes
            //If the data introduced has a format error or is not introduced yet, it shows the message error
            try
            {
                String identificador = id2.Text;
                Double ix = Convert.ToDouble(xi2.Text);
                Double iy = Convert.ToDouble(yi2.Text);
                Double fx = Convert.ToDouble(xf2.Text);
                Double fy = Convert.ToDouble(yf2.Text);
                Double velocidad = Convert.ToDouble(speed2.Text);
                Double distancia = Convert.ToDouble(distance2.Text);
                FlightPlan Airplane2 = new FlightPlan(identificador, ix, iy, fx, fy, velocidad, distancia);
                Form1.list.AddFlightPlan(Airplane2);

                loaded2.Visible = true;
            }
            catch
            {
                error2.Visible = true;
            }
        }



        private void closeAppToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //option to close the entire app through the menu
            this.Close();
            Environment.Exit(0);
        }     
        

        private void start_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void defecto_Click(object sender, EventArgs e)
        {
            id1.Text = ("Aircraft1");
            xi1.Text = ("100");
            yi1.Text = ("100");
            xf1.Text = ("1000");
            yf1.Text = ("500");
            speed1.Text = ("40");
            distance1.Text = ("100");

            id2.Text = ("Aircraft2");
            xi2.Text = ("100");
            yi2.Text = ("500");
            xf2.Text = ("1000");
            yf2.Text = ("100");
            speed2.Text = ("80");
            distance2.Text = ("100");
        }

    }

}
    

