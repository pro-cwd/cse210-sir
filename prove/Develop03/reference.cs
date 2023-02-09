public class Reference
{


    public int _numberElect;
    Scripture john = new Scripture();

    public void References()
    {
    if (_numberElect == 1) 
        {   
            john.John1();
            Console.Write("\nShow verses from: ");
            string vrs = Console.ReadLine();
            int verse = int.Parse(vrs);
            john._verse = verse;
            
            Console.Write("to: ");
            string vrs2 = Console.ReadLine();
            int verse2 = int.Parse(vrs2);
            john._verse2 = verse2;
        }
        else if (_numberElect == 2)
            {
                john.John2();
                Console.Write("\nShow verses from: ");
                string vrs3 = Console.ReadLine();
                int verse4 = int.Parse(vrs3);
                john._verse = verse4;

                Console.Write("to: ");
                string vrs5 = Console.ReadLine();
                int verse6 = int.Parse(vrs5);
                john._verse2 = verse6;

            } else if (_numberElect == 3)
                {
                    john.John3();
                    Console.Write("\nShow verses from: ");
                    string vrs7 = Console.ReadLine();
                    int verse8 = int.Parse(vrs7);
                    john._verse = verse8;

                    Console.Write("to: ");
                    string vrs9 = Console.ReadLine();
                    int verse0 = int.Parse(vrs9);
                    john._verse2 = verse0;
                }
    else
        {
            Console.WriteLine("Please introduce the corret requirement");
        }
        // return chapter;
    }

}