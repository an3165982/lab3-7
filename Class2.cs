using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

    class Container : PO
    {
        ArrayList AAA { get; set; }

        public Container(ArrayList S)
        {
            AAA = S;
        }

        public void Add(Object A)
        {
            AAA.Add(A);
        }

        public void Delete(PO A)
        {
            if (AAA.Contains(A)) { AAA.Remove(A); }
        }

        public void Print()
        {
            for (int i = 0; i < AAA.Count; i++)
            {
                Console.WriteLine(AAA[i]);
            }
        }
    }