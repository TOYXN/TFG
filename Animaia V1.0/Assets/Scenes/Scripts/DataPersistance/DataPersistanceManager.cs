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
    public string idPersSeleccionado = "test";
    private string idPersGuardado = "test";
    public bool isCreating = false;
    public bool isPaused = false;

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


        if(this.Personaje == null)
        {
            CrearPersonaje();
            Debug.Log("No se ha encontrado el personaje. Creando uno...");
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
        EliminarPersonaje("test");
    }
/*
    private void OnApplicationFocus(bool hasFocus)
    {
        isFocused = hasFocus;
        Debug.Log("Foco cambiado a " + isFocused);
        if (!isFocused && !isPaused)
        {
            Debug.Log("Se supone que salgo");
            if (idPersSeleccionado != "test")
                GuardarPersonaje();
            if (this.Personaje.nombre == " ")
            {
                EliminarPersonaje(idPersSeleccionado);
            }
        }
    }
*/
    private void OnApplicationPause(bool pauseStatus)
    {
        isPaused = pauseStatus;
        Debug.Log("Pausa cambiado a " + isPaused);
        if (isPaused)
        {
            Debug.Log("Se supone que salgo");
            if (isCreating)
            {
                dataHandler.Guardar(Personaje, "test");
                EliminarPersonaje(idPersSeleccionado);
            }
            else
            {
                GuardarPersonaje();
            }
        }
        else
        {
            Debug.Log("He vuelto");
            CargarPersonaje();
            idPersSeleccionado = idPersGuardado;
            if (isCreating)
            {
                GuardarPersonaje();
            }
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
        this.idPersGuardado = IdNuevoPers;
        CargarPersonaje();
    }

    public string IdPersAct()
    {
        return this.idPersSeleccionado;
    }

    public void ChangeIsCreating(bool change)
    {
        isCreating = change;
    }
}
