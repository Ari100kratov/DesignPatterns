﻿
namespace Ptototype
{
    public class ConcretePrototype1 : Prototype
    {
        public ConcretePrototype1(int id, string name) 
            : base(id, name)
        {
        }

        public override Prototype Clone()
        {
            return new ConcretePrototype1(this.Id, this.Name);
        }
    }
}
