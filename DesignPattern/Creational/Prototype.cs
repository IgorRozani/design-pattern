namespace DesignPattern.Creational
{
    public abstract class SandwichPrototype
    {
        public abstract SandwichPrototype Clone();
    }

    public class Sandwich : SandwichPrototype
    {
        private string Bread;
        private string Meat;
        private string Cheese;
        private string Veggies;

        public Sandwich(string bread, string meat, string cheese, string veggies)
        {
            Bread = bread;
            Meat = meat;
            Cheese = cheese;
            Veggies = veggies;
        }

        public override SandwichPrototype Clone()
        {
            return MemberwiseClone() as SandwichPrototype;
        }
    }
}
