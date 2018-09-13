using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm._2.Helpers
{
    public class LinkedListModelExo2
    {
        public LinkedListModelExo2(int number)
        {
            Number = number;
        }

        public int Number { get; set; }

        public LinkedListModelExo1 Next { get; set; }

        public LinkedListModelExo1 Previous { get; set; }
    }
}
