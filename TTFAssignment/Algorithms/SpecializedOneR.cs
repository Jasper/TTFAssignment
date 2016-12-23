using Assignment.Models;

namespace Assignment.Algorithms
{
    public class SpecializedOneR : R
    {
        public SpecializedOneR(Input input) : base(input)
        {
        }

        public override Output result()
        {
            output.X = X.R.ToString();
            output.Y = 2 * input.D + (input.D * input.E / 100);

            return output;
        }
    }
}