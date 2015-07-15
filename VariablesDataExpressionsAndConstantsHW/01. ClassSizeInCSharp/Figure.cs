/* Refactor the following code to use proper variable naming and simplified expressions:

public class Size
{
    public double wIdTh, Viso4ina;
    public Size(double w, double h)
    {
        this.wIdTh = w;
        this.Viso4ina = h;
    }

    public static Size GetRotatedSize(
        Size s, double angleOfTheFigureThatWillBeRotaed)
    {
        return new Size(
            Math.Abs(Math.Cos(angleOfTheFigureThatWillBeRotaed)) * s.wIdTh + 
                Math.Abs(Math.Sin(angleOfTheFigureThatWillBeRotaed)) * s.Viso4ina,
            Math.Abs(Math.Sin(angleOfTheFigureThatWillBeRotaed)) * s.wIdTh + 
                Math.Abs(Math.Cos(angleOfTheFigureThatWillBeRotaed)) * s.Viso4ina);
    }
}
 */

namespace _01.ClassSizeInCSharp
{
    using System;

    public class Figure
    {
        private double width;
        private double height;

        public Figure(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public double Width
        {
            get
            {
                return this.width;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Width cannot be less or equal to zero!");
                }

                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Height cannot be less or equal to zero!");
                }

                this.height = value;
            }
        }

        public static Figure GetRotatedFigure(Figure figure, double angleOfRotation)
        {
            double cosinusWidth = Math.Abs(Math.Cos(angleOfRotation)) * figure.width;
            double cosinusHeight = Math.Abs(Math.Sin(angleOfRotation)) * figure.height;
            double sinusWidth = Math.Abs(Math.Sin(angleOfRotation)) * figure.width;
            double sinusHeight = Math.Abs(Math.Cos(angleOfRotation)) * figure.height;

            double rotatedFigureWidth = (cosinusWidth * figure.width) + (sinusHeight * figure.height);
            double rotatedFigureHeight = (sinusWidth * figure.width) + (cosinusHeight * figure.height);

            Figure rotatedFigure = new Figure(rotatedFigureWidth, rotatedFigureHeight);
            return rotatedFigure;
        }
    }
}