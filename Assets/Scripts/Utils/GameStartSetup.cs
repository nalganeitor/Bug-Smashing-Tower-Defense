using C137.Utils;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class GameStartSetup : MonoBehaviour
{
    AddReferences referenceAdder;

    private void Awake()
    {
        //Setup logging
        C137.Utils.Logger.loggingPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Bug Smashing Tower defense", "Logs", "latest.log");


        if (referenceAdder == null)
            C137.Unity.C137LibraryPort.Log($@"GameStartSetup Error: variable ""referenceAdder"" is null. References will not be added this may cause errors in other scripts", isError: true);
        else
            referenceAdder.SetupReferences();
    }

    private void OnApplicationQuit()
    {
        C137.Utils.Logger.ProgramExit();
    }
}
