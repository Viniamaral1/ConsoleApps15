using System;

namespace ConsoleAppProject.App04
{
    internal class MainMenu
    {
        public static object AddMessage { get; private set; }
        public static object AddPhotoPost { get; private set; }

        public static object AddMessagePost { get; private set; }
        public static object ShowPost { get; private set; }

        internal static void Run()
        {

            string choice = Console.ReadLine();
            if (Double.TryParse(choice, out _))
            {

            }
        }
    }
}

