using System.Diagnostics;

namespace ChatFromMMF
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            //ManageMemoryMappedFile.ManageMemoryMappedFileTEST();//Тестил
            Application.Run(new Form1());
        }
        public static void StartNewProcess()
        {
            Process.Start("ChatFromMMF.exe");
        }
    }
}