using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

public static class Common
{
    public static string StartUpPath { get => @"%UserProfile%\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Startup"; }

    public static string To_hhmmtt(this TimeSpan span) => span.ToTimeFormat("hh:mm tt");

    public static string ToTimeFormat(this TimeSpan span, string format) => ToTimeFormat(span.ToString(), format);

    public static string ToTimeFormat(this string spanStr, string format) =>
        DateTime.Parse(spanStr).ToString(format, CultureInfo.GetCultureInfo("en-US"));

    public static void NoSameApp()
    {
        if (Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName).Count() > 1)
        {
            MessageBox.Show("This app is already running", "Exiting");
            Environment.Exit(0);
        }
    }

    public static void Hide_InLoad(this Form form)
    {
        form.BeginInvoke(new MethodInvoker(delegate
        { form.Hide(); }));
    }


    public class StreamService
    {
        public StreamService(string path) => Path = path;
        public string Path;

        public IEnumerable<string> Load()
        {
            if (!File.Exists(Path))
                File.Create(Path).Dispose();
            using StreamReader sr = new StreamReader(Path);
            yield return sr.ReadLine();
        }

        public void Save(IEnumerable<string> list)
        {
            using StreamWriter sw = new StreamWriter(Path);
            Array.ForEach(list.ToArray(), sw.WriteLine);
        }
    }
}