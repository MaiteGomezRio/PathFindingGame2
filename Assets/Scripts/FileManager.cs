using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

public static class FileManager
{
    public static bool WriteToFile(string filename, string data)
    {
        string fullPath = Path.Combine(Application.persistentDataPath, filename);

        try
        {
            File.WriteAllText(fullPath, data); 
            Debug.Log("Fichero guardado en: " + fullPath);
            return true;
        }
        catch (Exception e)
        {
            Debug.Log("ERROR al guardar fichero en: " + fullPath + "error:" + e);
            return false;
        }
    }
}
