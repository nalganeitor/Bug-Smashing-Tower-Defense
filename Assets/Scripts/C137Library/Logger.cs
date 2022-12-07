using System;
using System.IO.Compression;
using System.Collections.Generic;
using System.IO;
using System.Text;
using C137.Exceptions;
using C137.FileManagement;
using Newtonsoft.Json;
using System.Threading;

/*
MIT License

Copyright (c) 2022 C137#2606(https://github.com/R-C137)

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/

namespace C137.Utils
{
    public static class Logger
    {
        public static string loggingPath { get; set; } = "NOPATH";

        public static bool willUpdate { get; set; } = true;

        public static List<string> waitingLogs = new List<string>();


        public static void Log<T>(T @object, bool logToConsole = true, bool jsonSerialize = true)
        {
            string text = "";

#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            if (typeof(T) == typeof(string))
                text = @object.ToString();
#pragma warning restore CS8602 // Dereference of a possibly null reference.
            else
            {
                if (jsonSerialize)
                    text = JsonConvert.SerializeObject(@object, Formatting.Indented);
                else if (@object != null)
                    text = @object.ToString();
                else
                    return;
            }
            if (logToConsole)
                Console.WriteLine(text);
#pragma warning disable CS8604 // Possible null reference argument.
                WriteLog(text + "\n");
#pragma warning restore CS8604 // Possible null reference argument.
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
        }

        public static void WriteLog(string log)
        {
            if (log == null) throw new ArgumentNullException("log");

            if (loggingPath == "NOPATH")
                throw new PathNotSpecifiedException(@"Logging could not be performed. Please set the property ""loggingPath"" to a valid path ");

            if(!willUpdate)
                UpdateLogs();

            try
            {
                Thread thread = new Thread(() =>
                {
                    byte[] bytes = Encoding.UTF8.GetBytes(log);

                    FileStream stream = FileUtils.GetOrCreateFile(loggingPath, FileMode.Append, FileAccess.Write);

                    stream.Write(bytes, 0, bytes.Length);
                    stream.Close();
                });

                thread.IsBackground = true;
                thread.Start();
            }
            catch (IOException)
            {
                waitingLogs.Add(log);
            }
        }

        public static void UpdateLogs()
        {
            if(waitingLogs.Count > 0)
            {
                Thread thread = new Thread(() =>
                {
                    List<byte> bytes = new List<byte>();

                    foreach (string log in waitingLogs)
                        bytes.AddRange(Encoding.UTF8.GetBytes($"{log}\n"));

                    FileStream stream = FileUtils.GetOrCreateFile(loggingPath, FileMode.Append);

                    stream.Write(bytes.ToArray(), 0, bytes.Count);
                    stream.Close();
                });
            }
        }

        public static void ProgramExit()
        {
            string dt = DateTime.Now.ToString("yyyy-MM-dd");


            if(File.Exists(loggingPath))
            {
                string lPath = "";

                int n = 0;
                while (lPath == "")
                {
#pragma warning disable CS8604 // Possible null reference argument.
                    string p = Path.Combine(Path.GetDirectoryName(loggingPath), $"{dt}-{n}");
#pragma warning restore CS8604 // Possible null reference argument.
                    if (File.Exists(p + ".zip"))
                    {
                        n++;
                    }
                    else
                    {
                        lPath = p;
                    }
                }
                Directory.CreateDirectory(lPath);

                File.Move(loggingPath, Path.Combine(lPath, $"{dt}-{n}.log"));

                ZipFile.CreateFromDirectory(lPath, $"{lPath}.zip");

                File.Delete(loggingPath);
                Directory.Delete(lPath, true);

                var stream = File.Create(loggingPath);

                byte[] bytes = Encoding.UTF8.GetBytes($"Latest log file is: {lPath}.zip");

                stream.Write(bytes, 0, bytes.Length);
                stream.Close();
            }
        }
    }
}
