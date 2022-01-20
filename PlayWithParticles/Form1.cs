using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PlayWithParticles
{
    public partial class Form1 : Form
    {
        List<Emitter> emitters = new List<Emitter>();
        Emitter emitter;

        ColorPoint point1;

        Portal tp;

        public Form1()
        {
            InitializeComponent();
            picDisplay.Image = new Bitmap(picDisplay.Width, picDisplay.Height);

            picDisplay.MouseWheel += picDisplay_MouseWheel;

            this.emitter = new Emitter // создаю эмиттер и привязываю его к полю emitter
            {
                Direction = 0,
                Spreading = 0,
                SpeedMin = 1,
                SpeedMax = 10,
                ColorFrom = Color.Gold,
                ColorTo = Color.FromArgb(0, Color.Red),
                ParticlesPerTick = 1,
                X = picDisplay.Width / 2,
                Y = picDisplay.Height / 2,
            };

            emitters.Add(this.emitter);

            point1 = new ColorPoint
            {
                X = picDisplay.Width / 2 + 100,
                Y = picDisplay.Height / 2,
            };

            tp = new Portal
            {
                X = picDisplay.Width / 2,
                Y = picDisplay.Height / 2 + 200,
                radius = 100,
                x2 = picDisplay.Width / 2,
                y2 = picDisplay.Height / 2 - 200,
            };

            // привязываем поля к эмиттеру
            emitter.impactPoints.Add(point1);
            emitter.impactPoints.Add(tp);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            emitter.UpdateState();

            using (var g = Graphics.FromImage(picDisplay.Image))
            {
                g.Clear(Color.Black); // А ЕЩЕ ЧЕРНЫЙ ФОН СДЕЛАЮ
                emitter.Render(g);
            }

            picDisplay.Invalidate();

        }

        private void picDisplay_MouseMove(object sender, MouseEventArgs e)
        {
            foreach (var emitter in emitters)
            {
                emitter.MousePositionX = e.X;
                emitter.MousePositionY = e.Y;
            }

            // а тут передаем положение мыши, в положение гравитона
            point1.X = e.X;
            point1.Y = e.Y;
        }

        private void tbDirection_Scroll(object sender, EventArgs e)
        {
            emitter.Direction = tbDirection.Value;
            labelDirection.Text = $"{tbDirection.Value}°";
        }

        private void tbSpread_Scroll(object sender, EventArgs e)
        {
            emitter.Spreading = tbSpread.Value;
            labelSpread.Text = $"{tbSpread.Value}°";
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            emitter.SpeedMin = tbSpeed.Value - 10;
            emitter.SpeedMax = tbSpeed.Value;
            txtSpeed.Text = $"{tbSpeed.Value}";
        }

        private void tbPartPerTick_Scroll(object sender, EventArgs e)
        {
            emitter.ParticlesPerTick = tbPartPerTick.Value;
            txtPerTick.Text = $"{tbPartPerTick.Value}";
        }

        private void picDisplay_MouseWheel(object sender, MouseEventArgs e)
        { 
            txtRadius.Text = $"{point1.rad}"; ;
            if (e.Delta > 0)
            {
                point1.rad -= 3;
                // "Вверх"
                if (point1.rad < 0)
                {
                    point1.rad = 0;
                }
            }
            else
            {
                point1.rad += 3;
                // "Вниз"
                if (point1.rad > 300)
                {
                    point1.rad = 300;
                }
            }
        }

        private void picDisplay_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                tp.X = e.X;
                tp.Y = e.Y;
            }
            else
            {
                tp.x2 = e.X;
                tp.y2 = e.Y;
            }
        }

        private void trackBar1_Scroll_1(object sender, EventArgs e)
        {
            tp.radius = tbRadTp.Value;
            txtSizeTP.Text = $"{tbRadTp.Value}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (colorMenu.ShowDialog() == DialogResult.OK)
            {
                point1.color = colorMenu.Color;
                btnColor.BackColor = colorMenu.Color;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(emitter.GravitiClr == 0)
            {
                emitter.GravitiClr = 1;
            }
            else
            {
                emitter.GravitiClr = 0;
            }
        }
    }
}
