using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CombatAttacks : MonoBehaviour
{
    public Button botonAtacar;
    public Button botonHechizos;
    public GameObject MenuAcciones;
    public GameObject MenuHechizos;
    public GameObject MenuAtaqueArma;
    // Start is called before the first frame update
    void Start()
    {
        botonAtacar.onClick.AddListener(atacarArma);
        botonHechizos.onClick.AddListener(usarHechizo);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void atacarArma()
    {
        MenuAtaqueArma.SetActive(true);
    }

    void usarHechizo()
    {
        MenuHechizos.SetActive(true);
        MenuAcciones.SetActive(false);
    }
}
