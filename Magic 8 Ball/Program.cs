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

                //Paneb programmi pausile 5 sekundiks enne kui annab vastuse
                int numberOfSecondsToSleep = randomObject.Next(3) + 1;
                Console.WriteLine("Hmm..oodake korraks...");
                Thread.Sleep(numberOfSecondsToSleep * 1000); //*1000 annab sekundid, mitte millisek

                if (questionString.Length == 0)
                {
                    Console.WriteLine("Te ei esitanud küsimust!!");
                    continue; //alustab otsast peale loopi
                }

                //kontrollib, kas kasutaja kirjutas lõpp ning lahkub programmist, kui võrrand on tõene
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

                //Console.ForegroundColor = (ConsoleColor)randomNumber; //kõik 5 vastust erinevat värvi,arvuti valikul
                Console.ForegroundColor = (ConsoleColor)randomObject.Next(15); //igakord vastus erinevat värvi

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
            Console.ForegroundColor = ConsoleColor.Yellow; //muudab texti värvi
            Console.Write("Magic 8 Ball");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(" (Väljumiseks kirjutage: end) ");
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
