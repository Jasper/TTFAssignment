using Assignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Assignment.Mapping;
using Assignment.Algorithms;

namespace Assignment.SpecializedOne
{
    public class SpecializedOne : BaseMapping
    {
        public SpecializedOne(Input input) : base(input)
        {
            
        }

        public override void setR()
        {
            algorithms.Add(new SpecializedOneR(input));
        }
    }
}