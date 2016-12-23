using Assignment.Models;

namespace Assignment.Algorithms
{
    public abstract class Algorithm
    {
        protected Input input;
        protected Output output;
        protected enum X { S, R, T }

        public Algorithm(Input input)
        {
            this.input = input;
            this.output = new Output();
        }

        public abstract bool match();

        public abstract Output result();
    }
}
