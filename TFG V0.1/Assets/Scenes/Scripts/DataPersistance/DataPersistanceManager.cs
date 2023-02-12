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

    public Personaje Personaje;
    private List<IDataPersistance> dataPersistancePers;
    private FileDataHandler dataHandler;
    private string idPersSeleccionado = "test";

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
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    public void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        Debug.Log("Usando OnSceneLoaded...");
        this.dataPersistancePers = FindAllDataPersistancePers();
        CargarPersonaje();
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
        dataHandler.Guardar(Personaje, idPersSeleccionado);
    }

    public void CargarPersonaje()
    {
        this.Personaje = dataHandler.Cargar(idPersSeleccionado);

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

    public void ActualizarPersonaje(Personaje pers)
    {
        this.Personaje = pers;
        GuardarPersonaje();
        CargarPersonaje();
    }

    public void EliminarPersonaje(string persId)
    {
        dataHandler.Eliminar(persId);
        this.idPersSeleccionado = "test";
    }

    private void OnApplicationQuit()
    {
        if(idPersSeleccionado != "test")
            GuardarPersonaje();
        if(this.Personaje.nombre == " ")
        {
            EliminarPersonaje(idPersSeleccionado);
        }
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

    public Dictionary<string, Personaje> CargarPerfilesPersonaje()
    {
        return dataHandler.CargarPerfiles();
    }

    public void CambiarIdPersSelecc(string IdNuevoPers)
    {
        this.idPersSeleccionado = IdNuevoPers;
        CargarPersonaje();
    }

    public string IdPersAct()
    {
        return this.idPersSeleccionado;
    }
}
