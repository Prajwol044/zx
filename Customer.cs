using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial4Ex3
{
    internal class Customer
    {
        int id { get; set; }
        string name { get; set; }
         
        public Customer(int i, string n)
        {
            id = i;
            name = n;
        }

        }
    }

