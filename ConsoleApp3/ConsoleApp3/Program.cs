using System;

class SS
{
    static void usage()
    {
        string menu = "Choosing from octaves: \n" +
                      "Tab - 1 octave\n" +
                      "F2  - 2 octave\n" +
                      "F3  - 3 octave\n";
        Console.WriteLine(menu);
    }

    static void pl1_m1(int[] pa)
    {
        Console.Beep(pa[0], 120);
    }
    static void pl1_m2(int[] pa)
    {
        Console.Beep(pa[1], 110);
    }
    static void pl1_m3(int[] pa)
    {
        Console.Beep(pa[2], 100);
    }
    static void pl1_m4(int[] pa)
    {
        Console.Beep(pa[3], 145);
    }
    static void pl1_m5(int[] pa)
    {
        Console.Beep(pa[4], 234);
    }
    static void pl1_m6(int[] pa)
    {
        Console.Beep(pa[5], 623);
    }
    static void pl1_m7(int[] pa)
    {
        Console.Beep(pa[6], 134);
    }
    static void pl1_m8(int[] pa)
    {
        Console.Beep(pa[7], 88);
    } // end of beeps in 1-st octave

    // begin of beeps in 2-st octave
    static void pl2_m1(int[] pa2)
    {
        Console.Beep(pa2[0], 150);
    }
    static void pl2_m2(int[] pa2)
    {
        Console.Beep(pa2[1], 133);
    }
    static void pl2_m3(int[] pa2)
    {
        Console.Beep(pa2[2], 500);
    }
    static void pl2_m4(int[] pa2)
    {
        Console.Beep(pa2[3], 453);
    }
    static void pl2_m5(int[] pa2)
    {
        Console.Beep(pa2[4], 943);
    }
    static void pl2_m6(int[] pa2)
    {
        Console.Beep(pa2[5], 233);
    }
    static void pl2_m7(int[] pa2)
    {
        Console.Beep(pa2[6], 167);
    }
    static void pl2_m8(int[] pa2)
    {
        Console.Beep(pa2[7], 436);
    }

    static void Play_main_1(int[] play_arr) //1-st octave
    {
        ConsoleKeyInfo play_key;
        Console.Write("You are on 1-st octave, play something >>> ");
        do
        {
            play_key = Console.ReadKey();
            if (play_key.Key == ConsoleKey.Q)
            {
                pl1_m1(play_arr);
                Console.Clear();
                break;
            }
            else if (play_key.Key == ConsoleKey.W)
            {
                pl1_m2(play_arr);
                Console.Clear();
                break;
            }
            else if (play_key.Key == ConsoleKey.E)
            {
                pl1_m3(play_arr);
                Console.Clear();
                break;
            }
            else if (play_key.Key == ConsoleKey.R)
            {
                pl1_m4(play_arr);
                Console.Clear();
                break;
            }
            else if (play_key.Key == ConsoleKey.T)
            {
                pl1_m5(play_arr);
                Console.Clear();
                break;
            }
            else if (play_key.Key == ConsoleKey.Y)
            {
                pl1_m6(play_arr);
                Console.Clear();
                break;
            }
            else if (play_key.Key == ConsoleKey.U)
            {
                pl1_m7(play_arr);
                Console.Clear();
                break;
            }
            else if (play_key.Key == ConsoleKey.I)
            {
                pl1_m8(play_arr);
                Console.Clear();
                break;
            }
            else if (play_key.Key != ConsoleKey.Escape)
            {
                break;
            }
        } while (play_key.Key != ConsoleKey.Escape);
    }
    // e of methods to Method: Play1 -- octave 1;;;;
    // begin of methonds to Method: Play 2 -- octave 2;;;;
    static void Play_main_2(int[] sec_pl_arr)
    {
        ConsoleKeyInfo play_key_2;
        Console.Write("You are on 2-nd octave, play something >>> ");
        do
        {
            play_key_2 = Console.ReadKey();
            if (play_key_2.Key == ConsoleKey.A)
            {
                pl2_m1(sec_pl_arr);
                Console.Clear();
                break;
            }
            else if (play_key_2.Key == ConsoleKey.S)
            {
                pl2_m2(sec_pl_arr);
                Console.Clear();
                break;
            }
            else if (play_key_2.Key == ConsoleKey.D)
            {
                pl2_m3(sec_pl_arr);
                Console.Clear();
                break;
            }
            else if (play_key_2.Key == ConsoleKey.F)
            {
                pl2_m4(sec_pl_arr);
                Console.Clear();
                break;
            }
            else if (play_key_2.Key == ConsoleKey.G)
            {
                pl2_m5(sec_pl_arr);
                Console.Clear();
                break;
            }
            else if (play_key_2.Key == ConsoleKey.H)
            {
                pl2_m6(sec_pl_arr);
                Console.Clear();
                break;
            }
            else if (play_key_2.Key == ConsoleKey.J)
            {
                pl2_m7(sec_pl_arr);
                Console.Clear();
                break;
            }
            else if (play_key_2.Key == ConsoleKey.K)
            {
                pl2_m8(sec_pl_arr);
                Console.Clear();
                break;
            }
        } while (play_key_2.Key != ConsoleKey.Escape);
    }
    static void Main()
    {

        int[] oct1 = new int[] { 659, 462, 534, 699, 744, 233, 345, 888 };
        int[] oct2 = new int[] { 133, 455, 723, 560, 302, 231, 794, 123 };
        ConsoleKeyInfo main_key;
        usage();
        main_key = Console.ReadKey();
        while (main_key.Key != ConsoleKey.Escape)
        {
            if (main_key.Key == ConsoleKey.Tab)
            {
                Play_main_1(oct1);
            }
            if (main_key.Key == ConsoleKey.F2)
            {
                Play_main_2(oct2);
            }
        }

    }
}
