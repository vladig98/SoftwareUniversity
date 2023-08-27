using System;
using System.Collections.Generic;
using System.Text;

namespace InfernoInfinity
{
    public interface IWeapon
    {
        string Name { get; set; }
        void AddGem(int index, string type);
        void RemoveGem(int index);
        void UpdateStats();
    }
}
