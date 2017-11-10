using System;

namespace Chapter9
{
    class Program
    {
        public Program()
        {
            int exercise = 50;
            do
            {
                Console.WriteLine("Elige un ejercicio");
                exercise = Int32.Parse(Console.ReadLine());

                switch (exercise)
                {
                    case 45:
                        Exercise45();
                        break;

                    case 46:
                        Exercise46();
                        break;

                    case 47:
                        Exercise47();
                        break;

                    case 48:
                        Exercise48();
                        break;

                    case 49:
                        Exercise49();
                        break;

                    case 50:
                        Exercise50();
                        break;

                    default:
                        Console.WriteLine("La opcion introducida no esta disponible");
                        break;
                }

            } while (exercise > 45 && exercise < 50);
        }

    static void Main(string[] args)
        {
            Program p = new Program();
            Console.ReadKey();
        }

        private void Exercise45()
        {
            int[] numbers = new int[10];
            
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite un numero");
                numbers[i] = Int32.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 10; i++)
            {
                int firstDigit = GetFirstDigit(numbers[i]);

                if (firstDigit == 34)
                {
                    Console.WriteLine("El numero empieza con: 34");
                }
            }
        }

        private void Exercise46()
        {
            int[] numbers = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite un numero");
                numbers[i] = Int32.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 10; i++)
            {
                int firstDigit = GetFirstDigit(numbers[i]);

                if (firstDigit == 5)
                {
                    Console.WriteLine("El numero empieza con: 5");
                }
            }
        }

        private void Exercise47()
        {
            int[] numbers = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite un numero");
                numbers[i] = Int32.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 10; i++)
            {
                int firstDigit = GetFirstDigit(numbers[i]);

                if (numbers[i] % 10 == 0)
                {
                    Console.WriteLine("En la posicion: " + i + "se encuentra un multiplo de 10");
                }
            }
        }

        private void Exercise48()
        {
            int[] numbers = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite un numero");
                numbers[i] = Int32.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 10; i++)
            {
                int firstDigit = GetFirstDigit(numbers[i]);

                if (numbers[i] % 10 == 0)
                {
                    Console.WriteLine("En la posicion: " + i + "se encuentra un multiplo de 10");
                }
            }
        }

        private void Exercise49()
        {
            int[] numbers = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite un numero");
                numbers[i] = Int32.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 10; i++)
            {
                if (!IsEven(GetLastDigit(numbers[i])) && IsPrime(GetLastDigit(numbers[i])) )
                {
                    Console.WriteLine("En la posicion: " + i + " el ultimo digito es primo");
                }
            }
        }

        private void Exercise50()
        {
            int[] numbers = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite un numero");
                numbers[i] = Int32.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 10; i++)
            {
                if (!IsEven(GetFirstDigit(numbers[i])) && IsPrime(GetFirstDigit(numbers[i])))
                {
                    Console.WriteLine("En la posicion: " + i + " el primer digito es primo");
                }
            }
        }

        private bool IsPrime(int number)
        {
            for (int i = 3; i <= number; i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }

        private bool IsEven(int n) => (n % 2 == 0) ? true : false;

        private int GetFirstDigit(int number)
        {   return number / 10; }

        private int GetLastDigit(int number)
        {   return number % 10;    }
    }
}
