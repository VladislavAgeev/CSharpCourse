using System;

namespace Vector
{
    public class Vector
    {
        private double[] vector;

        public Vector(int n)//размерность n, все компоненты равны 0
        {
            if (n <= 0)
            {
                throw new ArgumentException("Размерность должна быть > 0", nameof(n));
            }

            vector = new double[n];
        }

        public Vector(Vector previousVector)//конструктор копирования
        {
            vector = previousVector.vector;
        }

        public Vector(double[] valuesArray)//заполнение вектора значениями из массива
        {
            vector = valuesArray;
        }

        public Vector(int n, double[] valuesArray)//заполнение вектора значениями из массива. 
                                                  //Если длина массива меньше n, то считать что в остальных компонентах 0
        {
            if (n <= 0)
            {
                throw new ArgumentException("Размерность должна быть > 0", nameof(n));
            }

            if (n < valuesArray.Length)
            {
                throw new ArgumentException("Размерность должна быть больше либо равна длине массива", nameof(n));
            }

            vector = new double[n];

            for (int i = 0; i < valuesArray.Length; i++)
            {
                vector[i] = valuesArray[i];
            }
        }

        public int GetSize()//размерность вектора
        {
            return vector.Length;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(obj, this))
            {
                return true;
            }

            if (ReferenceEquals(obj, null) || obj.GetType() != GetType())
            {
                return false;
            }

            Vector v = (Vector)obj;

            if (vector.Length == v.vector.Length)
            {
                for (int i = 0; i < v.vector.Length; i++)
                {
                    if (vector[i] != v.vector[i])
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public override int GetHashCode()
        {
            int prime = 37;
            int hash = 1;

            hash = prime * hash;

            for (int i = 0; i < vector.Length; i++)
            {
                hash += vector[i].GetHashCode();
            }

            return hash;
        }

        public override string ToString()//информация о векторе
        {
            return "{" + string.Join(", ", vector) + "}";
        }

        public void MakeVectorsSum(Vector valuesArray)//4a. Прибавление к вектору другого вектора
        {
            if (vector.Length == valuesArray.vector.Length)
            {
                for (int i = 0; i < vector.Length; i++)
                {
                    vector[i] += valuesArray.vector[i];
                }
            }
            else
            {
                double[] vectorsSum = new double[Math.Max(vector.Length, valuesArray.vector.Length)];

                for (int i = 0; i < Math.Min(vector.Length, valuesArray.vector.Length); i++)
                {
                    vectorsSum[i] = vector[i] + valuesArray.vector[i];
                }

                for (int i = Math.Min(vector.Length, valuesArray.vector.Length); i < vectorsSum.Length; i++)
                {
                    if (vector.Length < valuesArray.vector.Length)
                    {
                        vectorsSum[i] = valuesArray.vector[i];
                    }
                    else
                    {
                        vectorsSum[i] = vector[i];
                    }
                }

                vector = vectorsSum;
            }
        }

        public void MakeVectorsDifference(Vector valuesArray)//4b. Вычитание из вектора другого вектора
        {
            if (vector.Length == valuesArray.vector.Length)
            {
                for (int i = 0; i < vector.Length; i++)
                {
                    vector[i] -= valuesArray.vector[i];
                }
            }
            else
            {
                double[] vectorsDifference = new double[Math.Max(vector.Length, valuesArray.vector.Length)];

                for (int i = 0; i < Math.Min(vector.Length, valuesArray.vector.Length); i++)
                {
                    vectorsDifference[i] = vector[i] - valuesArray.vector[i];
                }

                for (int i = Math.Min(vector.Length, valuesArray.vector.Length); i < vectorsDifference.Length; i++)
                {
                    if (vector.Length < valuesArray.vector.Length)
                    {
                        vectorsDifference[i] = valuesArray.vector[i];
                    }
                    else
                    {
                        vectorsDifference[i] = vector[i];
                    }
                }

                vector = vectorsDifference;
            }
        }

        public void MultiplyVectorByScalar(int scalar)//4c. Умножение вектора на скаляр
        {
            for (int i = 0; i < vector.Length; i++)
            {
                vector[i] = vector[i] * scalar;
            }
        }

        public void ReverseVector()//4d. Разворот вектора
        {
            for (int i = 0; i < vector.Length; i++)
            {
                vector[i] = vector[i] * (-1);
            }
        }

        public double GetLength()//4e. Длина вектора
        {
            double vectorLenght = 0;

            for (int i = 0; i < vector.Length; i++)
            {
                vectorLenght += Math.Pow(vector[i], 2);
            }

            vectorLenght = Math.Sqrt(vectorLenght);

            return vectorLenght;
        }

        public double GetComponent(int index)//получение компоненты вектора
        {
            return vector[index];
        }

        public void SetComponent(int index, double value)//установка компоненты вектора
        {
            vector[index] = value;
        }

        public static Vector GetSum(Vector valuesArray1, Vector valuesArray2)//5a. Сложение двух векторов
        {
            double[] sumVectors = new double[Math.Max(valuesArray1.vector.Length, valuesArray2.vector.Length)];

            for (int i = 0; i < Math.Min(valuesArray1.vector.Length, valuesArray2.vector.Length); i++)
            {
                sumVectors[i] = valuesArray1.vector[i] + valuesArray2.vector[i];
            }

            for (int i = Math.Min(valuesArray1.vector.Length, valuesArray2.vector.Length); i < sumVectors.Length; i++)
            {
                if (valuesArray1.vector.Length < valuesArray2.vector.Length)
                {
                    sumVectors[i] = valuesArray2.vector[i];
                }
                else
                {
                    sumVectors[i] = valuesArray1.vector[i];
                }
            }

            return new Vector(sumVectors);
        }

        public static Vector GetDifference(Vector valuesArray1, Vector valuesArray2)//5b. Вычитание двух векторов
        {
            double[] differenceVectors = new double[Math.Max(valuesArray1.vector.Length, valuesArray2.vector.Length)];

            for (int i = 0; i < Math.Min(valuesArray1.vector.Length, valuesArray2.vector.Length); i++)
            {
                differenceVectors[i] = valuesArray1.vector[i] - valuesArray2.vector[i];
            }

            for (int i = Math.Min(valuesArray1.vector.Length, valuesArray2.vector.Length); i < differenceVectors.Length; i++)
            {
                if (valuesArray1.vector.Length < valuesArray2.vector.Length)
                {
                    differenceVectors[i] = -valuesArray2.vector[i];
                }
                else
                {
                    differenceVectors[i] = valuesArray1.vector[i];
                }
            }

            return new Vector(differenceVectors);
        }

        public static Vector GetScalarComposition(Vector valuesArray1, Vector valuesArray2)//5c. Скалярное произведение
        {
            double[] scalarComposition = new double[Math.Max(valuesArray1.vector.Length, valuesArray2.vector.Length)];

            for (int i = 0; i < Math.Min(valuesArray1.vector.Length, valuesArray2.vector.Length); i++)
            {
                scalarComposition[i] = valuesArray1.vector[i] * valuesArray2.vector[i];
            }

            return new Vector(scalarComposition);
        }
    }
}
