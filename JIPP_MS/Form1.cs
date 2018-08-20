using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace JIPP_MS
{
    public partial class Form1 : Form
    {
        Graphics graphics;
        System.Timers.Timer timer;
        Plane plane;
        int rotationAngle = 20;
        int forwardDistance = 5;
        int planeStartPosX = 100;
        int planeStartPosY = 100;
        int planeSize = 80;
        public Form1()
        {
            InitializeComponent();
            //timer odswieza sie trigeruje co 30 ms
            timer = new System.Timers.Timer(30);
            //funkcja PlaneAnimation bedzie sie wywolywac co te 30 ms
            timer.Elapsed += PlaneAnimation;
            timer.AutoReset = true;
            timer.Enabled = true;
            //pole do rysowania na pictureBoxSky
            graphics = pictureBoxSky.CreateGraphics();
            plane = new Plane(pictureBoxSky.ClientSize.Width - planeStartPosX, pictureBoxSky.ClientSize.Height - planeStartPosY - planeSize);
            plane.Dx = planeStartPosX;
            plane.Dy = planeStartPosY;
            //dodaje zachowania do eventow
            plane.PlaneCrashed += Plane_PlaneCrashed;
            plane.PlaneSurvived += Plane_PlaneSurvived;
        }

        private void Plane_PlaneSurvived()
        {
            MessageBox.Show("Brawo!");
        }

        private void Plane_PlaneCrashed()
        {
            MessageBox.Show("Samolot sie rozbil :(");
        }

        void PlaneAnimation(object sender, EventArgs e)
        {
            //wymazuje  poprzedni rysunek
            pictureBoxSky.Image = null;
            //tutaj zmien sciezke
            Image image = Image.FromFile(@"c:\users\bluecompany\source\repos\JIPP_MS\JIPP_MS\plane.jpg");
            //zmieniam jego rozmiary na mniejsze
            var bmp = new Bitmap(image, new Size(planeSize, planeSize));
            //domyslnie poruszam sie caly czas do przodu
            MovePlane(forwardDistance, 0);
            //rysuje
            graphics.DrawImage(bmp, plane.Dx, plane.Dy);
        }

        void MovePlane(int x, int y)
        {
            graphics.TranslateTransform(x, y);
            plane.Dx += x;
            plane.Dy += y;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //dalem try catcha bo walilo wyjatkami, chyba dlatego, bo kazdy triger timera chce dostepu do obiektu graphic i  moglo byc tak, ze byl zajety przez poprzedni triger, a juz nowy chcial z niego skorzystac
            if (e.KeyCode == Keys.W)
            {
                try
                {
                    //mozesz sobie odkomentowac rotatetransform by zobaczyc jak to by moglo wygladac
                    //ale obliczenia staja sie bardziej skomplikowane i to by bylo zbyt pracochlonne sterowanie obrazkiem
                    //moglbym tez korzystac z samego rotatetransform i nie korzystac z translate
                    //jednakze, korzystanie z obu tych rzeczy tworzy zbyt skomplikowany model, zdecydowalem sie na ten najprostszy :)
                    //graphics.RotateTransform(-rotationAngle);
                    //graphics.TranslateTransform(forwardDistance, rotationAngle);
                    MovePlane(forwardDistance, -rotationAngle);
                }
                catch { }
                
            }
            else if (e.KeyCode == Keys.S)
            {
                try
                {
                    //graphics.RotateTransform(rotationAngle);
                    //graphics.TranslateTransform(forwardDistance, rotationAngle);
                    MovePlane(forwardDistance, rotationAngle);

                }
                catch { }
                
            }
        }
    }
}
