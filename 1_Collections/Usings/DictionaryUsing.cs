using System;
using System.Collections.Generic;
using System.Linq;
using ITEA_Collections.Common;

using static ITEA_Collections.Common.Extensions;

namespace ITEA_Collections.Usings
{
    public class DictionaryUsing : IBaseCollectionUsing
    {
        public Dictionary<int, string> Dictionary { get; set; }

        public DictionaryUsing()
        {
            Dictionary = new Dictionary<int, string>();
        }

        /// <summary>
        /// Получение максимального значение ключа в словаре
        /// </summary>
        private int GetMaxElement
        {
            get
            {
                return Dictionary.Count == 0 ? 0 : Dictionary.Keys.Max();
            }
        }

        public void Add(object ts)
        {
            //throw new NotImplementedException();
            if (ts is null)
                throw new Exception("Value is NULL!");
            else
                Dictionary.Add(GetMaxElement + 1, ts.ToString());
        }

        public void AddMany(object[] ts)
        {
            //throw new NotImplementedException();
            if (ts is null)
                ToConsole($"Array is null!", ConsoleColor.Red);
            else
            {
                for (int i = 0; i < ts.Length; i++)
                {
                    Add(ts[i]);
                }
            }
        }

        public void Clear()
        {
            //throw new NotImplementedException();
            Dictionary.Clear();
        }

        public object[] GetAll()
        {
            //throw new NotImplementedException();
            return Dictionary.Values.ToArray();
        }

        public object GetByID(int index)
        {
            //throw new NotImplementedException();
            try
            {
                int key = GetKeyByIndex(index);
                if (key == -1)
                    throw new ArgumentOutOfRangeException();
                else
                {
                    return Dictionary[key];
                }
            }
            catch (Exception)
            {
                ToConsole($"No element with index: {index}", ConsoleColor.Red);
                return null;
            }
        }

        /// <summary>
        /// Вычисление ключа из заданного индекса
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        private int GetKeyByIndex(int index)
        {
            int i = 0;
            foreach (var val in Dictionary)
            {
                if (index == i)
                {
                    return val.Key;
                }
                i++;
            }
            return -1;
        }

        public void RemoveByID(int index)
        {
            //throw new NotImplementedException();
            try
            {
                int key = GetKeyByIndex(index);
                if (key == -1)
                    throw new ArgumentOutOfRangeException();
                else
                {
                    Dictionary.Remove(key);
                    ToConsole($"Successfully removed #{index}", ConsoleColor.DarkYellow);
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                ToConsole($"No element with index: {index}", ConsoleColor.Red);
            }
        }

        public void ShowAll()
        {
            //throw new NotImplementedException();
            foreach (var item in Dictionary)
                ToConsole($"{item.Key}: {item.Value}, type - {item.GetType().Name}", ConsoleColor.Cyan);
        }

    }
}
