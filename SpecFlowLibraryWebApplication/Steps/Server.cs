using System.IO;
using System.Diagnostics;
using TechTalk.SpecFlow;

namespace SpecFlowLibraryWebApplication.Steps
{
    [Binding]
    public static class Server
    {
        private const string ApplicationFileName = "LibraryWebApplicationUI.exe";
        private const string DirectoryToApplicationFileFromSolution = @"LibraryWebApplicationUI\bin\Debug\netcoreapp3.1";

        private static Process _serverProcess;
        
        [BeforeTestRun]
        public static void Run()
        {
            string solutionPath = Directory.GetCurrentDirectory();
            for (int i = 0; i < 4; i++)
            {
                solutionPath = Path.GetDirectoryName(solutionPath);
            }

            string applicationPath = Path.Combine(solutionPath,
                DirectoryToApplicationFileFromSolution, ApplicationFileName);

            _serverProcess = Process.Start(applicationPath);
        }

        [AfterTestRun]
        public static void Dispose()
        {
            _serverProcess.Kill();
        }
    }
}
