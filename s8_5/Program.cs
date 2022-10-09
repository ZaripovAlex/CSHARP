// Задача 61: Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника


float Factorial(int n)
        {
            float i, x = 1;
            for (i = 1; i <= n; i++)
            {
                x *= i;
            }
            return x;
        }
Console.Clear();
Console.Write("Введите количество строк в таблице. ");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < n; i++)
            {
                for (int c = 0; c <= (n - i); c++) 
                {
                    Console.Write(" "); 
                }
                for (int c = 0; c <= i; c++)
                {
                    Console.Write(" ");
                    Console.Write(Factorial(i) / (Factorial(c) * Factorial(i - c)));
                }
                Console.WriteLine();
                
            }            