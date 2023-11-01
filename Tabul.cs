using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    internal class Tabul
    {
        //Поле з результуючим масивом 
        public double[,] xy = new double[1000, 2];
        //Реальна кількість елементів в масиві 
        public int n = 0;
        //Методи для обрахунку функцій
        private double f1(double x)
        {
            return (Math.Sin(x + 3)) / (Math.Pow(x, 5) * 1 / Math.Tan(2 * Math.Pow(x, 3)));
        }
        private double f2(double x)
        {
            return (Math.Abs(x) + 2) / Math.Pow(Math.Cos(Math.Pow(x, 3) + 2 * x + 1), 2);
        }
        private double f3(double x)
        {
            return (Math.Pow(Math.Sin(x + 5), 2)) / Math.Pow(Math.Abs(x) + 2, 3) - 1;
        }
        //Метод табулювання
        public void tab(double xn = 1.7, double xk = 4.9, double h = 0.5, double a = 5)
        {
            double x = xn, y;
            int i = 0;
            while (x <= xk)
            {
                if(x < 0)
                    y = f1(x);
                else
                {
                    if ((x >= 0) && (x < a))
                        y = f2(x);
                    else
                        y = f3(x);
                }
                xy[i, 0] = x;
                xy[i, 1] = y;
                x = x + h;
                i++;
            }
            n = i;
        }
    }
}
