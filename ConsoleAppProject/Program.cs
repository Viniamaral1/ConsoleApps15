using ConsoleAppProject.App01;
using ConsoleAppProject.App02;
using ConsoleAppProject.App03;
using ConsoleAppProject.App04;
using ConsoleAppProject.Helpers;
using System;

namespace ConsoleAppProject
{
    /// <summary>
    /// The main method in this class is called first
    /// when the application is started.  It will be used
    /// to start App01 to App05 for CO453 CW1
    /// 
    /// This Project has been modified by:
    /// Derek Peacock 05/02/2022
    /// </summary>
    public static class Program


    {
        private static int cantryagain;

        public static void Main1(string[] args)
        {
            cantryagain = new int();

            DistanceConverter converter = new DistanceConverter();
            converter.Run();


            BMI app02 = new BMI();
            app02.Run();

            StudentGrades App03 = new StudentGrades();
            App03.RUN();


            NewsFeed app04 = new NewsFeed();
            NewsFeed.Run();



            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine();
            Console.WriteLine(" =================================================");
            Console.WriteLine("    BNU CO453 Applications Programming 2021-2022! ");
            Console.WriteLine("        by Derek                                  ");
            Console.WriteLine(" =================================================");
            Console.WriteLine();


            Console.WriteLine(" Pleaes informe the App you`d like to use");
            Console.WriteLine("        Distance converter (1)      ");
            Console.WriteLine("          BMI calculator   (2)      ");
            Console.WriteLine("          Student Grades   (3)      ");
            Console.WriteLine("          Social News Feed (4)     " );

            string choice = Console.ReadLine();
            if (Double.TryParse(choice, out _))
            {
                double option = Convert.ToDouble(choice);
                if (option == 1)
                {
                    converter.Run();
                }
                else if (option == 2)
                {
                    app02.Run();
                }
                else if (option == 3)
                {
                    App03.RUN();
                }
                else if (option == 4)
                {

                    NewsFeed.Run();
                }
                else
                {
                    Console.WriteLine("Incorrect option, please try again");
                    Tryagain();
                }










            }
        }

        private static void Tryagain()
        {
            //Tryagain.Run();
        }


    }
}
