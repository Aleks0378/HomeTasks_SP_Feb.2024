using System;
using System.Runtime.InteropServices;
using static System.Net.Mime.MediaTypeNames;

namespace HomeTask_12._02._2024_Task_2
{
    internal class Program
    {
        [DllImport("user32.dll", CharSet = CharSet.Unicode, EntryPoint = "MessageBox")]
        public static extern int MyNewMessageBoxMethod(IntPtr hWnd, String text, String caption, uint type);
        static void Main(string[] args)
        {
            Random random = new Random();
            int a = 0;
            int rand = 0;
            for (int i = 0;a!=2;i++)
            {
                if (a == 0 || a == 1)
                {
                    a = MyNewMessageBoxMethod(new IntPtr(0), "Начнем игру.\nЗагадайте число от 1 до 100.", "Угадай число", 1);
                    i = 0;
                }
                if (a != 2)
                {
                    if  (a != 6)
                    {
                        rand = random.Next(0,100);
                        a = MyNewMessageBoxMethod(new IntPtr(0), $"Вы загадали число: {rand} ?", "Угадай число", 3);
                    }
                    else
                        a = MyNewMessageBoxMethod(new IntPtr(0), $"Чмсло угадано!\nЭто {rand}\nКолличество попыток: {i}.\n Хотите продолжить?", "Угадай число", 1);
                }
            }
            MyNewMessageBoxMethod(new IntPtr(0), "До встречи!", "Угадай число", 0);
        }
    }
}
