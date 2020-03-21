using System;
using System.Collections;
using System.Collections.Generic;
using static ITEA_Collections.Common.Extensions;

namespace ITEA_Collections.Generics
{
    public class IteaGenericEnumerator<T> : IEnumerator<T>
    {
        private T[] _collection;
        private int _currentIndex = -1;

        #region constructors
        protected IteaGenericEnumerator() { }

        public IteaGenericEnumerator(T[] collection)
        {
            _collection = collection;
        }
        #endregion

        #region IEnumerator
        //public T Current => throw new NotImplementedException();
        public T Current
        {
            get
            {
                try
                {
                    return _collection[_currentIndex];
                }
                catch (IndexOutOfRangeException)
                {
                    ToConsole("IteaGenericEnumerator<T>: IndexOutOfRangeException", ConsoleColor.Red);
                    return default(T);
                }
            }
        }

        //object IEnumerator.Current => throw new NotImplementedException();
        object IEnumerator.Current
        {
            get
            {
                try
                {
                    return _collection[_currentIndex];
                }
                catch (IndexOutOfRangeException)
                {
                    ToConsole("IteaGenericEnumerator<T>: IndexOutOfRangeException", ConsoleColor.Red);
                    return default(T);
                }
            }
        }


        public void Dispose()
        {
            //throw new NotImplementedException();
            _collection = null;
        }

        public bool MoveNext()
        {
            //throw new NotImplementedException();
            _currentIndex++;
            return _currentIndex < _collection.Length && _collection[_currentIndex] != null;
        }

        public void Reset()
        {
            //throw new NotImplementedException();
            _currentIndex = -1;
        }
        #endregion
    }
}
