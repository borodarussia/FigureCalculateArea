using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure.Library.Models.Interfaces
{
    public interface ISquare
    {
        /// <summary>
        /// Расчет площади
        /// </summary>
        /// <returns> Площадь фигуры </returns>
        double CalculateSquare();
    }
}
