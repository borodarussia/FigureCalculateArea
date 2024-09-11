using Figure.Library.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure.Library.Services
{
    public static class FigureParametersCalculator
    {
        public static double CalculateSquare(IFigure figure)
        {
            return figure.CalculateSquare();
        }
    }
}
