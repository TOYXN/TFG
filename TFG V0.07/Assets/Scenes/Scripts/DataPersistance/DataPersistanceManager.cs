using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.SceneManagement;


public class DataPersistanceManager : MonoBehaviour
{
    [Header("Debugging")]
    [SerializeField] private bool initializeDataIfNull = false;

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
            Debug.Log("ERROR. Se ha encontrado mas de una instancia en la escena. Destruyendo la nueva...");
            Destroy(this.gameObject);
            return;
        }
        instance = this;
        DontDestroyOnLoad(this.gameObject);

        this.dataHandler = new FileDataHandler(Application.persistentDataPath, filename);
    }

    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
        SceneManager.sceneUnloaded += OnSceneUnloaded;
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
        SceneManager.sceneUnloaded -= OnSceneUnloaded;
    }

    public void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        Debug.Log("Usando OnSceneLoaded...");
        this.dataPersistancePers = FindAllDataPersistancePers();
        CargarPersonaje();
    }

    public void OnSceneUnloaded(Scene scene)
    {
        Debug.Log("Usando OnSceneUnloaded...");
        GuardarPersonaje();
    }

    public void CrearPersonaje()
    {
        this.Personaje = new Personaje();
    }

    public void GuardarPersonaje()
    {
        if(this.Personaje == null)
        {
            Debug.LogWarning("No se han encontrado personajes. Se necesita crear uno antes");
            return;
        }
        foreach (IDataPersistance dataPersistanceObj in dataPersistancePers)
        {
            dataPersistanceObj.GuardarData(Personaje);
        }
        dataHandler.Guardar(Personaje);
    }

    public void CargarPersonaje()
    {
        this.Personaje = dataHandler.Cargar();

        if(this.Personaje == null && initializeDataIfNull)
        {
            CrearPersonaje();
        }

        if(this.Personaje == null)
        {
            Debug.Log("No se han encontrado personajes. Se necesita crear uno antes");
            return;
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

    public bool PersonajeExiste()
    {
        return Personaje != null;
    }
}
