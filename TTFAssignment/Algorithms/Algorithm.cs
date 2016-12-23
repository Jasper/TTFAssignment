using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment.Models;

namespace Assignment.Algorithms
{
    public abstract class Algorithm
    {
        protected Input input;
        protected Output output;

        public Algorithm(Input input)
        {
            this.input = input;
            this.output = new Output();
        }

        public abstract bool match();

        public abstract Output result();
    }
}
