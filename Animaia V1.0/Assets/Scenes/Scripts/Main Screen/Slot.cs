using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    [Header("Personaje")]
    [SerializeField] private string persId = "";

    [Header("Contenido")]
    [SerializeField] private GameObject persExistente;
    [SerializeField] private GameObject persPorCrear;

    [SerializeField] private Text nombrePers;
    [SerializeField] private Text infoPers;
    [SerializeField] private Text nivelPers;

    public void PonInfo(Personaje pers)
    {
        if(pers == null)
        {
            persPorCrear.SetActive(true);
            persExistente.SetActive(false);
        }
        else
        {
            nombrePers.text = pers.nombre;
            infoPers.text = pers._raza.nombreRaza + " | " + pers._clase.nombreClase;
            nivelPers.text = "Nivel: " + pers.nivel;

            persExistente.SetActive(true);
            persPorCrear.SetActive(false);
        }
    }

    public string GetIdPers()
    {
        return this.persId;
    }
}
