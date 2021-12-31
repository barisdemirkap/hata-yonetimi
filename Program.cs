using System ;
namespace hata_yonetimi 
{
    class Program 
    {
        static void Main (string[] args)
        {
            try
            {
            Console.WriteLine("give me a number") ;
            int number1 = Convert.ToInt32(Console.ReadLine) ;
            Console.WriteLine("you enter the number of :" + number1) ;

            
            }
            catch(Exception ex)
            {
            Console.WriteLine("Hata:" + ex.Message.ToString()) ;
            }      
            finally
            {
                Console.WriteLine("islem tamamlandi") ;
            }      
            
            Console.WriteLine("give me a number") ;

            try 
            {
                int a = int.Parse(null) ;
            
            }
            catch(ArgumentNullException ex)
            {
                Console.WriteLine("Bos deger girdiniz") ;
                Console.WriteLine(ex) ;
            }
            try 
            {
                int b = int.Parse("test") ;
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Veri tipi uygun degil") ;
                Console.WriteLine(ex) ;
            }
            try
            {
                   int c = int.Parse("-20000000000") ;

            }
             catch(OverflowException ex)
            {
                Console.WriteLine("Cok kucuk ya da cok buyuk bir deger giridiniz.") ;
                Console.WriteLine(ex) ;
            }
            finally 
            {
                Console.WriteLine("islem basari ile tamamlandi");
            }




        }


    }
}