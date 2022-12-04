DateTime data = new DateTime(2022, 11, 10);
List<string> den = new List<string> {$"  1.Сделать уроки\n  2.Убрать в доме", $"  1.Анжумания\n  2.Пресс качат", $"  1.Бегит\n  Анжумания", $"  1.Пресс анжумания\n  2.Бегит борьба", $"  1.Борьба анжумания\n  2.Пресс бегит" };
int h = Convert.ToInt32(DateTime.Now.ToString("HH"));
int pos = 1;
ConsoleKeyInfo a;
while (true)
{
    Console.Clear();
    switch (h)
    {
        case 10:
            Console.WriteLine(data.ToShortDateString());
            Console.WriteLine(den[0]);
            a = Console.ReadKey();
            if (a.Key == ConsoleKey.UpArrow || a.Key == ConsoleKey.DownArrow)
            {

                Console.WriteLine(data.ToShortDateString());
                Console.WriteLine(den[0]);
                Console.SetCursorPosition(0, pos);
                Console.WriteLine("=>");
                do
                {
                    Console.Clear();
                    Console.WriteLine(data.ToShortDateString());
                    Console.WriteLine(den[0]);
                    Console.SetCursorPosition(0, pos);
                    Console.WriteLine("=>");
                    a = Console.ReadKey();
                    if (a.Key == ConsoleKey.UpArrow)
                    {
                        pos--;
                        if (pos == 0)
                        {
                            pos++;
                        }
                    }
                    if (a.Key == ConsoleKey.DownArrow)
                    {
                        pos++;
                        if (pos == 3)
                        {
                            pos--;
                        }
                    }
                    Console.Clear();
                    Console.WriteLine(data.ToShortDateString());
                    Console.WriteLine(den[0]);
                    Console.SetCursorPosition(0, pos);
                    Console.WriteLine("=>");
                } while (a.Key != ConsoleKey.Enter);
            }
            if (a.Key == ConsoleKey.RightArrow)
            {
                data.AddDays(1);
            }
            if (a.Key == ConsoleKey.LeftArrow)
            {
                data.AddDays(-1);
            }
            break;
        default:
            Console.Clear();
            Console.WriteLine(data.ToShortDateString());
            a = Console.ReadKey();
            if (a.Key == ConsoleKey.RightArrow)
            {
                h++;
            }
            if (a.Key == ConsoleKey.LeftArrow)
            {
                h--;
            }
            break;
    }
}
