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

    public Personaje Cargar(string idPers)
    {
        string fullPath = Path.Combine(dataDirPath, idPers, dataFileName);
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

    public void Guardar(Personaje pers, string idPers)
    {
        string fullPath = Path.Combine(dataDirPath, idPers, dataFileName);
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

    public void Eliminar(string idPers)
    {
        if(idPers == null)
        {
            return;
        }

        string fullpath = Path.Combine(dataDirPath, idPers, dataFileName);
        try
        {
            if (File.Exists(fullpath))
            {
                Directory.Delete(Path.GetDirectoryName(fullpath), true);
                Debug.Log("Personaje " + idPers + " eliminado");
            }
            else
            {
                Debug.LogWarning("Error al eliminar el personaje en el directorio: " + fullpath);
            }
        }
        catch(Exception e)
        {
            Debug.LogError("Error al eliminar el personaje con ID: " + idPers + " en el directorio " + fullpath + "\n" + e);
        }
    }

    public Dictionary<string, Personaje> CargarPerfiles()
    {
        Dictionary<string, Personaje> diccionarioPerfil = new Dictionary<string, Personaje>();

        IEnumerable<DirectoryInfo> dirInfos = new DirectoryInfo(dataDirPath).EnumerateDirectories();
        foreach (DirectoryInfo dirInfo in dirInfos)
        {
            string idPerfil = dirInfo.Name;
            string fullpath = Path.Combine(dataDirPath, idPerfil, dataFileName);
            if (!File.Exists(fullpath))
            {
                Debug.LogWarning("Saltando directorio cargando los perfiles porque no contiene info: " + idPerfil);
                continue;
            }
            Personaje persPerfil = Cargar(idPerfil);
            if(persPerfil != null)
            {
                diccionarioPerfil.Add(idPerfil, persPerfil);
            }
            else
            {
                Debug.LogError("Ocurrió un error intentando cargar el personaje de id: " + idPerfil);
            }
        }

        return diccionarioPerfil;
    }
}
