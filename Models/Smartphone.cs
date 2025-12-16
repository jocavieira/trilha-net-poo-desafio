namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Number { get; set; }
        public string Model { get; set; }
        public int Storage { get; set; }

        // Constructor
        protected Smartphone(string number, string model, int storage)
        {
            Number = number;
            Model = model;
            Storage = storage;
        }

        // Make a call
        public void Call()
        {
            Console.WriteLine($"{Model} is making a call...");
        }

        // Receive a call
        public void IncomingCall()
        {
            Console.WriteLine($"{Model} is receiving a call...");
        }

        // Abstract method to install apps
        public abstract void InstallApp(string appName);
    }
}
