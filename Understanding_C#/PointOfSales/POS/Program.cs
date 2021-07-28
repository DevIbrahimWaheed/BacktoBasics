using System;
using System.Collections.Generic;

namespace POS
{
    class Program
    {
       static InventoryModel obj = new InventoryModel();
        static void Main(string[] args)
        {   AddMockItems()
            string msg = obj.Message(Alert);
            Console.WriteLine($"Hello World! {msg}");
        }

        private static void Alert(string msg){
            Console.WriteLine("Alert string");

        }
        static void AddMockItems(){
            obj.Items.Add(new ItemModel {itemName ="test1",price = 3.99M});
        }

    }
}
