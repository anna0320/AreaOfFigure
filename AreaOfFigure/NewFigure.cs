using System;

namespace AreaOfFigure
{
    public class NewFigure
    {
        public IFigure Figure { get; private set; }

        public void SetFigure (IFigure figure)
        {
            Figure = figure;
        }

        public void CalculateAreaOfUnknownFigure()
        {
            if (Figure != null)
                Console.WriteLine($"Площадь фигуры: {Figure.CalculateArea()}");
            else Console.WriteLine("Не задана фигура!");
        }
    }
}
