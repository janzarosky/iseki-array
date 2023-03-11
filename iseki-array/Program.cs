namespace iseki
{

    class program
    {
        static void Main(string[] args) 
        {

            Console.WriteLine(@"
  _   _    _    ____ _  _______ ____    _____   _    ____   ___  ____  _  ____   __  ____ _____  _    ____ _____ _____ ____  
 | | | |  / \  / ___| |/ / ____|  _ \  |__  /  / \  |  _ \ / _ \/ ___|| |/ /\ \ / / / ___|_   _|/ \  |  _ \_   _| ____|  _ \ 
 | |_| | / _ \| |   | ' /|  _| | |_) |   / /  / _ \ | |_) | | | \___ \| ' /  \ V /  \___ \ | | / _ \ | |_) || | |  _| | | | |
 |  _  |/ ___ \ |___| . \| |___|  _ <   / /_ / ___ \|  _ <| |_| |___) | . \   | |    ___) || |/ ___ \|  _ < | | | |___| |_| |
 |_| |_/_/   \_\____|_|\_\_____|_| \_\ /____/_/   \_\_| \_\\___/|____/|_|\_\  |_|   |____/ |_/_/   \_\_| \_\|_| |_____|____/ 
                                                                                                                             
");

            Thread.Sleep(3000);
            Console.Write(".");
            Thread.Sleep(1000);
            Console.Write(".");
            Thread.Sleep(1000);
            Console.Write(".");
            Thread.Sleep(1000);
            Console.WriteLine();

            Console.WriteLine("Vítej zpět,rád tě znovu vidím. ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Zde se nachází náhodně vygenovaných 10 čísel:");
            Console.WriteLine("(Powered by ZaroskyGenerator)");
            Console.WriteLine();
            Console.WriteLine();


            int[] pole = new int[10];
            Random rnd = new Random();
            
            for (int i = 0; i < pole.Length; i++)
            {
              pole[i] = rnd.Next(0, 19);
            }
            foreach (int i in pole)
            Console.WriteLine(i);

            Thread.Sleep(1000);
            Console.WriteLine("-------------");
            Thread.Sleep(2000);

            Console.WriteLine("Zde jou seřazeny čídla dle velikosti: ");

            Array.Sort(pole);
            for (int i = 0; i < pole.Length; i++)
            {
              Console.WriteLine(pole[i] + " ");
            }


            Thread.Sleep(1000);
            Console.WriteLine("-------------");
            Thread.Sleep(2000);
            
            
            int max = pole[0];
            for (int i = 1; i < pole.Length; i++)
            {
                if (pole[i] > max)
                {
                    max = pole[i];
                }
            }
            Console.WriteLine("Tadá největší číslo je: " + max);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Thread.Sleep(1000);
            Console.WriteLine("Díky za využívání našich služeb.");
            Thread.Sleep(500);
            Console.WriteLine("Hezký den.");


            Console.ReadKey();

        }
    }
}