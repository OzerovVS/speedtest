int pos = 0;
int sop = 0;
string b = "Прямоугольник";
char[] bb = b.ToCharArray();
List<Char> a = new List<Char> ();
for (int i = 0; i < a.Count; i++)
{
    a[i] = bb[i];
}
for (int i = 0; i < a.Count; i++)
{
    Console.Write(a[i]);
}
ConsoleKeyInfo aa;
do
{
    aa = Console.ReadKey();
    if (aa.Key == ConsoleKey.RightArrow)
    {
        sop++;
    }
    if (aa.Key == ConsoleKey.LeftArrow)
    {
        sop--;
    }
    if (aa.Key == ConsoleKey.UpArrow)
    {
        pos--;
    }
    if (aa.Key == ConsoleKey.DownArrow)
    {
        pos++;
    }
    Console.Clear();
    Console.SetCursorPosition(sop, pos);
    for (int i = 0; i < a.Count; i++)
    {
        Console.Write(a[i]);
    }
} while (true);