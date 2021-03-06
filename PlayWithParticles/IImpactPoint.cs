using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PlayWithParticles
{
    public abstract class IImpactPoint
    {
        public float X; // две координаты
        public float Y;

        // абстрактный метод с помощью которого будем изменять состояние частиц
        public abstract void ImpactParticle(Particle particle);

        public virtual void Render(Graphics g)
        {
            g.FillEllipse(
                    new SolidBrush(Color.Red),
                    X - 5,
                    Y - 5,
                    10,
                    10
                );
        }
    }
    public class GravityPoint : IImpactPoint
    {
        public int Power = 100; // сила притяжения

        public override void ImpactParticle(Particle particle)
        {
            float gX = X - particle.X;
            float gY = Y - particle.Y;

            double r = Math.Sqrt(gX * gX + gY * gY); // считаем расстояние от центра точки до центра частицы
            if (r + particle.Radius < Power / 2) // если частица оказалось внутри окружности
            {
                // то притягиваем ее
                float r2 = (float)Math.Max(100, gX * gX + gY * gY);
                particle.SpeedX += gX * Power / r2;
                particle.SpeedY += gY * Power / r2;
            }
        }

        public override void Render(Graphics g)
        {
            g.DrawEllipse(
                   new Pen(Color.Red),
                   X - Power / 2,
                   Y - Power / 2,
                   Power,
                   Power
               );
        }
    }

    public class AntiGravityPoint : IImpactPoint
    {
        public int Power = 100; // сила отторжения

        public override void ImpactParticle(Particle particle)
        {
            float gX = X - particle.X;
            float gY = Y - particle.Y;
            float r2 = (float)Math.Max(100, gX * gX + gY * gY);

            particle.SpeedX -= gX * Power / r2; 
            particle.SpeedY -= gY * Power / r2; 
        }
        public override void Render(Graphics g)
        {
            g.DrawEllipse(
                   new Pen(Color.Red),
                   X - Power / 2,
                   Y - Power / 2,
                   Power,
                   Power
               );
        }
    }

    public class ColorPoint : IImpactPoint
    {
        public int rad = 100;
        public Color color = Color.Blue;

        public override void ImpactParticle(Particle particle)
        {
            float gX = X - particle.X;
            float gY = Y - particle.Y;
            var particl = (particle as Particle.ParticleColorful);

            double r = Math.Sqrt(gX * gX + gY * gY); // считаем расстояние от центра точки до центра частицы
            if (r + particle.Radius < rad / 2)
            {
                particl.FromColor = color;
            }
        }

        public override void Render(Graphics g)
        {
            g.DrawEllipse(
                new Pen(color),
                X - rad / 2,
                Y - rad / 2,
                rad,
                rad
            );
        }
    }

    public class Portal : IImpactPoint
    {
            public int radius;
            public float x2;
            public float y2;

            public override void ImpactParticle(Particle particle)
            {
                float gX = X - particle.X;
                float gY = Y - particle.Y;

                float gX2 = x2 - particle.X;
                float gY2 = y2 - particle.Y;

                double r = Math.Sqrt(gX * gX + gY * gY); // считаем расстояние от центра точки до центра частицы
                double r2 = Math.Sqrt(gX2 * gX2 + gY2 * gY2);

            if ((r + particle.Radius > radius / 2 & r2 + particle.Radius > radius / 2))
            {
                particle.TpOut = true;
                particle.TpIn = true;
            }

            if (particle.TpIn == true)
            {
                if (r + particle.Radius < radius / 2) // если частица оказалось внутри
                {
                    particle.TpOut = false;
                    particle.X = x2;
                    particle.Y = y2;
                }
            }
            if (particle.TpOut == true)
            {
                if (r2 + particle.Radius < radius / 2)
                {
                    particle.X = X;
                    particle.Y = Y;
                    particle.TpIn = false;
                }
            }
            }
            //отрисовка портала
            public override void Render(Graphics g)
            {
                    g.DrawEllipse(
                       new Pen(Color.Blue),
                       X - radius/2,
                       Y - radius/2,
                       radius,
                       radius
                   );
                    g.DrawEllipse(
                       new Pen(Color.Orange),
                       x2 - radius/2,
                       y2 - radius/2,
                       radius,
                       radius
                   );
            }
    }
}
