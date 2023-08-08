using System;
namespace Arrays

{
    class Program
    {
        static void Main(string[] args)
        {
            Arrays();
            PerArray();
            ForEach();
            AltVal();
        }

        static void Arrays()
        {
            Console.Clear();
            
            var meuArray = new int [5] {23,42,54,67,99};
            //int [] meuArray = new int [5];
            meuArray[0] = 12;
            
            // Console.WriteLine(meuArray[0]);
            // Console.WriteLine(meuArray[1]);
            // Console.WriteLine(meuArray[2]);
            // Console.WriteLine(meuArray[3]);
            // Console.WriteLine(meuArray[4]);
        }

        static void PerArray()
        {
            var meuArray = new int [5] {1,2,3,4,5};
            meuArray[0] = 12;

            for(var index = 0; index < meuArray.Length; index++)
            {
                Console.WriteLine(meuArray[index]);
            }

            Console.WriteLine(meuArray[0]);
            Console.WriteLine(meuArray[1]);
            Console.WriteLine(meuArray[2]);
            Console.WriteLine(meuArray[3]);
            Console.WriteLine(meuArray[4]);
        }
    
        static void ForEach()
        {
            var meuArray = new int [5] {1,2,3,4,5};
            meuArray[0] = 12;

             foreach(var index in meuArray)
            {
                Console.WriteLine(index);
            }

            var funcionario = new Funcionario[5];

            //adicionando valores
            funcionario[0] = new Funcionario(){Id = 2579, Nome = "Olívio"};
            foreach(var funcionar in funcionario)
            {
                Console.WriteLine(funcionar.Id);
                Console.WriteLine(funcionar.Nome);
            }

           
        }

        public struct Funcionario
        {
            public int Id {get;set;}
            public string Nome {get;set;}
        }
    
        static void AltVal()
        {
            Console.Clear();

            // var array = new int[4];
            // var arrayb = array;  
            //array[0] = 23;
            //Console.WriteLine(array[0]); 


            var primeiro = new int [4];
            var segundo = new int [4];

            segundo[0] = primeiro[0];
            primeiro.CopyTo(segundo,0);

            primeiro[0] = 23;
            Console.WriteLine(segundo[0]);

        }
    }
}


