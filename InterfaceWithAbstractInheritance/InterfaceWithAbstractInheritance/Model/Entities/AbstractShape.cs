using InterfaceWithAbstractInheritance.Model.Enums;

namespace InterfaceWithAbstractInheritance.Model.Entities
{
    abstract class AbstractShape : IShape
    {
        public Color Color { get; set; }

        public abstract double Area();
    }
}