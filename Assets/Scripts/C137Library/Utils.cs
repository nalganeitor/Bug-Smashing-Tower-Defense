using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Security.Principal;

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
    public static class Utils
    {
        /// <summary>
        /// Windows only function. Return whether the application has administrative rights.
        /// </summary>
#pragma warning disable CA1416 // Validate platform compatibility
        public static bool isElevated => new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);
#pragma warning restore CA1416 // Validate platform compatibility

        // UNITY CAUSED THE FUNCTION TO STOP WORKING

//        public static bool RequestElevation(bool exitOnFail = false) // Further testing is needed
//        {
//            var evelatingProc = new ProcessStartInfo
//            {
//                UseShellExecute = true,
//                WorkingDirectory = Environment.CurrentDirectory,
//                FileName = Environment.ProcessPath,
//                Verb = "runas"
//            };
//            try
//            {
//                var proc = Process.Start(evelatingProc);
//#pragma warning disable CS8602 // Dereference of a possibly null reference.
//                proc.WaitForExit();
//#pragma warning restore CS8602 // Dereference of a possibly null reference.
//                return true;
//            }
//            catch (Exception e)
//            {
//                Console.WriteLine(e.Message);
//                return false;
//            }
//        }

        public static uint GetEpochTimeNow()
        {
            return (uint)(DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalSeconds;
        }
    }
}
