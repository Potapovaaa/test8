using System;
using System.Diagnostics;
using System.Text;
using System.Threading;

namespace скоропечатание
{
    class program
    {
        public static int i;
        static void Main() //Главное меню(приветсвие)
        {
            Console.WriteLine("Введите свое имя");
            string name = Console.ReadLine();
            Console.WriteLine("Нажмите Enter чтобы начать тест");
            ConsoleKeyInfo key = Console.ReadKey();
            while (true)
            {
                if (key.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    text();
                    thread.Start();
                    Console.SetCursorPosition(100, 40);


                }
                if (key.Key == ConsoleKey.Escape)
                {
                    Environment.Exit(0);
                }
                if (key.Key == ConsoleKey.R)
                {
                    Console.Clear();
                    text();
                    thread.Start();
                    Console.SetCursorPosition(100, 40);
                }
            }


        }



        static void text() //вывод текста пользователю
        {
            thread.Start();
            int position = 0;
            int bukva = 0;
            int Nobukva = 0;
            string text_ = "Самая лучшая песня у царя всех певцов – соловья! Соловей прилетает к нам тогда, когда по  лесу уже давно распевают на все лады зяблики, дрозды и другие певчие птички.";
            Console.WriteLine(text_);
            Console.SetCursorPosition(0, 0);
            List<char> people = new List<char>();
            foreach (char i in text_)
            {
                people.Add(i);
            }

            for (int i = 0; i < people.Count; i++)
            {
                var key = Console.ReadKey();
                if (key.Key == ConsoleKey.Backspace)
                {
                    Console.ForegroundColor = System.ConsoleColor.Gray;
                    Console.WriteLine(people[position]);
                    Console.SetCursorPosition(position, 0);
                    i--;
                    i--;
                    position--;
                    position--;

                    if (key.KeyChar != people[i])
                    {
                        Nobukva--;
                    }

                    if (key.KeyChar == people[i])
                    {
                        bukva--;
                    }

                }
                if (key.KeyChar == people[i])
                {
                    Console.ForegroundColor = System.ConsoleColor.Green;
                    bukva++;
                    position++;
                }

                if (key.KeyChar != people[i])
                {
                    Console.ForegroundColor = System.ConsoleColor.Red;
                    Nobukva++;
                    position++;
                }


            }
        }


        public static Thread thread = new Thread(_ =>
        {
           
            for (i = 60; i >= 0; i--)
            {

                Thread.Sleep(1000);
                if (i >= 10)
                {
                    Console.SetCursorPosition(0, 10);
                    Console.WriteLine("Таймер: 0:" + i);
                }
                else Console.WriteLine("Таймер: 0:0" + i);
            }
        
            if (i==0)
            {
               Console.WriteLine("для повторного теста нажмите ENTER");
            }
              
        });
      
    }
}