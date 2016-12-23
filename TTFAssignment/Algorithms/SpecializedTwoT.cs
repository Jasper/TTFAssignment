using Assignment.Models;

namespace Assignment.Algorithms
{
    public class SpecializedTwoT : T
    {
        public SpecializedTwoT(Input input) : base(input)
        {
        }

        public override bool match()
        {
            return input.A && input.B && !input.C;
        }
    }
}