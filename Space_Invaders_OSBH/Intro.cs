using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Space_Invaders_OSBH
{
    internal static class Intro
    {
        public static void ShowIntro() {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n\n\n\n\n\n\n" +
                "\t╔══╗╔═══╗╔══╗╔══╗╔═══╗───╔══╗╔╗─╔╗╔╗╔╗╔══╗╔══╗─╔═══╗╔═══╗╔══╗\r\n" +
                "\t║╚═╗║╚═╝║║╚╝║║║──║╚══╗────║║─║╔╗─║║║║║║╚╝║║║╚╗║║╚══╗║╚═╝║║╚═╗\r\n" +
                "\t╚═╗║║╔══╝║╔╗║║║──║╔══╝────║║─║║╚╗║║╚╝║║╔╗║║║─║║║╔══╝║╔╗╔╝╚═╗║\r\n" +
                "\t╔═╝║║║───║║║║║╚═╗║╚══╗───╔╝╚╗║║─║║╚╗╔╝║║║║║╚═╝║║╚══╗║║║║─╔═╝║\r\n" +
                "\t╚══╝╚╝───╚╝╚╝╚══╝╚═══╝───╚══╝╚╝─╚╝─╚╝─╚╝╚╝╚═══╝╚═══╝╚╝╚╝─╚══╝\r\n");

            Console.WriteLine("\n\t\t\tOLD SCHOOL BULLET SHTORM");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine(
                "\n\n\t\t\t   Press any key");
            

        }

        public static void ShowGameOver()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n\n\n\n\n\n\n" +
                "\t╔══╗╔═══╗╔══╗╔══╗╔═══╗───╔══╗╔╗─╔╗╔╗╔╗╔══╗╔══╗─╔═══╗╔═══╗╔══╗\r\n" +
                "\t║╚═╗║╚═╝║║╚╝║║║──║╚══╗────║║─║╔╗─║║║║║║╚╝║║║╚╗║║╚══╗║╚═╝║║╚═╗\r\n" +
                "\t╚═╗║║╔══╝║╔╗║║║──║╔══╝────║║─║║╚╗║║╚╝║║╔╗║║║─║║║╔══╝║╔╗╔╝╚═╗║\r\n" +
                "\t╔═╝║║║───║║║║║╚═╗║╚══╗───╔╝╚╗║║─║║╚╗╔╝║║║║║╚═╝║║╚══╗║║║║─╔═╝║\r\n" +
                "\t╚══╝╚╝───╚╝╚╝╚══╝╚═══╝───╚══╝╚╝─╚╝─╚╝─╚╝╚╝╚═══╝╚═══╝╚╝╚╝─╚══╝\r\n");


            Console.ForegroundColor= ConsoleColor.Red;
            Console.WriteLine("\n\n\n" +
                "\t\t╔═══╗╔══╗╔╗──╔╗╔═══╗───╔══╗╔╗╔╗╔═══╗╔═══╗───╔╗\r\n" +
                "\t\t║╔══╝║╔╗║║║──║║║╔══╝───║╔╗║║║║║║╔══╝║╔═╗║───║║\r\n" +
                "\t\t║║╔═╗║╚╝║║╚╗╔╝║║╚══╗───║║║║║║║║║╚══╗║╚═╝║───║║\r\n" +
                "\t\t║║╚╗║║╔╗║║╔╗╔╗║║╔══╝───║║║║║╚╝║║╔══╝║╔╗╔╝───╚╝\r\n" +
                "\t\t║╚═╝║║║║║║║╚╝║║║╚══╗───║╚╝║╚╗╔╝║╚══╗║║║║────╔╗\r\n" +
                "\t\t╚═══╝╚╝╚╝╚╝──╚╝╚═══╝───╚══╝─╚╝─╚═══╝╚╝╚╝────╚╝");
            Console.ForegroundColor = ConsoleColor.White;

        }

        public static void ShowWin()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n\n\n\n\n\n\n" +
                "\t╔══╗╔═══╗╔══╗╔══╗╔═══╗───╔══╗╔╗─╔╗╔╗╔╗╔══╗╔══╗─╔═══╗╔═══╗╔══╗\r\n" +
                "\t║╚═╗║╚═╝║║╚╝║║║──║╚══╗────║║─║╔╗─║║║║║║╚╝║║║╚╗║║╚══╗║╚═╝║║╚═╗\r\n" +
                "\t╚═╗║║╔══╝║╔╗║║║──║╔══╝────║║─║║╚╗║║╚╝║║╔╗║║║─║║║╔══╝║╔╗╔╝╚═╗║\r\n" +
                "\t╔═╝║║║───║║║║║╚═╗║╚══╗───╔╝╚╗║║─║║╚╗╔╝║║║║║╚═╝║║╚══╗║║║║─╔═╝║\r\n" +
                "\t╚══╝╚╝───╚╝╚╝╚══╝╚═══╝───╚══╝╚╝─╚╝─╚╝─╚╝╚╝╚═══╝╚═══╝╚╝╚╝─╚══╝\r\n");


            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\n\n" +
                "\t\t\t╔╗╔╗╔══╗╔╗╔╗───╔╗╔╗╔╗╔══╗╔╗─╔╗───╔╗\r\n" +
                "\t\t\t║║║║║╔╗║║║║║───║║║║║║╚╗╔╝║╚═╝║───║║\r\n" +
                "\t\t\t║╚╝║║║║║║║║║───║║║║║║─║║─║╔╗─║───║║\r\n" +
                "\t\t\t╚═╗║║║║║║║║║───║║║║║║─║║─║║╚╗║───╚╝\r\n" +
                "\t\t\t─╔╝║║╚╝║║╚╝║───║╚╝╚╝║╔╝╚╗║║─║║───╔╗\r\n" +
                "\t\t\t─╚═╝╚══╝╚══╝───╚═╝╚═╝╚══╝╚╝─╚╝───╚╝");
            Console.ForegroundColor = ConsoleColor.White;

        }
    }
}





