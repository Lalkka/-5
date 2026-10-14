using System;

namespace урок_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Выберите Номер задачи:");
                Console.WriteLine("[1]Робот-охранник с капризом\n[2]Сломанные весы\n[3]Светофор для дальтоника\n[4]Билет на поезд со скидками\n[5]Термометр с юмором\n[6]Логин с двумя паролями\n[7]Делится ли на 3 и на 5 одновременно\n[8]Который час — такой и совет\n[9]Треугольник или нет\n[10]Скидка в магазине по двум условиям\n");
                Console.WriteLine();
                string X = Console.ReadLine();

                if (X == "1")
                {
                    Console.Clear();
                    Console.WriteLine("Введите свой возраст:");
                    int Age = int.Parse(Console.ReadLine());
                    Console.WriteLine("Какой сегодня день недели?(от 1 до 7)");
                    int Week = int.Parse(Console.ReadLine());
                    if (Age >= 18 && Age >= 60 && Week != 1)
                    {
                        Console.WriteLine("\nПроходите");
                        Console.ReadLine();
                    }
                    else if (Age < 18)
                    {
                        Console.WriteLine("\nСлишком молод");
                        Console.ReadLine();
                    }
                    else if (Age > 60)
                    {
                        Console.WriteLine("\nСлишком стар");
                        Console.ReadLine();
                    }
                    else if (Week == 1)
                    {
                        Console.WriteLine("\nСегодня день профлактики");
                        Console.ReadLine();
                    }
                }
                else if (X == "2")
                {
                    Console.Clear();
                    Console.WriteLine("Введите вес посылки:");
                    double Weight = double.Parse(Console.ReadLine());
                    if (Weight < 0)
                    {
                        Console.WriteLine("\nОшибка");
                        Console.ReadLine();
                    }
                    else if (Weight == 0)
                    {
                        Console.WriteLine("\nПосылка пуста");
                        Console.ReadLine();
                    }
                    else if (Weight > 0 && Weight < 1)
                    {
                        Console.WriteLine("\nМелкий пакет");
                        Console.ReadLine();
                    }
                    else if (Weight >= 1 && Weight <= 10)
                    {
                        Console.WriteLine("\nОбычная посылка");
                        Console.ReadLine();
                    }
                    else if (Weight > 10)
                    {
                        Console.WriteLine("\nТребуется грузовик");
                        Console.ReadLine();
                    }
                }
                else if (X == "3")
                {
                    Console.Clear();
                    Console.WriteLine("Введите первувю буквву цвета свветофора (");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("К");
                    Console.Write(", ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Ж");
                    Console.Write(", ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("З");
                    Console.ResetColor();
                    Console.Write("):");
                    char Color = Console.ReadKey().KeyChar;
                    Console.ReadKey();
                    Console.WriteLine();
                    if (Color == 'К' || Color == 'к')
                    {
                        Console.WriteLine("\nСтой");
                        Console.ReadLine();
                    }
                    else if (Color == 'Ж' || Color == 'ж')
                    {
                        Console.WriteLine("\nЖди");
                        Console.ReadLine();
                    }
                    else if (Color == 'З' || Color == 'з')
                    {
                        Console.WriteLine("\nИди");
                        Console.ReadLine();
                    }

                }
                else if (X == "4")
                {
                    Console.Clear();
                    Console.WriteLine("Введите возраст пасажира:");
                    int Age = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите стоимость билета:");
                    double Price = double.Parse(Console.ReadLine());
                    if (Age < 5)
                    {
                        Console.WriteLine("\nБесплатно");
                        Console.ReadLine();
                    }
                    else if (Age >= 5 && Age < 18)
                    {
                        Price /= 2;
                        Console.WriteLine($"\nЦена:{Price}");
                        Console.ReadLine();
                    }
                    else if (Age >= 18 && Age < 60)
                    {
                        Console.WriteLine($"\nЦена:{Price}");
                        Console.ReadLine();
                    }
                    else if (Age >= 60)
                    {
                        Price *= 0.7;
                        Console.WriteLine($"\nЦена:{Price}");
                        Console.ReadLine();
                    }
                }
                else if (X == "5")
                {
                    Console.Clear();
                    Console.WriteLine("Введите температуру воздуха:");
                    int Temp = int.Parse(Console.ReadLine());
                    if (Temp < -50 || Temp > 60)
                    {
                        Console.WriteLine("\nТакого не бывает, ты врешь");
                        Console.ReadLine();
                    }
                    else if (Temp >= -50 && Temp < 0)
                    {
                        Console.WriteLine("\nSooo Q-cold :D");
                        Console.ReadLine();
                    }
                    else if (Temp == 0)
                    {
                        Console.WriteLine("\nНейтралка");
                        Console.ReadLine();
                    }
                    else if (Temp >0 && Temp < 25)
                    {
                        Console.WriteLine("\nCool, комфортик");
                        Console.ReadLine();
                    }
                    else if (Temp >= 25 && Temp < 60)
                    {
                        Console.WriteLine("\nЖарко, иди купаца");
                        Console.ReadLine();
                    }
                }
                else if (X == "6")
                {
                    Console.Clear();
                    string L001 = "admin", L002 = "guest", P001 = "1234", P002 = "0000";
                    Console.WriteLine("Введите логин:");
                    string A = Console.ReadLine();
                    Console.WriteLine("Введите пароль:");
                    string B = Console.ReadLine();
                    if (A == L001 && B == P001 || A == L002 && B == P002)
                    {
                        Console.WriteLine("\nДобро пожаловать!");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("\nОтказано в доступе");
                        Console.ReadLine();
                    }
                }
                else if (X == "7")
                {
                    Console.Clear();
                    Console.WriteLine("Введите целое число:");

                }
                else if (X == "8")
                {
                    Console.Clear();

                }
                else if (X == "9")
                {
                    Console.Clear();

                }
                else if (X == "10")
                {
                    Console.Clear();

                }
            }
        }
    }
}
