using Assignment.Models;

namespace Assignment.Algorithms
{
    public class S : Algorithm
    {
        public S(Input input) : base(input)
        {
        }

        public override bool match()
        {
            return input.A && input.B && !input.C;
        }

        public override Output result()
        {
            output.X = X.S.ToString();
            output.Y = input.D + (input.D * input.E / 100);

            return output;
        }
    }
}