using System.Collections.Generic;

namespace DesignPattern.Creational
{
    public interface IBuilder
    {
        void AddDoor();
        void AddWindow();
        void AddWall();

        string GetResult();
    }

    public class Director
    {
        public void ComplexConstruct(IBuilder builder)
        {
            builder.AddDoor();
            builder.AddWindow();
            builder.AddWall();
        }

        public void SimpleConstruct(IBuilder builder)
        {
            builder.AddWall();
        }
    }

    public class CastleBuilder : IBuilder
    {
        private List<string> _build;

        public CastleBuilder()
        {
            Reset();
        }

        public void AddDoor()
        {
            _build.Add("Portcullis");
        }

        public void AddWall()
        {
            _build.Add("Stone Wall");
        }

        public void AddWindow()
        {
            _build.Add("Stained Glass");
        }

        private void Reset()
        {
            _build = new List<string>();
        }

        public string GetResult()
        {
            Reset();
            return string.Join(", ", _build);
        }
    }

    public class HouseBuilder : IBuilder
    {
        private List<string> _build;

        public HouseBuilder()
        {
            Reset();
        }

        public void AddDoor()
        {
            _build.Add("Wood Door");
        }

        public void AddWall()
        {
            _build.Add("Brick Wall");
        }

        public void AddWindow()
        {
            _build.Add("Metal Window");
        }

        private void Reset()
        {
            _build = new List<string>();
        }

        public string GetResult()
        {
            Reset();
            return string.Join(", ", _build);
        }
    }
}
