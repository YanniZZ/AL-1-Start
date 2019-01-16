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
        /// <summary>
        /// A.L1.P1. Вывести матрицу (двумерный массив) отображающую площадь круга, 
        /// квадрата, равнобедренного треугольника со сторонами (радиусами) от 1 до 10.
        /// </summary>
        public static void A_L1_P1_OOP()
        {
            var arrCircle = new Circle(3);
            var arrCircle1 = new Circle(5);

            var arrSquare = new Square(3);
            var arrSquare1 = new Square(6);

            var arrTriangle = new Triangle(2,3);
            var arrTriangle1 = new Triangle(4,5);

            var arrMatrix = new ICalcArea[]{ arrCircle, arrCircle1, arrSquare, arrSquare1, arrTriangle, arrTriangle1};

            foreach ( var figure in arrMatrix)
            {
                Console.WriteLine(figure.CalcArea());
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

        interface ICalcArea
        {
            double CalcArea();
        }

        public class Circle: ICalcArea
        {
            private readonly int _rad;

            public Circle(int rad)
            {
                this._rad = rad;
            }

            public double CalcArea()
            {
                return Math.PI * _rad*_rad;
            }
        }
        public class Square : ICalcArea
        {
            private readonly int _side;

            public Square(int side)
            {
                this._side = side;
            }
            public double CalcArea()
            {
                return _side*_side;
            }
        }

        public class Triangle : ICalcArea
        {
            private readonly  int _side;
            private readonly int _height;

            public Triangle(int side, int height)
            {
                this._side = side;
                this._height = height;
            }

            public double CalcArea()
            {
                return 0.5*_side*_height;
            }
        }
    }
}
