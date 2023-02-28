using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuSlots : MonoBehaviour
{
    private Slot[] saveSlots;

    private void Awake()
    {
        saveSlots = this.GetComponentsInChildren<Slot>();

    }

    private void Start()
    {
        ActivarMenu();
    }

    public void ActivarMenu()
    {
        Dictionary<string, Personaje> perfilesPers = DataPersistanceManager.instance.CargarPerfilesPersonaje();
        foreach(Slot saveslot in saveSlots)
        {
            Personaje personaje = null;
            perfilesPers.TryGetValue(saveslot.GetIdPers(), out personaje);
            saveslot.PonInfo(personaje);
        }
    }
}
