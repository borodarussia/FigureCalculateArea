using Figure.Library.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure.Library.Models
{
    /// <summary> Треугольник </summary>
    public class Triangle : IFigure, ISemiperimeter
    {
        private double _firstSide;
        private double _secondSide;
        private double _thirdSide;

        /// <summary> Первая стороная треугольника </summary>
        public double FirstSide
        {
            get 
            {
                return _firstSide;
            }
            set
            {
                if (IsRightSide(value, _secondSide, _thirdSide))
                {
                    throw new ArgumentException("Неверно введена сторона треугольника");
                }

                _firstSide = value;
            }
        }

        /// <summary> Вторая стороная треугольника </summary>
        public double SecondSide
        {
            get
            {
                return _secondSide;
            }
            set
            {
                if (IsRightSide(value, _firstSide, _thirdSide))
                {
                    throw new ArgumentException("Неверно введена сторона треугольника");
                }

                _secondSide = value;
            }
        }

        /// <summary> Третья сторона треугольника </summary>
        public double ThirdSide
        {
            get
            {
                return _thirdSide;
            }
            set
            {
                if (IsRightSide(value, _firstSide, _secondSide))
                {
                    throw new ArgumentException("Неверно введена сторона треугольника");
                }

                _thirdSide = value;
            }
        }

        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            if(!IsRightSide(thirdSide, firstSide, secondSide))
            {
                throw new ArgumentException("Неверно введена третья сторона", nameof(thirdSide));
            }

            if(!IsRightSide(secondSide, firstSide, thirdSide))
            {
                throw new ArgumentException("Неверно введена вторая сторона", nameof(secondSide));
            }

            if(!IsRightSide(firstSide, secondSide, thirdSide))
            {
                throw new ArgumentException("Неверно введена первая сторона", nameof(firstSide));
            }

            _firstSide = firstSide;
            _secondSide = secondSide;
            _thirdSide = thirdSide;
        }

        /// <summary> Расчет площади треугольника </summary>
        /// <returns> Значение площади треугольника </returns>
        public double CalculateSquare()
        {
            var semiperimeter = CalculateSemiperimeter();

            return Math.Round(Math.Sqrt(semiperimeter
                * (semiperimeter - _firstSide) 
                * (semiperimeter - _secondSide) 
                * (semiperimeter - _thirdSide)), 4);
        }

        /// <summary> Расчет полупериметра треугольника </summary>
        /// <returns> Значение полупериметра треугольника </returns>
        public double CalculateSemiperimeter()
        {
            return (_firstSide + _secondSide + _thirdSide) / 2;
        }

        /// <summary> Проверка на то, что треугольник прямоугольный </summary>
        /// <returns> true, если треугольник прямоугольный </returns>
        public bool IsRightAngled()
        {
            if (PifagorsFormula(_firstSide, _secondSide, _thirdSide)
                || PifagorsFormula(_secondSide, _firstSide, _thirdSide)
                || PifagorsFormula(_thirdSide, _firstSide, _secondSide))
            {
                return true;
            }

            return false;
        }

        private bool PifagorsFormula(double sideA, double sideB, double sideC)
        {
            return Math.Pow(sideA, 2) == Math.Pow(sideB, 2) + Math.Pow(sideC, 2);
        }

        /// <summary> Проверка того, что сторона удовлетворяет условию существования треугольника </summary>
        /// <param name="checkSide"> Проверяемая сторона </param>
        /// <param name="sideA"> Сторона А </param>
        /// <param name="sideB"> Сторона Б </param>
        /// <returns> Если сторона удовлетворяет условию существования треугольника - true </returns>
        private bool IsRightSide(double checkSide, double sideA, double sideB)
        {
            if(sideA + sideB > checkSide && checkSide > 0)
                return true;

            return false;
        }
    }
}
