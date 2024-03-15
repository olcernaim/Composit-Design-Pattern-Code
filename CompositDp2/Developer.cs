using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositDp2
{
    public abstract class Developer
    {
        protected string _name;
        protected SoftwareDeveloperType _type;

        protected Developer(string name, SoftwareDeveloperType type)
        {
            _name = name;
            _type = type;
        }

        public abstract void AddDeveloper(Developer developer);
        public abstract void RemoveDeveloper(Developer developer);
        public abstract void Print();
    }
}
