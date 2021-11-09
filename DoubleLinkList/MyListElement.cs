using System;
using System.Collections.Generic;
using System.Text;

namespace DoubleLinkList
{
    public class MyListElement<T>
    {
        public MyListElement<T> pastElement;
        public MyListElement<T> nextElement;
        public T data;

        public MyListElement(T data)
        {
            this.data = data;
        }



    }
}
