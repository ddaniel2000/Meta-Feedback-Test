
#if UNITY_EDITOR
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.Diagnostics;

public static class EditorMenuExtension 
{
    [MenuItem("Tools/Generate Degree Calculation")]
    public static void GenerateSaveParser()
    {
        string pathToExe = Application.dataPath.Replace(@"/", @"\") + "\\Scripts\\";
        string command = pathToExe + "executeMethod < AngleOfForcesCalculator.Method >" ;
        Process process = Process.Start("powershell.exe", command);
        process.WaitForExit();
        process.Close();
        Show();


    }
   
    [MenuItem("Tools/Show Saved Data")]
    public static void Show()
    {
        ShowExplorer(Application.dataPath.Replace(@"/", @"\") + "\\XMlFile\\");
    }

    public static void ShowExplorer(string itemPath)
    {
        itemPath = itemPath.Replace(@"/", @"\") + "Data.xml";
        Process process = Process.Start("explorer.exe", "/select," + itemPath);
        process.WaitForExit();
        process.Close();
    }
  
}

#endif
