using System;
using System.Collections.Generic;

using static ITEA_Collections.Common.Extensions;
using ITEA_Collections.Common;

namespace ITEA_Collections.Usings
{
    internal class GenericListUsing : IBaseCollectionUsing
    {
        public List<string> List { get; set; }

        public GenericListUsing()
        {
            List = new List<string>();
        }

        public void Add(object ts)
        {
            if (ts is null)
                throw new Exception("Value is NULL!");
            else
                List.Add(ts.ToString());
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
            List.Clear();
        }

        public object[] GetAll()
        {
            //throw new NotImplementedException();
            return List.ToArray();
        }

        public object GetByID(int index)
        {
            //throw new NotImplementedException();
            try
            {
                return List[index];
            }
            catch (Exception)
            {
                ToConsole($"No element with index: {index}", ConsoleColor.Red);
                return null;
            }
        }

        public void RemoveByID(int index)
        {
            try
            {
                List.RemoveAt(index);
                ToConsole($"Successfully removed #{index}", ConsoleColor.DarkYellow);
            }
            catch (ArgumentOutOfRangeException)
            {
                ToConsole($"No element with index: {index}", ConsoleColor.Red);
            }
        }

        public void ShowAll()
        {
            for (int i = 0; i < this.List.Count; i++)
            {
                ToConsole($"index i: {this.List[i]}", ConsoleColor.Cyan);
            }
        }

    }
}
