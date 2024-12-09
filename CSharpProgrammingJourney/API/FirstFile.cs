using System;
using System.IO;

namespace CSharpProgrammingJourney.API
{
    public static class StringExtension
    {
        public static string ParseHome(this string path)
        {
            string home = (Environment.OSVersion.Platform == PlatformID.Unix ||
                Environment.OSVersion.Platform == PlatformID.MacOSX)
            ? Environment.GetEnvironmentVariable("HOME")
            : Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%");

            return path.Replace("~", home);
        }
    }

    public class FirstFile
    {
        public static void Execute()
        {
            var path = @"~/primeiro_arquivo.txt".ParseHome();

            if (!File.Exists(path))
            {
                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.WriteLine("Esse é");
                    sw.WriteLine("o nosso");
                    sw.WriteLine("primeiro");
                    sw.WriteLine("arquivo!");
                };
            }

            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine("");
                sw.WriteLine("É possível");
                sw.WriteLine("adicionar");
                sw.WriteLine("mais texto!");
            }
        }
    }
}
