using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DesbloqHechiz : MonoBehaviour
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

    public void DesblHechiz()
    {
        int memoPers = Personaje.Valor("MEMORIA");
        int hechiActPers = Personaje.hechizosGuard;
        if(memoPers >= 6)
        {
            if (hechiActPers == 0)
            {
                botonNuevoHechizo1.SetActive(true);
                bannerBloqueo1.SetActive(false);
            }
            if (memoPers >= 8)
            {
                if (hechiActPers <= 1)
                {
                    botonNuevoHechizo2.SetActive(true);
                    bannerBloqueo2.SetActive(false);
                }
                if (memoPers >= 10)
                {
                    if (hechiActPers <= 2)
                    {
                        botonNuevoHechizo3.SetActive(true);
                        bannerBloqueo3.SetActive(false);
                    }
                    if (memoPers >= 12)
                    {
                        if (hechiActPers <= 3)
                        {
                            botonNuevoHechizo4.SetActive(true);
                            bannerBloqueo4.SetActive(false);
                        }
                        if (memoPers >= 14)
                        {
                            if (hechiActPers <= 4)
                            {
                                botonNuevoHechizo5.SetActive(true);
                                bannerBloqueo5.SetActive(false);
                            }
                            if (memoPers >= 16)
                            {
                                if (hechiActPers <= 5)
                                {
                                    botonNuevoHechizo6.SetActive(true);
                                    bannerBloqueo6.SetActive(false);
                                }
                                if (memoPers >= 18)
                                {
                                    if (hechiActPers <= 6)
                                    {
                                        botonNuevoHechizo7.SetActive(true);
                                        bannerBloqueo7.SetActive(false);
                                    }
                                    if (memoPers >= 20)
                                    {
                                        if (hechiActPers <= 7)
                                        {
                                            botonNuevoHechizo8.SetActive(true);
                                            bannerBloqueo8.SetActive(false);
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
