using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using C137.Utils;
using Newtonsoft.Json;
using C137.Exceptions;
using System.IO;
using System.Threading;
using System.Text;
using C137.FileManagement;
using System.IO.Compression;

namespace C137.Unity
{
    public class C137LibraryPort
    {
        public static void Log<T>(T @object, bool logToConsole = true, bool jsonSerialize = true, bool isError = false)
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
            if (logToConsole && !isError)
                Debug.Log(text);
            else
                if(logToConsole && isError)
                Debug.LogError(text);
#pragma warning disable CS8604 // Possible null reference argument.
            Utils.Logger.WriteLog(text);
#pragma warning restore CS8604 // Possible null reference argument.
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
        }
    }
}