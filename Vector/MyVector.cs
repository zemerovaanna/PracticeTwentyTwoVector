using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector
{
    internal class MyVector
    {
        private int X { get; set; }
        private int Y { get; set; }
        private int Z { get; set; }

        public MyVector() { }

        public MyVector(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        //Длина вектора.
        public double VectorLength()
        {
            return Math.Sqrt(X * X + Y * Y + Z * Z);
        }

        //Получение нового вектора через сложение.
        public MyVector NewVectorSum(MyVector a, MyVector b)
        {
            return new MyVector(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
        }

        //Получение нового вектора через вычитание.
        public MyVector NewVectorSub(MyVector a, MyVector b)
        {
            return new MyVector(a.X - b.X, a.Y - b.Y, a.Z - b.Z);
        }

        //Скалярное произведение векторов.
        public static double ScalarProduct(MyVector a, MyVector b)
        {
            return (a.X * b.X + a.Y * b.Y + a.Z * b.Z);
        }

        //Вычисление косинуса угла между векторами.
        public static double Cos(MyVector a, MyVector b)
        {
            return ScalarProduct(a, b) / (a.VectorLength() * b.VectorLength());
        }

        //Точки вектора.
        public string VectorPoints()
        {
            return $"{X},{Y},{Z}";
        }
    }
}