using BarrackWarsANewFactory.Contracts;
using System;
using System.Reflection;

namespace BarrackWarsANewFactory.Core.Factories
{
    public class UnitFactory : IUnitFactory
    {
        public IUnit CreateUnit(string unitType)
        {
            BindingFlags flags = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static;

            Type classType = Type.GetType("BarrackWarsANewFactory.Models.Units." + unitType);

            object unit = Activator.CreateInstance(classType);

            return (IUnit)unit;
        }
    }
}
