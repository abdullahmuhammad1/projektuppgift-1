using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random slump = new Random();

            Console.WriteLine("välj en av valen nedan");

            string menyval = "0";
            while (menyval != "3")
            {
                //menyn 
                Console.WriteLine("1. spela igen");
                Console.WriteLine("2. spelets regler");
                Console.WriteLine("3. avsluta programmet");
                menyval = Console.ReadLine();
                switch (menyval)
                {
                    //koden för att spela spelet
                   
                    case "1":
                        int datornstal = slump.Next(1, 11);
                        int gissning = 0;
                        Console.WriteLine("du ska nu gissa på talet datorn slumpade");
                        //vad användaren gissar 
                        
                        //om användarens tal är för högt eller för lågt
                        while (gissning != datornstal)
                        {
                            gissning = int.Parse(Console.ReadLine());

                            if (gissning < datornstal)
                            {
                                Console.WriteLine($"du gissade på {gissning}");
                                Console.WriteLine($"talet {gissning} var för litet");
                            }
                                
                               
                            if (gissning > datornstal)
                            {
                                Console.WriteLine($"du gissade på {gissning}");
                                Console.WriteLine($"talet {gissning} var för stort");
                            }
                                
                        }

                        Console.WriteLine("du gissade rätt");
                        break;
                    case "2":
                        Console.WriteLine("det här är gissa talet");
                        Console.WriteLine("datorn slumpar ett tal mellan 1-10 och du ska gissa på det");
                        Console.WriteLine("det säger om du gissat för högt eller lågt");
                        Console.WriteLine("om du gissar rätt vinner du");
                        break;
                    case "3":
                        break;

                    default:
                        Console.WriteLine("Fel menyval!");
                        break;
                }
                
            }





        }
    }
}
