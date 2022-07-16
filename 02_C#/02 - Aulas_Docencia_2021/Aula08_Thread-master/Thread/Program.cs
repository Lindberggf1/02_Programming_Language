using System;

namespace Thread
{
    class Program
    {
        static void Main(string[] args)
        {
            Tarefa();

            for (int i = 0; i< 10; i++)
            {
                Console.WriteLine("Principal");
            }
        }

        static void Tarefa()
        {
            for (int i = 0; i<10; i++)
            {
                Console.WriteLine("Tarefa Secundaria");
            }
        }
    }
}
