using Assignment.Models;

namespace Assignment.Algorithms
{
    public class T : Algorithm
    {
        public T(Input input) : base(input)
        {
        }

        public override bool match()
        {
            return !input.A && input.B && input.C;
        }

        public override Output result()
        {
            output.X = X.T.ToString();
            output.Y = input.D - (input.D * input.F / 100);

            return output;
        }
    }
}