using ITEA_Collections.Base;

namespace ITEA_Collections
{
    public class Person : IPerson
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public int Q { get; set; }

        //public override string ToString()
        //{
        //    return $"{Name}: {Age}";
        //}
    }
}
