using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Magic_8_ball
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://www.youtube.com/watch?v=DYF5jaoovhY&t=654s video, mille baasil sai programm tehtud.

            ConsoleColor oldcolor = Console.ForegroundColor; //salvestab vana konsooli värvi

            TellWhatProgramThisIs();

            //Loob suvalise objekti
            Random randomObject = new Random();
            //Console.WriteLine("{0}", randomObject.Next(10)+3); loob suvalise numberi 0-10 ja lisab sellele 3

            while (true)
            {
                string questionString = GetQuestion4User();


                if (questionString.Length == 0)
                {
                    Console.WriteLine("Te ei esitanud küsimust!!");
                    continue; //alustab otsast peale loopi
                }

                //kontrollib, kas kasutaja kirjutas lõpp
                if (questionString.ToLower() == "end")
                {
                    break;
                }

                //seda kirjutades lahkub programmist
                if (questionString.ToLower() == "sa oled kohutav")
                {
                    Console.WriteLine("Sa ise oled kohutav! Nägemist!");
                    break;
                }

                int randomNumber = randomObject.Next(5);

                //kasutab randoNumberit et vastus anda
                switch (randomNumber)
                {
                    case 0:
                        {
                            Console.WriteLine("JAH!");
                            break;
                        }
                    case 1:
                        {
                            Console.WriteLine("EI!");
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Mitte mingil juhul!");
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Kindlasti!");
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Ei oska öelda!");
                            break;
                        }
                }
            }

            Console.ForegroundColor = oldcolor; //muudab värvi tagasi vanaks värviks
            Console.WriteLine("Press any key to continiue...");
            Console.ReadLine();
        }

        //Prindib programmi nime
        static void TellWhatProgramThisIs()
        {
            Console.ForegroundColor = ConsoleColor.Blue; //muudab texti värvi
            Console.WriteLine("Magic 8 Ball");
        }


        static string GetQuestion4User()
        {
            //Antud blokk küsib küsmuse ja salvestab küsimuse
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Mis on Teie küsimus?: ");
            Console.ForegroundColor = ConsoleColor.Gray;
            string questionString = Console.ReadLine(); //Salvestab küsimuse

            return questionString;


        }
    }

}
