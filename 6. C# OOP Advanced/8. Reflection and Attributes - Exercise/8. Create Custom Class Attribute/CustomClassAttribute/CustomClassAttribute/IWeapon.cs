using System;
using System.Collections.Generic;
using System.Text;

namespace CustomClassAttribute
{
    public interface IWeapon
    {
        string Name { get; set; }
        void AddGem(int index, string type);
        void RemoveGem(int index);
        void UpdateStats();
    }
}
