using System;


namespace Understanding_CSharp
{


    public sealed class SingleCheese{
       private SingleCheese(){}
    private static readonly Lazy<SingleCheese> lazy = new Lazy<SingleCheese>(() => new SingleCheese()); // safe for multi tread
    public static SingleCheese Instance{
        get{
            return lazy.Value;
        }
    }




    }    


    public class MultiCheese{
        public MultiCheese(){

        }

        
    }



    class Program
    {
        static void Main(string[] args)
        {
            SingleCheese cheese1 = SingleCheese.Instance; // 
            SingleCheese cheese2 = SingleCheese.Instance; // 
            MultiCheese mc = new MultiCheese();
            MultiCheese mc1 = new MultiCheese();
            
            if(cheese1 == cheese2){
                Console.WriteLine("Both cheese1 and cheese2 are one Instance! this is how Singleton");
            }
            if(mc==mc1){
                Console.WriteLine("this text should not  load as instance are different");

            }
              if(mc!=mc1){
                Console.WriteLine("this text should load has both object have different instance");

            }

            Console.WriteLine("Hello World!");
        }
    }
}
