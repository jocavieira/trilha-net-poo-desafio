namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string number, string model, int storage) 
            : base(number, model, storage)
        {
        }

        public override void InstallApp(string appName)
        {
            Console.WriteLine($"Installing the application {appName} on the iPhone...");
        }
    }
}