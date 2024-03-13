using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PD_24
{
    public class ConsoleInterface
    {
        public void UIrun()
        {
            string UserInput = "0";


            while (true)
            {
                Console.Clear();
                Console.WriteLine("" +
               "\nChoose the task:" +
               "\n=====================" +
               "\n[1] - pz2" +
               "\n[2] - pz3" +
               "\n[0] - exit" +
               "\n=====================" +
               "\n");
                UserInput = Convert.ToString(Console.ReadLine());
                switch (UserInput)
                {
                    case "1":
                        UIpz2 pz2 = new UIpz2();
                        pz2.UIrun();
                        Console.ReadKey();
                        continue;
                    case "2":
                        //UIpz3 pz3 = new UIpz3();
                        //pz3.UIrun();
                        Console.ReadKey();
                        continue;
                    case "0":
                        break;
                    default:
                        continue;

                }
            }
        }
    }
}
