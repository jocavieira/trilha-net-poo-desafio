namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string number, string model, int storage) 
            : base(number, model, storage)
        {
        }

        public override void InstallApp(string appName)
        {
            Console.WriteLine($"Installing the application {appName} on the Nokia...");
        }
    }
}
