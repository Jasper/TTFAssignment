﻿using Assignment.Models;

namespace Assignment.Algorithms
{
    public class SpecializedTwoS : S
    {
        public SpecializedTwoS(Input input) : base(input)
        {
        }

        public override bool match()
        {
            return input.A && !input.B && input.C;
        }

        public override Output result()
        {
            output.X = X.S.ToString();
            output.Y = input.F + input.D + (input.D * input.E / 100);

            return output;
        }
    }
}