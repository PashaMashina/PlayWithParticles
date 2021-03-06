using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PlayWithParticles
{
    internal class Emitter
    {
        public float GravitationX = 0;
        public float GravitationY = 0; 
        public float GravitiClr = 0;

        List<Particle> particles = new List<Particle>();

        public int MousePositionX;
        public int MousePositionY;

        public List<IImpactPoint> impactPoints = new List<IImpactPoint>();

        
        public int X; // координата X центра эмиттера, будем ее использовать вместо MousePositionX
        public int Y; // соответствующая координата Y 
        public int Direction = 0; // вектор направления в градусах куда сыпет эмиттер
        public int Spreading = 360; // разброс частиц относительно Direction
        public int SpeedMin = 10; // начальная минимальная скорость движения частицы
        public int SpeedMax = 10; // начальная максимальная скорость движения частицы
        public int RadiusMin = 2; // минимальный радиус частицы
        public int RadiusMax = 10; // максимальный радиус частицы
        public int LifeMin = 50; // минимальное время жизни частицы
        public int LifeMax = 150; // максимальное время жизни частицы

        public int ParticlesPerTick = 1;

        public int maxPrticles = 500;

        public Color ColorFromDefault = Color.White; // начальный цвет частицы
        public Color ColorToDefault = Color.FromArgb(0, Color.Black); // конечный цвет частиц

        public Color ColorFrom = Color.White; // начальный цвет частицы
        public Color ColorTo = Color.FromArgb(0, Color.Black); // конечный цвет частиц

        public virtual Particle CreateParticle()
        {
            var particle = new Particle.ParticleColorful();
            particle.FromColor = ColorFrom;
            particle.ToColor = ColorTo;

            return particle;
        }

        public virtual void ResetParticle(Particle particle)
        {
            particle.TpIn = true;
            particle.TpOut = true;
            particle.Life = Particle.rand.Next(LifeMin, LifeMax);

            var p = (particle as Particle.ParticleColorful);
            p.FromColor = ColorFromDefault;
            p.ToColor = ColorToDefault;

            particle.X = X;
            particle.Y = Y;

            var direction = Direction
                + (double)Particle.rand.Next(Spreading)
                - Spreading / 2;

            var speed = Particle.rand.Next(SpeedMin, SpeedMax);

            particle.SpeedX = (float)(Math.Cos(direction / 180 * Math.PI) * speed);
            particle.SpeedY = -(float)(Math.Sin(direction / 180 * Math.PI) * speed);

            particle.Radius = Particle.rand.Next(RadiusMin, RadiusMax);
        }

        public void UpdateState()
        {
            int particlesToCreate = ParticlesPerTick;

            foreach (var particle in particles)
            {
                if (particle.Life <= 0) // если частицы умерла
                {
                    /* 
                     * то проверяем надо ли создать частицу
                     */
                    if (particlesToCreate > 0)
                    {
                        /* у нас как сброс частицы равносилен созданию частицы */
                        particlesToCreate -= 1; // поэтому уменьшаем счётчик созданных частиц на 1
                        ResetParticle(particle);
                    }
                }
                else
                {
                    /* теперь двигаю вначале */
                    particle.X += particle.SpeedX;
                    particle.Y += particle.SpeedY;

                    particle.Life -= 1;
                    foreach (var point in impactPoints)
                    {
                        point.ImpactParticle(particle);
                    }
                    var partic = (particle as Particle.ParticleColorful);
                    if (partic.FromColor == Color.White)
                    {
                        particle.SpeedX += GravitationX;
                        particle.SpeedY += GravitationY;
                    }
                    else
                    {
                        particle.SpeedX += GravitationX;
                        particle.SpeedY += GravitiClr;
                    }
                }
            }
            while (particlesToCreate >= 1 & maxPrticles >= 1)
            {
                maxPrticles--;
                particlesToCreate -= 1;
                var particle = CreateParticle();
                ResetParticle(particle);
                particles.Add(particle);
            }
        }

        public void Render(Graphics g)
        {
            // ну тут так и быть уж сам впишу...
            // это то же самое что на форме в методе Render
            foreach (var particle in particles)
            {
                particle.Draw(g);
            }

            foreach (var point in impactPoints) // тут теперь  impactPoints
            {
                point.Render(g); // это добавили
            }
        }

        public class TopEmitter : Emitter
        {
            public int Width; // длина экрана

            public override void ResetParticle(Particle particle)
            {
                base.ResetParticle(particle); // вызываем базовый сброс частицы, там жизнь переопределяется и все такое

                // а теперь тут уже подкручиваем параметры движения
                particle.X = Particle.rand.Next(Width); // позиция X -- произвольная точка от 0 до Width
                particle.Y = 0;  // ноль -- это верх экрана 

                particle.SpeedY = 1; // падаем вниз по умолчанию
                particle.SpeedX = Particle.rand.Next(-2, 2); // разброс влево и вправа у частиц 
            }
        }
    }
}
