using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MilitaryElite
{
    public class LeutenantGeneral : Private, ILeutenantGeneral
    {
        public LeutenantGeneral(string id, string firstName, string lastName, double salary, List<IPrivate> privates):base(id, firstName, lastName, salary)
        {
            this.privates = new List<IPrivate>();
            foreach (var privat in privates)
            {
                this.privates.Add(privat);
            }
        }

        public List<IPrivate> privates { get; private set; }

        public override string ToString()
        {
            return privates.Count == 0 ? base.ToString() + string.Format($"{Environment.NewLine}Privates:")
                    : base.ToString() + string.Format($"{Environment.NewLine}Privates:{Environment.NewLine}") + string.Join(Environment.NewLine, 
                        privates.Select(x => "  " + x));
        }
    }
}
