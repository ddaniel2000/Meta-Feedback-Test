using System.Collections;
using System.Collections.Generic; // let us use lists
using System.Xml;                 // basic xml attibutes
using System.Xml.Serialization;   // access xmlserializer
using System.IO;                  // file management
using UnityEngine;

public class XMLManager : MonoBehaviour
{
    public static XMLManager ins;

    private void Awake()
    {
        ins = this;
    }

    // list of data
    public DataDatabse dataDB;
    
    // save function
    public void SaveData()
    {
        XmlSerializer serializer = new XmlSerializer(typeof(DataDatabse));
        FileStream stream = new FileStream(Application.dataPath + "/XMLFile/Data.xml", FileMode.Create);
        serializer.Serialize(stream, dataDB);
        stream.Close();
    }

    private void OnDisable()
    {
        SaveData();
    }
}

[System.Serializable]
public class DataEntry
{
    public Vector3[] force1;
    public Vector3[] force2;
    public List<double> resultAngles;
}

[System.Serializable]
public class DataDatabse
{
    public List<DataEntry> list = new List<DataEntry>();
}

