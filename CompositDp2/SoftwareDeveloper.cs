using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositDp2
{
    public class SoftwareDeveloper : Developer
    {
        private List<Developer> _developers = new List<Developer>();
        public SoftwareDeveloper(string name, SoftwareDeveloperType type) : base(name,type)
        {

        }

        public override void AddDeveloper(Developer developer)
        {
            _developers.Add(developer);
        }

        public override void Print()
        {
            Console.WriteLine(string.Format("{0} {1}", _type, _name));

            foreach (var item in _developers)
            {
                item.Print();
            }
        }

        public override void RemoveDeveloper(Developer developer)
        {
            _developers.Remove(developer);
        }
    }
}
