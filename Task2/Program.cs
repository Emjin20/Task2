using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int[] mas = new int[10];
            int randomMas = RandomMassiv(mas);
            int readyMas = SortMassiv(mas);
            int numeral = Numbers(ref mas,ref num);


            
        }

        static int RandomMassiv(int[] mas)
        {
            int randomMas = mas[0];

            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                mas[i] = random.Next(1, 20);

            }
            return randomMas;
        }

        static int SortMassiv(int[] mas)
        {
            int readyMas = mas[0];

            for (int i = 1; i < 10; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (mas[i] < mas[j])
                    {
                        readyMas = mas[j];
                        mas[j] = mas[i];
                        mas[i] = readyMas;

                    }

                }
            }
            return readyMas;
        }
        static int Numbers(ref int[] mas, ref int num)
        {
            int i = 0;
            int numeral = 0;
            Console.Write("Введите число: ");
            string digit = Console.ReadLine();
            num = Convert.ToInt32(digit);
            while (i < 10)
            {
                if (num == mas[i])
                {
                    Console.WriteLine("Число {0} содержится в массиве", num);
                    break;
                } else if (i == 9 & num != mas[9])
                {
                    Console.WriteLine("Число {0} не содержится в массиве", num);
                }
                i++;
            }
            return numeral;
        }
        
    }
}


