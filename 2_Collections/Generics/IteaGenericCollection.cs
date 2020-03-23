using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using static ITEA_Collections.Common.Extensions;

namespace ITEA_Collections.Generics
{
    public class IteaGenericCollection<T> : IEnumerable<T>, IBaseGenericCollectionUsing<T>
    {
        private T[] collection;
        //private int count = 0;

        #region constructors

        public IteaGenericCollection()
        {
            //collection = new T[128];
            collection = new T[] { };
        }

        #endregion

        #region IBaseGenericCollectionUsing
        public void Add(T ts)
        {
            //throw new NotImplementedException();
            //collection[count++] = ts;

            T[] temp = new T[collection.Length + 1];
            temp[temp.Length-1] = ts;
            collection = temp;
        }

        public void AddMany(T[] ts)
        {
            //throw new NotImplementedException();
            //foreach (T item in ts) Add(item);

            T[] temp = new T[collection.Length + ts.Length];
            ts.CopyTo(temp, collection.Length);
            collection = temp;
        }

        public void Clear()
        {
            //throw new NotImplementedException();
            //collection = new T[128];
            collection = new T[] { };
        }

        public T[] GetAll()
        {
            //throw new NotImplementedException();
            return collection;
        }

        public T GetByID(int index)
        {
            //throw new NotImplementedException();
            try
            {
                if (index < collection.Length)
                    return collection[index];
                else
                    throw new IndexOutOfRangeException();
            }
            catch (IndexOutOfRangeException)
            {
                ToConsole("IteaGenericCollection<T>/GetByID: IndexOutOfRangeException", ConsoleColor.Red);
                return default(T);
            }
        }

        public void RemoveByID(int index)
        {
            //throw new NotImplementedException();
            if (index < collection.Length)
            {
                /*List<T> temp = collection.ToList();
                temp.RemoveAt(index);
                collection = temp.ToArray();*/

                T[] temp = new T[collection.Length - 1];
                int j = -1;
                for (int i = 0; i < collection.Length; i++)
                {
                    if (i != index)
                    {
                        if (j < 0)
                        {
                            j++;
                        }
                        temp[j] = collection[i];
                    }
                    else
                        j--;
                    j++;
                }
                collection = temp;
            }
            else
                throw new IndexOutOfRangeException();
        }

        public void ShowAll()
        {
            //throw new NotImplementedException();
            collection.ToList().ForEach(ShowSingleElement);
        }

        private void ShowSingleElement(T item)
        {            
            ToConsole($"{item}", ConsoleColor.White);
        }
        #endregion

        #region IEnumerable

        public IEnumerator<T> GetEnumerator()
        {
            //throw new NotImplementedException();
            return new IteaGenericEnumerator<T>(collection);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            //throw new NotImplementedException();
            foreach (var item in collection)
            {
                if (item is int i)
                {
                    if (i % 2 == 0)
                        yield return item;
                }
                //if (item is string i)//if(item.GetType().Name == "String") string i = (string)item;                        
                //yield return i;
            }
        }
        #endregion
    }
}
