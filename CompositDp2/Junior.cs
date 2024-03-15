using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositDp2
{
    public class Junior : Developer
    {
        public Junior(string name, SoftwareDeveloperType type) : base(name, type)
        {

        }
        public override void AddDeveloper(Developer developer)
        {
            throw new NotImplementedException();
        }
        public override void Print()
        {
            Console.WriteLine(string.Format("{0} {1}", _type, _name));
        }

        public override void RemoveDeveloper(Developer developer)
        {
            throw new NotImplementedException();
        }
    }
}
