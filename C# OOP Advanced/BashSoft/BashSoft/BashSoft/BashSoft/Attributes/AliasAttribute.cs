using System;

namespace BashSoft.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class AliasAttribute : Attribute
    {
        private string name;

        public AliasAttribute(string aliasName)
        {
            name = aliasName;
        }

        public string Name
        {
            get { return name; }
        }

        public override bool Equals(object obj)
        {
            return name.Equals(obj);
        }
    }
}
