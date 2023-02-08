using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Paso7 : MonoBehaviour
{
    public GameObject Menu7_1;
    public GameObject Menu7_2;
    public GameObject Menu7_3;

    public Image imagenPaso7;

    public Button continuar1;
    public Button atras1;
    public Button continuar2;
    public Button atras2;
    public Button continuar3;
    public Button atras3;
    public GameObject continuar3GO;

    public Text nombreEntrado;
    public InputField Input;

    public Personaje Personaje;
    // Start is called before the first frame update
    void Start()
    {
        continuar1.onClick.AddListener(Siguiente1);
        atras1.onClick.AddListener(Atras1);
        continuar2.onClick.AddListener(Siguiente2);
        atras2.onClick.AddListener(Atras2);
        continuar3.onClick.AddListener(Siguiente3);
        atras3.onClick.AddListener(Atras3);
    }

    void Siguiente1()
    {
        Menu7_2.SetActive(true);
    }
    void Atras1()
    {
        Menu7_1.SetActive(false);
        imagenPaso7.color = new Vector4(255, 255, 255, 100);
    }

    void Siguiente2()
    {
        Menu7_3.SetActive(true);
    }
    void Atras2()
    {
        Menu7_2.SetActive(false);
    }

    void Siguiente3()
    {
        Personaje.name = nombreEntrado.text;
        SceneManager.LoadScene("Main Screen");
    }
    void Atras3()
    {
        Menu7_3.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.text != "")
        {
            continuar3GO.SetActive(true);
        }
        else
        {
            continuar3GO.SetActive(false);
        }
    }
}
