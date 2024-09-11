using Figure.Library.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure.Library.Services
{
    /// <summary>
    /// Статический класс для расчета площади в режиме компиляции
    /// </summary>
    public static class FigureParametersCalculator
    {
        /// <summary>
        /// Расчет площади фигуры
        /// </summary>
        /// <param name="figure"></param>
        /// <returns></returns>
        public static double CalculateSquare<T>(T figure) where T : IFigure
        {
            return figure.CalculateSquare();
        }

        /// <summary>
        /// Расчет списка фигур
        /// </summary>
        /// <param name="figures"></param>
        /// <returns></returns>
        public static IEnumerable<double> CalculateSquares<T>(IEnumerable<T> figures) where T : IFigure
        {
            List<double> squares = new List<double>();

            foreach (IFigure f in figures)
            {
                squares.Add(CalculateSquare(f));
            }

            return squares;
        }
    }
}
