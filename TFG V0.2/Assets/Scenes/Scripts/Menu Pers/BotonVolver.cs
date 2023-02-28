using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BotonVolver : MonoBehaviour
{
    public Button botonVolver;
    // Start is called before the first frame update
    void Start()
    {
        botonVolver.onClick.AddListener(Volver);
    }

    // Update is called once per frame
    void Volver()
    {
        DataPersistanceManager.instance.GuardarPersonaje();
        SceneManager.LoadScene("Main Screen");
    }
}
