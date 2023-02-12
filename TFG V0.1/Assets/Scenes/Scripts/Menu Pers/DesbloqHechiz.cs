using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DesbloqHechiz : MonoBehaviour, IDataPersistance
{
    public GameObject bannerBloqueo1;
    public GameObject bannerBloqueo2;
    public GameObject bannerBloqueo3;
    public GameObject bannerBloqueo4;
    public GameObject bannerBloqueo5;
    public GameObject bannerBloqueo6;
    public GameObject bannerBloqueo7;
    public GameObject bannerBloqueo8;

    public GameObject botonNuevoHechizo1;
    public GameObject botonNuevoHechizo2;
    public GameObject botonNuevoHechizo3;
    public GameObject botonNuevoHechizo4;
    public GameObject botonNuevoHechizo5;
    public GameObject botonNuevoHechizo6;
    public GameObject botonNuevoHechizo7;
    public GameObject botonNuevoHechizo8;


    public Personaje Personaje;

    void Start()
    {

    }
    
    public void CargarData(Personaje pers)
    {
        this.Personaje = pers;
    }

    public void GuardarData(Personaje pers)
    {
        pers = this.Personaje;
    }

    public void DesblHechiz()
    {
        
        int memoPers = Personaje.Valor("MEMORIA");
        Debug.Log(memoPers);
        int hechiActPers = Personaje.hechizosGuard;
        if(memoPers >= 6)
        {
            bannerBloqueo1.SetActive(false);
            if (hechiActPers == 0)
            {
                botonNuevoHechizo1.SetActive(true);
            }
            if (memoPers >= 8)
            {
                bannerBloqueo2.SetActive(false);
                if (hechiActPers <= 1)
                {
                    botonNuevoHechizo2.SetActive(true);
                }
                if (memoPers >= 10)
                {
                    bannerBloqueo3.SetActive(false);
                    if (hechiActPers <= 2)
                    {
                        botonNuevoHechizo3.SetActive(true);
                    }
                    if (memoPers >= 12)
                    {
                        bannerBloqueo4.SetActive(false);
                        if (hechiActPers <= 3)
                        {
                            botonNuevoHechizo4.SetActive(true); 
                        }
                        if (memoPers >= 14)
                        {
                            bannerBloqueo5.SetActive(false);
                            if (hechiActPers <= 4)
                            {
                                botonNuevoHechizo5.SetActive(true); 
                            }
                            if (memoPers >= 16)
                            {
                                bannerBloqueo6.SetActive(false);
                                if (hechiActPers <= 5)
                                {
                                    botonNuevoHechizo6.SetActive(true);
                                }
                                if (memoPers >= 18)
                                {
                                    bannerBloqueo7.SetActive(false);
                                    if (hechiActPers <= 6)
                                    {
                                        botonNuevoHechizo7.SetActive(true);
                                    }
                                    if (memoPers >= 20)
                                    {
                                        bannerBloqueo8.SetActive(false);
                                        if (hechiActPers <= 7)
                                        {
                                            botonNuevoHechizo8.SetActive(true);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
