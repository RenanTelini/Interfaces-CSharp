using InterfaceAndAbstractInheritance.Model.Enums;

namespace InterfaceAndAbstractInheritance.Model.Entities
{
    abstract class AbstractShape : IShape
    {
        public Color Color { get; set; }

        public abstract double Area();
    }
}