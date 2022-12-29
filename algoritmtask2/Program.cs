namespace algoritmtask2;
class Program
{
    static void Main(string[] args)
    {
        /*task1
        Console.WriteLine("eded daxil et");
        
        int a = int.Parse(Console.ReadLine());
      

        if (a>=1 && a<=1188)
        {
            int years = a / 12;
            int months = a % 12;

            // Console.WriteLine($"{years} y,{months} m");
            Console.WriteLine($"Daxil edilmis {a} ayda {years} il ve {months} ay var");
            
        }

        else
        {
            Console.WriteLine("verilmis araliqda daxil et");
        }
        */

        Console.WriteLine("eded daxil et");
        int a = int.Parse(Console.ReadLine());
        int count = 0;

        if (a>9)
        {
            for (int i = 0; i < a; i++)
            {
                int reqem = a % 10;
                if (reqem == 0)
                {
                    count++;
                }

                a /= 10;

            }

                Console.WriteLine(count);

        }

        else
        {
            Console.WriteLine("duzgun daxil et");
        }



        Console.ReadLine();
    }
}

