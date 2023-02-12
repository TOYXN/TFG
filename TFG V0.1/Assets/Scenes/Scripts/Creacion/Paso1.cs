using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Paso1 : MonoBehaviour
{
    public GameObject Menu1;
    public GameObject Menu2;
    public Image imagenPaso1;
    public Image imagenPaso2;

    public Button continuar;
    public Button atras;

    // Start is called before the first frame update
    void Start()
    {
        imagenPaso1.color = new Vector4(0, 255, 0, 100);
        continuar.onClick.AddListener(Siguiente);
        atras.onClick.AddListener(Atras);
    }

    void Siguiente()
    {
        imagenPaso2.color = new Vector4(0, 255, 0, 100);
        Menu2.SetActive(true);
    }

    void Atras()
    {
        string persAct = DataPersistanceManager.instance.IdPersAct();
        DataPersistanceManager.instance.EliminarPersonaje(persAct);
        SceneManager.LoadScene("Main Screen");
    }
}
