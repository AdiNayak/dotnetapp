using System.Resources;
using Test.Domain;
namespace Test.DeskTop
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            var res = new SaveInfo();
            var resss = MessageInfo.ResourceManager.GetString("Test");

            // Create a ResourceManager for your resource file.
            ResourceManager resourceManager = new ResourceManager("Test.Domain.MessageInfo", typeof(Program).Assembly);

            // Retrieve a string value by its key.
            string welcomeMessage = resourceManager.GetString("Hello");

            // Display the string value.
            Console.WriteLine(welcomeMessage);




            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            //ApplicationConfiguration.Initialize();
            //Application.Run(new Form1());
        }
    }
}