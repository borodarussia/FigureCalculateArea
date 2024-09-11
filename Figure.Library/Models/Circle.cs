using Figure.Library.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure.Library.Models
{
    /// <summary>
    /// Круг
    /// </summary>
    public class Circle : IFigure
    {
        private double _radius = 0.0;

        /// <summary> Радиус </summary>
        public double Radius
        {
            get
            {
                return _radius;
            }
            set
            {
                if(value <= 0.0)
                {
                    throw new ArgumentException("Неправильно введен определяющий размер окружности",
                        nameof(value));
                }

                _radius = value;
            }
        }

        /// <summary> Диаметр </summary>
        public double Diameter
        {
            get
            {
                return _radius * 2.0;
            }

            set
            {
                if (value <= 0.0)
                {
                    throw new ArgumentException("Неправильно введен определяющий размер окружности",
                        nameof(value));
                }

                _radius = value / 2.0;
            }
        }

        /// <summary> Окружность </summary>
        /// <param name="length"> Радиус или диаметр </param>
        /// <param name="isRadius"> Если радиус, то true, если диаметр, то false </param>
        public Circle(double length, bool isRadius)
        {
            if (length <= 0.0)
                throw new ArgumentException("Неправильно введен определяющий размер окружности",
                    nameof(length));

            if(isRadius)
                _radius = length;
            else
                _radius = length / 2.0;
        }

        /// <summary>
        /// Расчет площади круга
        /// </summary>
        /// <returns> Площаь круга </returns>
        public double CalculateSquare()
        {
            return Math.Round(Math.PI * Math.Pow(_radius, 2), 4);
        }
    }
}
