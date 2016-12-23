using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Assignment.Models;
using Assignment.Algorithms;

namespace Assignment.Mapping
{
    public class SpecializedTwo : BaseMapping
    {
        public SpecializedTwo(Input input) : base(input)
        {
        }

        public override void setS()
        {
            algorithms.Add(new SpecializedTwoS(input));
        }

        public override void setT()
        {
            algorithms.Add(new SpecializedTwoT(input));
        }
    }
}