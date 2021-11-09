using System;
using System.Collections.Generic;
using System.Text;

namespace DoubleLinkList
{
   public class MyList<T>
    {
        private MyListElement<T> firstElement;
        private MyListElement<T> lastElement;
        private int count;

        //public int this[int index]
        //{
        //    get
        //    {
        //        return [index];
        //    }

        //    set
        //    {
        //        temps[index] = value;
        //    }

        public void Add(T data)
        {
            MyListElement<T> node = new MyListElement<T>(data);
            if (firstElement == null)

                firstElement = node;

            else
            { 
                lastElement.nextElement = node;
                node.pastElement = lastElement;




            }
            lastElement = node;
            count++;

        }
        public void Add(T data, int index)
        {
            if (!(index > 0 || index < count + 1))
            
                throw new Exception("Неправильно");

            MyListElement<T> node = new MyListElement<T>(data);

            if (index == 0 || index == count + 1)
            
                Add(data);

            else
            {
                var temp = firstElement;
                for (int i = 1; i < index; i++)
                {
                    temp = temp.nextElement;

                }
                node.pastElement = temp;
                node.nextElement = temp.nextElement;
                temp.nextElement.pastElement = node;
                temp.nextElement = node;
                count++;
            }

          


            //delete(index), перебор foreach'ом, класс(3 поля) 
            
                    
            






        }

        public void Delete(int index)
        {
            if (!(index > 0 || index < count + 1))

                throw new Exception("Неправильно");

            if (index == count)
            {

                lastElement.pastElement = lastElement;
                lastElement.pastElement.nextElement = lastElement;

                count--;


            }

            else
            {
                var temp = firstElement;
                for (int i = 1; i < index; i++)
                {
                    temp = temp.nextElement;
                }
                temp.pastElement.nextElement = temp.nextElement;
                temp.nextElement.pastElement = temp.pastElement;
                count--;
            }
        }

        public void Delete(T data)
        {
            
            var temp = firstElement;
            
            for (int i = 1; i < count; i++)
            {
               
                if (data.Equals(temp.data))
                {
                    int index = i;
                    Delete(index);
                }
                temp = temp.nextElement;
            }
        }

        public void Clear()
        {
            var temp = lastElement;
            for (int i = count; i > 1; i--)
            {
                temp = temp.pastElement;
                temp = null;
            }
            lastElement = null;
            count = 0;
        }
        
        public void AddRange(MyList<T> collection, int index)
        {
            
            if (!(index > 0 || index < count + 1))

                throw new Exception("Неправильно");


            if (collection != null)
            {


                if (firstElement == null)
                {
                    firstElement = collection.firstElement;
                }





                else if (index == 0)
                {




                    firstElement.pastElement = collection.lastElement;
                    collection.lastElement.nextElement = firstElement;
                    firstElement = collection.firstElement;




                }
                else if (index == count + 1)
                {
                    lastElement.nextElement = collection.firstElement;
                    collection.firstElement = lastElement;
                    lastElement = collection.lastElement;



                }


                else
                {
                    var temp = firstElement;
                    for (int i = 1; i < index; i++)
                    {
                        temp = temp.nextElement;
                    }
                    
                    collection.firstElement.pastElement = temp;
                    collection.lastElement.nextElement = temp.nextElement;
                    temp.nextElement.pastElement = collection.lastElement;
                        temp.nextElement = collection.firstElement;
                   
                }
            }
            }

    }

    }

