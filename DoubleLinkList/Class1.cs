using System;
using System.Collections.Generic;
using System.Text;

namespace DoubleLinkList
{
    class Class1
    {
        public int age = 0;
        public string name = "Name: 0";
            public string country = "Country: 0";

        public override bool Equals(Object obj)
        {
            if (obj == null)
            return false;

            else
            {
                Class1 class1 = (Class1) obj;
                return (age == class1.age) && (name == class1.name) && (country == class1.country);
            }


        }


    }
}
