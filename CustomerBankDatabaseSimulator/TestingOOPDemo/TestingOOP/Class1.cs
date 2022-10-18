using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingOOP
{
    class Streets<T>
    {
        public T Street { get; set; }
    }
    class KeyValuePair<TKey , TValue>
    {
        public TKey Key { get; set; }
        public TValue Value { get; set; }
    }
    class Car<T>
    {
        public T Year {get; set; }

        public T Model { get; set; }

        public T Name { get; set; }
    }
    class List<T>
    {

        public T Data { get; set; }

    }
}
