using System;

namespace ClassWork4Console
{
    class Program
    {
        static double AToPowerB(double a, int b)
        {
            double result = 1;
            for (int i = 0; i < b; i++)
            {
                result *= a;
            }

            return Math.Round(result, 2);
        }

        static int PowerCount(double a)
        {
            int i;
            for (i = (int)a / 2; i * i > a; i--)
            {
            }

            return i * i == a ? i - 1 : i;
        }

        static int MaxDivider(int a)
        {
            int i;
            for (i = a / 2; i >= 1; i--)
            {
                if(a % i == 0)
                {
                    break;
                }
            }

            return i;
        }

        static int SumFromAToB(int a, int b)
        {
            if(a > b)
            {
                Swap(ref a, ref b);
            }

            int sum = 0;
            a += 7 - a % 7;
            for (int i = a; i <= b; i += 7)
            {
                sum += i;
            }

            return sum;
        }

        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        static bool ContainsSameDigit(int a, int b)
        {
            while (a != 0)
            {
                int digitA = a % 10;
                int bCopy = b;
                while (bCopy != 0)
                {
                    int digitB = bCopy % 10;
                    bCopy /= 10;
                    if (digitB == digitA)
                    {
                        return true;
                    }
                }

                a /= 10;
            }

            return false;
        }

        static int PositiveNumbersCount(int[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    ++count;
                }
            }

            return count;
        }

        static void Sort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        Swap(ref array[i], ref array[j]);
                    }
                }
            }
        }

        static int GetPositiveNumbersCount(int[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0)
                {
                    ++count;
                }
            }

            return count;
        }

        static void ReCreateArrayWithOnlyPositiveNumbers(ref int[] array)
        {
            int count = GetPositiveNumbersCount(array);

            int[] newArray = new int[count];
            for (int i = 0, j = 0; i < array.Length; i++)
            {
                if (array[i] >= 0)
                {
                    newArray[j++] = array[i];
                }
            }

            array = newArray;
        }

        static void ReCreateArrayWithoutRepeation(ref int[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                bool isFound = false;
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] == array[j] && i != j)
                    {
                        isFound = true;
                        break;
                    }
                }

                if (!isFound)
                {
                    ++count;
                }
            }

            int[] newArray = new int[count];
            for (int i = 0, newArrIndex = 0; i < array.Length; i++)
            {
                bool isFound = false;
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] == array[j] && i != j)
                    {
                        isFound = true;
                        break;
                    }
                }

                if (!isFound)
                {
                    newArray[newArrIndex++] = array[i];
                }
            }

            array = newArray;
        }

        static void UpdateArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0)
                {
                    array[i] *= -1;
                }
                else
                {
                    array[i] *= array[i];
                }
            }
        }

        static bool IsOrdered(int[] array)
        {
            bool result = true;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    result = false;
                    break;
                }
            }

            return result;
        }

        static void Main(string[] args)
        {
            int N = 3;
            int[] array = new int[N];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 10);
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }

            Console.WriteLine();

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }

            Console.WriteLine();
        }
    }
}
