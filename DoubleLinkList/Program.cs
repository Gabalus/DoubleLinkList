using System;
using System.Collections.Generic;
using System.Linq;

namespace DoubleLinkList
{
    class Program
    {
        static void Main(string[] args)
        { 


            MyList<Class1> myList1 = new MyList<Class1>();
            
            for (int i = 0; i < 50; i++)
            {
                var temp = new Class1(); 
               
                
                temp.age = i;
                temp.country = $"Country: {i}";
                temp.name = $"Name: {i}";
                myList1.Add(temp);
            }

            myList1.Delete(new Class1()
            {
                age = 10,
                country = "Country: 10",
                name = "Name: 10",
            });
            int a = 2;


        }
    }
}
