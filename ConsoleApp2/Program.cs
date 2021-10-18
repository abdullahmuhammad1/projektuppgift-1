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
            while (menyval != "4")
            {
                //menyn 
                Console.WriteLine("1. spela igen");
                Console.WriteLine("2. visa senaste vinnaren");
                Console.WriteLine("3. spelets regler");
                Console.WriteLine("4. avsluta programmet");
                menyval = Console.ReadLine();
                switch (menyval)
                {
                    //koden för att spela spelet
                    case "1":
                        int datornstal = slump.Next(1, 10);
                        int gissning = 0;
                        Console.WriteLine("du ska nu gissa på talet datorn slumpade");
                        //vad användaren gissar 
                        gissning = int.Parse(Console.ReadLine());
                        //om användarens tal är för högt eller för lågt
                        while (gissning) ;
                        {
                            Console.WriteLine($"du gissade på {gissning}");
                            Console.WriteLine($"talet {gissning} var för lågt");
                        }
                        
                        

                }
            }





        }
    }
}
