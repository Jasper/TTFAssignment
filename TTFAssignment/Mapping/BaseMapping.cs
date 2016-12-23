using Assignment.Algorithms;
using Assignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment.Mapping
{
    public class BaseMapping
    {
        protected List<Algorithm> algorithms = new List<Algorithm>();
        protected Input input;

        public BaseMapping(Input input)
        {
            this.input = input;
            setS();
            setR();
            setT();
        }

        public virtual void setS()
        {
            algorithms.Add(new S(this.input));
        }

        public virtual void setR()
        {
            algorithms.Add(new R(this.input));
        }

        public virtual void setT()
        {
            algorithms.Add(new T(this.input));
        }

        public Output getResult()
        {
            Output result = null;

            foreach (Algorithm algorithm in algorithms)
            {
                if (algorithm.match())
                {
                    result = algorithm.result();
                }
            }

            return result;
        }
    }
}