using System;
using System.Collections.Generic;

namespace POS
{

public class InventoryModel{



    public List<ItemModel> Items{get;set;} =new List<ItemModel>();

    public delegate void AlertCall(string msg);

    public string Message(AlertCall alertCall){

        string msg = $"{Items.ItemName}";
        alertCall(msg); // make sense for any changes made to var only! instead of return tuple or creating another var
        return msg;

    }





}



}