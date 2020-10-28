namespace DesignPattern.Creational
{
    public abstract class SportFactory
    {
        public abstract IShoe MakeShoe();
        public abstract IShirt MakeShirt();
    }

    public interface IShoe
    {
        float GetSize();
    }

    public interface IShirt
    {
        string GetSize();
    }

    public class AdidasFactory : SportFactory
    {
        public override IShirt MakeShirt()
        {
            return new AdidasShirt();
        }

        public override IShoe MakeShoe()
        {
            return new AdidasShoe();
        }
    }

    public class NikeFactory : SportFactory
    {
        public override IShirt MakeShirt()
        {
            return new NikeShirt();
        }

        public override IShoe MakeShoe()
        {
            return new NikeShoe();
        }
    }

    public class AdidasShirt : IShirt
    {
        public string GetSize()
        {
            return "S";
        }
    }

    public class NikeShirt : IShirt
    {
        public string GetSize()
        {
            return "L";
        }
    }

    public class AdidasShoe : IShoe
    {
        public float GetSize()
        {
            return 10;
        }
    }

    public class NikeShoe : IShoe
    {
        public float GetSize()
        {
            return 11;
        }
    }
}
