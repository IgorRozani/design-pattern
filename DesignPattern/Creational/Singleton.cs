namespace DesignPattern.Creational
{
    public class Singleton
    {
        private static Singleton _instance;

        private Singleton()
        {
            _instance = new Singleton();
        }

        public Singleton GetInstance()
        {
            if (_instance == null)
                _instance = new Singleton();

            return _instance;
        }
    }
}
