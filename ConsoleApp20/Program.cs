using System.Runtime.InteropServices;

namespace ConsoleApp20
{
    class Program
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int MessageBox(IntPtr hWnd, string text, string caption, uint type);

        static void Main(string[] args)
        {
            string name = "Ім'я: Вікторія";
            string surname = "Прізвище: Бучко";
            string age = "Вік: 19";
            string hobby = "Хоббі: Програмування";

            MessageBox(IntPtr.Zero, name, "Інформація", 0);
            MessageBox(IntPtr.Zero, surname, "Інформація", 0);
            MessageBox(IntPtr.Zero, age, "Інформація", 0);
            MessageBox(IntPtr.Zero, hobby, "Інформація", 0);
        }
    }
}
