using System.Runtime.InteropServices;

namespace HomeTasks_SP_Feb._2024
{
    internal class Program
    {
        [DllImport("user32.dll", CharSet = CharSet.Unicode, EntryPoint = "MessageBox")]
        public static extern int MyNewMessageBoxMethod(IntPtr hWnd, String text, String caption, uint type);

        static void Main()
        {
            string[] str = { "Name: Ivan", "Second Name: Ivanovich", "Position: Ingeneer", "Work place: Dasp Company" };
            int a=0;
            int symb = 0;
            for(int i=0; a!=2;i++)
            {
                if (i == str.Length - 1)
                {
                    MyNewMessageBoxMethod(new IntPtr(0), $" AVG Symbol Quantity per Sheet: {symb/(i+1)}", "Mr Ivanov", 1);
                }
                else 
                    a=MyNewMessageBoxMethod(new IntPtr(0), str[i], "Mr Ivanov", 1);
                symb += str[i].Length;
            }
        }
    }
}
