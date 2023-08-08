using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //OcorrendoException();
            //TryCatch();
            //TratandoException();
            //DisparandoException();
            //CustomException();
            //Finally();
        }

        static void OcorrendoException()
        {
             Console.Clear();
             var array = new int [3];

            for (var index = 0; index < 10; index++)
            {
                //System.IndexOutOfRangeException 
                Console.WriteLine(array[index]);
            }
        }

        static void TryCatch()
        {
            Console.Clear();
            var array = new int [3];

            try
            {
                for (var index = 0; index < 10; index++)
                {
                //System.IndexOutOfRangeException 
                Console.WriteLine(array[index]);
                }
            } 
                catch(Exception ex)
                {
                    //mostra o erro 
                    Console.WriteLine(ex.InnerException);
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Algo deu errado");
                }
           
        }

        static void TratandoException()
        {
            Console.Clear();
            var array = new int [3];

            try
            {
                for (var index = 0; index < 10; index++)
                {
                //System.IndexOutOfRangeException 
                Console.WriteLine(array[index]);
                }
            } 
        
                catch(System.IndexOutOfRangeException ex)
                {
                    Console.WriteLine(ex.InnerException);
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Não encontrei o índice na lista");
                }
                
                catch(Exception ex)
                {
                    Console.WriteLine(ex.InnerException);
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Algo deu errado");
                }
        }

        static void DisparandoException()
        {
             Console.Clear();
            var array = new int [3];

            try
            {
                // for (var index = 0; index < 10; index++)
                // {
                // //System.IndexOutOfRangeException 
                // Console.WriteLine(array[index]);
                // }

                Cadastrar("");
            } 
                catch(System.IndexOutOfRangeException ex)
                {
                    Console.WriteLine(ex.InnerException);
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Não encontrei o índice na lista");
                }
                
                catch(ArgumentNullException ex)
                {

                    Console.WriteLine(ex.InnerException);
                    Console.WriteLine(ex.Message);

                    Console.WriteLine("Falha ao cadastrar o texto");
                }
                catch(Exception ex)
                {

                    Console.WriteLine(ex.InnerException);
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Algo deu errado");
                }
        }
    
        static void CustomException()
        {
             Console.Clear();
            var array = new int [3];

            try
            {
                // for (var index = 0; index < 10; index++)
                // {
                // //System.IndexOutOfRangeException 
                // Console.WriteLine(array[index]);
                // }

                Cadastrar("");
            } 

                catch(System.IndexOutOfRangeException ex)
                {
                    Console.WriteLine(ex.InnerException);
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Não encontrei o índice na lista");
                }
                
                catch(ArgumentNullException ex)
                {
                    Console.WriteLine(ex.InnerException);
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Falha ao cadastrar o texto");
                }

                catch(MinhaException ex)
                {
                    Console.WriteLine(ex.InnerException);
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.QuandoAconteceu);
                    Console.WriteLine("Excessão customizada");
                }

                catch(Exception ex)
                {
                    Console.WriteLine(ex.InnerException);
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Algo deu errado");
                }
        }

        static void Finally()
        {
            Console.Clear();
            var array = new int [3];

            try
            {
                // for (var index = 0; index < 10; index++)
                // {
                // //System.IndexOutOfRangeException 
                // Console.WriteLine(array[index]);
                // }

                Cadastrar("ithbjhfrdazx");
            } 
                catch(System.IndexOutOfRangeException ex)
                {
                    Console.WriteLine(ex.InnerException);
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Não encontrei o índice na lista");
                }
                
                catch(ArgumentNullException ex)
                {
                    Console.WriteLine(ex.InnerException);
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Falha ao cadastrar o texto");
                }

                catch(MinhaException ex)
                {
                    Console.WriteLine(ex.InnerException);
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.QuandoAconteceu);

                    //exibindo uma mensagem de erro
                    Console.WriteLine("Excessão customizada");
                }

                catch(Exception ex)
                {
                    Console.WriteLine(ex.InnerException);
                    Console.WriteLine(ex.Message);

                    Console.WriteLine("Algo deu errado");
                }
                finally
                {
                    Console.WriteLine("Chegou ao fim");
                }
        }

        private static void Cadastrar(string texto)
        {
            if(string.IsNullOrEmpty(texto))
            throw new MinhaException(DateTime.Now);
        }
    
        public class MinhaException : Exception
        {
            public MinhaException(DateTime date)
            {
                QuandoAconteceu = date;
            }
            public DateTime QuandoAconteceu{get;set;}
        }
    }
}