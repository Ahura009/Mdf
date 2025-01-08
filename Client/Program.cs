using Client.Forms;

namespace Client;

internal static class Program
{
    [STAThread]
    private static void Main()
    {
        Application.ThreadException += Application_ThreadException;
        AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
        Application.Run(new FrmLogin());
    }


    private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
    {
        //Debugger.Break();
        //LogException(e.Exception);
    }

    private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
    {
        var exception = e.ExceptionObject as Exception;
        if (exception != null)
            if (Application.OpenForms.Count > 0)
            {
                var form = Application.OpenForms[0];
                form?.Invoke((Action)(() =>
                {
                    MessageBox.Show($"خطای بحرانی: {exception.Message}", "خطای بحرانی", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }));
            }
    }


    private static void LogException(Exception ex)
    {
        var logPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "error.log");
        File.AppendAllText(logPath,
            $"{DateTime.Now}: {ex.Message}{Environment.NewLine}{ex.StackTrace}{Environment.NewLine}");
    }
}