using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bars_Group_HW1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var key = new Key();
            key.OnKeyPressed += (Sender, ButtonKey) => Console.WriteLine(ButtonKey);

            key.Run();
        }

        internal class Key
        {
            public event EventHandler<char>? OnKeyPressed;
            public void Run()
            {
                char checkSymbol = Console.ReadKey().KeyChar;
                while ((char.ToUpper(checkSymbol) != 'C'))
                {
                    OnKeyPressed?.Invoke(this, checkSymbol);
                    checkSymbol = Console.ReadKey().KeyChar;
                }
            }
        }
    }
}