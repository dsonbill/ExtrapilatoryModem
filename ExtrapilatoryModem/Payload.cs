using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtrapilatoryModem
{
    public class Payload
    {
        public readonly Char Designation;
        public readonly int Information;

        public readonly int Link;
        public readonly int Code;
        public readonly string Target;

        public readonly int Latch;

        public readonly bool Locked;

        public readonly string Solver;

        public readonly string Dump;

        public Payload(Char designation, int information, int link, int code, string target, int latch, bool locked, string solver, string crap)
        {
            Designation = designation;
            Information = information;

            Link = link;
            Code = code;
            Target = target;

            Latch = latch;

            Locked = locked;

            Solver = solver;

            Dump = crap;
        }
    }
}
