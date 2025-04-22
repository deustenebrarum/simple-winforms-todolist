namespace TaskList
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

            string? filepath = GetInitialFilePath();

            if (string.IsNullOrEmpty(filepath))
                return;

            Application.Run(new TaskListForm(filepath));
        }

        static string? GetInitialFilePath()
        {
            OpenFileDialog openFileDialog = new();

            openFileDialog.Filter = "JSON|*.json";
            openFileDialog.DefaultExt = "json";
            openFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            openFileDialog.CheckFileExists = false;

            DialogResult result = openFileDialog.ShowDialog();

            if (result != DialogResult.OK)
                return null;

            return openFileDialog.FileName;
        }
    }
}