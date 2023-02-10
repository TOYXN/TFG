using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

public class FileDataHandler
{
    private string dataDirPath = "";
    private string dataFileName = "";

    public FileDataHandler(string dataDirPath, string dataFileName)
    {
        this.dataDirPath = dataDirPath;
        this.dataFileName = dataFileName;
    }

    public Personaje Cargar()
    {
        string fullPath = Path.Combine(dataDirPath, dataFileName);
        Personaje dataCargado = null;
        if (File.Exists(fullPath))
        {
            try
            {
                string dataCargar = "";
                using (FileStream stream = new FileStream(fullPath, FileMode.Open))
                {
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        dataCargar = reader.ReadToEnd();
                    }
                }

                dataCargado = JsonUtility.FromJson<Personaje>(dataCargar);
                Debug.Log("Personaje " + dataCargado.nombre + " cargado");
            }
            catch(Exception e)
            {
                Debug.LogError("ha ocurrido un error cargando el personaje desde el archivo de guardado: " + fullPath + "\n" + e);
            }
        }
        return dataCargado;
    }

    public void Guardar(Personaje pers)
    {
        string fullPath = Path.Combine(dataDirPath, dataFileName);
        Debug.Log(fullPath);
        try
        {
            Directory.CreateDirectory(Path.GetDirectoryName(fullPath));
            string dataGuardar = JsonUtility.ToJson(pers, true);

            using (FileStream stream = new FileStream(fullPath, FileMode.Create))
            {
                using(StreamWriter writer = new StreamWriter(stream))
                {
                    writer.Write(dataGuardar);
                }
            }
            Debug.Log("Personaje " + pers.nombre + " guardado");
        }
        catch (Exception e)
        {
            Debug.LogError("Ha ocurrido un error guardando el personaje en el archivo de guardado: " + fullPath + "\n" + e);
        }
    }
}
