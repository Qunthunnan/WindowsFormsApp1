using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            List<string> messages = new List<string>() { "Башкан Кирилл", "Junior dot net программист", "Без опыта работы" };
            int length = 0;
            for (int i = 0; i < messages.Count; i++)
            {
                length += messages[i].Length;
                if (i == messages.Count - 1)
                {
                    MessageBox.Show(messages[i] + "\n\nСреднее количество символов: " + length / messages.Count);
                }
                else
                {
                    MessageBox.Show(messages[i]);
                }
            }

            Application.Run(new Form1());
        }
    }
}
