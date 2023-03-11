using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    public class CloseApp
    {
        public void CloseApplication()
        {
            Console.Write(Menu.ASK_TO_EXIT);
            string exit = Console.ReadLine();

            if (exit == "y")
            {
                Console.Write(Menu.GOODBAY);
                Thread.Sleep(1500);
                Environment.Exit(0);
            }

        }

    }
}
