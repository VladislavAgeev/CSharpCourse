using System;

namespace Vector
{
    class VectorMain
    {
        static void Main(string[] args)
        {
            Vector v1 = new Vector(7, new double[] { 6, 8, 4, 3, 10, 7, 9 });

            Vector v2 = new Vector(new double[] { 6, 8, 4, 3, 10, 7, 9 });

            Vector v3 = new Vector(new double[] { 5, 9, 4, 5, 6, 7 });

            Vector v4 = new Vector(new double[] { 1, 3, 5, 2, 4, 6 });

            if (v1.Equals(v2))
            {
                Console.WriteLine("Векторы имеют одинаковую размерность и соответствующие компоненты равны.");
            }
            else
            {
                Console.WriteLine("Векторы не равны.");
            }

            Vector sum = Vector.GetSum(v2, v3);
            Console.WriteLine("Сумма = " + string.Join(", ", sum));

            Console.WriteLine("Компонента вектора = " + sum.GetComponent(1));

            Vector difference = Vector.GetDifference(v2, v3);
            Console.WriteLine("Разность = " + string.Join(", ", difference));

            v1.SetComponent(1, 7);
            Console.WriteLine("Вектор с изменненной компонентой = " + v1);

            Vector scalarComposition = Vector.GetScalarComposition(v1, v3);
            Console.WriteLine("Скалярное произведение = " + string.Join(", ", scalarComposition));

            v4.MultiplyVectorByScalar(2);
            Console.WriteLine("Умножение вектора на скаляр = " + v4);
        }
    }
}
