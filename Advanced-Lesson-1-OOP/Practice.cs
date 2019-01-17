using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Lesson_1_OOP
{
    public class Practice
    {
        private static Random _random = new Random();
        /// <summary>
        /// A.L1.P1. Вывести матрицу (двумерный массив) отображающую площадь круга, 
        /// квадрата, равнобедренного треугольника со сторонами (радиусами) от 1 до 10.
        /// </summary>
        public static void A_L1_P1_OOP()
        {
            
            var arrMatrix = new ICalcArea[3,10];
            for(int i = 0; i<arrMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < arrMatrix.GetLength(1); j++)
                {
                    arrMatrix[i,j] = GenerateFigure();
                }
            }
            for (int i = 0; i < arrMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < arrMatrix.GetLength(1); j++)
                {
                    Console.Write("{0,5}", arrMatrix[i, j].CalcArea());
                }
                Console.WriteLine();
            }
        }


        /// <summary>
        /// A.L1.P6. Перегрузить следующие операторы для Transport <>,==/!= на базе физических размеров. 
        /// Продемонстрировать использование в коде. 
        /// </summary>
        /// 
        public static void A_L1_P6_OperatorsOverloading()
        {
        }

        /// <summary>
        /// A.L1.P7.Перегрузить операторы<>,==/!=  для продаваемых вещей в интернет магазине на базе их цены. 
        /// Продемонстрировать использование в коде. 
        /// </summary>
        public static void A_L1_P7_OperatorsOverloading()
        {            
        }

        public interface ICalcArea
        {
            double CalcArea();
        }

        public class Circle: ICalcArea
        {
            private readonly int _rad;

            public Circle(int rad)
            {
                _rad = rad;
            }

            public double CalcArea()
            {
                return Math.Round(Math.PI * _rad*_rad);
            }
        }
        public class Square : ICalcArea
        {
            private readonly int _side;

            public Square(int side)
            {
                _side = side;
            }
            public double CalcArea()
            {
                return _side*_side;
            }
        }

        public class Triangle : ICalcArea
        {
            private readonly int _side;
            private readonly int _height;

            public Triangle(int side, int height)
            {
                _side = side;
                _height = height;
            }

            public double CalcArea()
            {
                return Math.Round(0.5*_side*_height);
            }
        }

        public static ICalcArea GenerateFigure()
        {
            var figure = _random.Next(0, 2);
            switch (figure)
            {
                case 0: return new Circle(_random.Next(1,10));
                case 1: return new Square(_random.Next(1, 10));
                case 2: return new Triangle(_random.Next(1, 10), _random.Next(1,10));
                default: throw new ArgumentException("Нежданчик");
            }
        }
    }
}
