using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class DataPersistanceManager : MonoBehaviour
{
    [Header("File Storage Config")]
    [SerializeField] private string filename;


    public static DataPersistanceManager instance { get; private set; }

    private Personaje Personaje;
    private List<IDataPersistance> dataPersistancePers;
    private FileDataHandler dataHandler;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("ERROR. Se ha encontrado mas de una instancia en la escena.");
        }
        instance = this;
    }

    private void Start()
    {
        this.dataHandler = new FileDataHandler(Application.persistentDataPath, filename);
        this.dataPersistancePers = FindAllDataPersistancePers();
        CargarPersonaje();
    }

    public void CrearPersonaje()
    {
        this.Personaje = new Personaje();
    }

    public void GuardarPersonaje()
    {
        foreach (IDataPersistance dataPersistanceObj in dataPersistancePers)
        {
            dataPersistanceObj.GuardarData(Personaje);
        }
        dataHandler.Guardar(Personaje);
    }

    public void CargarPersonaje()
    {
        this.Personaje = dataHandler.Cargar();

        if(this.Personaje == null)
        {
            Debug.Log("Personaje no encontrado. Creandolo...");
            CrearPersonaje();
        }
        foreach (IDataPersistance dataPersistanceObj in dataPersistancePers)
        {
            dataPersistanceObj.CargarData(Personaje);
        }
    }

    private void OnApplicationQuit()
    {
        GuardarPersonaje();
    }

    private List<IDataPersistance> FindAllDataPersistancePers()
    {
        IEnumerable<IDataPersistance> dataPersistancePers = FindObjectsOfType<MonoBehaviour>().OfType<IDataPersistance>();

        return new List<IDataPersistance>(dataPersistancePers);
    }
}
