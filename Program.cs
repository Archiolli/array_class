using System;


namespace Array_Class
{
    class program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("How many rooms will be rented? ");
            int n = int.Parse(Console.ReadLine());
            Students[] vect = new Students[10];

            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine("Rent #" + i);
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());
                Console.WriteLine();
                vect[room] = new Students(name, email); 
            }
            Console.WriteLine();
            Console.WriteLine("-------------------------");
            Console.WriteLine("Busy rooms: ");
            Console.WriteLine("-------------------------");
            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                
                if (vect[i] != null)
                {
                    
                    Console.WriteLine(i + ": " + vect[i]);
                    Console.WriteLine();

                }



            }    





        }
    }
}
