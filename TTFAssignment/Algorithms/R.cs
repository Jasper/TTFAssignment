﻿using Assignment.Models;

namespace Assignment.Algorithms
{
    public class R : Algorithm
    {
        public R(Input input) : base(input)
        {
        }

        public override bool match()
        {
            return input.A && input.B && input.C;
        }

        public override Output result()
        {
            output.X = X.R.ToString();
            output.Y = input.D + (input.D * (input.E - input.F) / 100);

            return output;
        }
    }
}