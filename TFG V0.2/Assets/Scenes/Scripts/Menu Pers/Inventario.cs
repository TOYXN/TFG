using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventario : MonoBehaviour, IDataPersistance
{
    public Button Ayuda;
    public GameObject menuAyuda;
    public Button CerrarMenuAyuda;

    public InputField item1;
    public InputField item2;
    public InputField item3;
    public InputField item4;
    public InputField item5;
    public InputField item6;
    public InputField item7;
    public InputField item8;

    public Personaje Personaje;

    public void CargarData(Personaje pers)
    {
        this.Personaje = pers;
    }

    public void GuardarData(Personaje pers)
    {
        pers = this.Personaje;
    }

    // Start is called before the first frame update
    void Start()
    {
        Ayuda.onClick.AddListener(AbrirMenuAyu);
        CerrarMenuAyuda.onClick.AddListener(CerrarMenuAyu);
        CargarObjPers();
        item1.onValueChanged.AddListener(delegate { OnValueChangedItem1(); });
        item2.onValueChanged.AddListener(delegate { OnValueChangedItem2(); });
        item3.onValueChanged.AddListener(delegate { OnValueChangedItem3(); });
        item4.onValueChanged.AddListener(delegate { OnValueChangedItem4(); });
        item5.onValueChanged.AddListener(delegate { OnValueChangedItem5(); });
        item6.onValueChanged.AddListener(delegate { OnValueChangedItem6(); });
        item7.onValueChanged.AddListener(delegate { OnValueChangedItem7(); });
        item8.onValueChanged.AddListener(delegate { OnValueChangedItem8(); });
    }

    void CargarObjPers()
    {
        item1.text = Personaje.listaInventario[0];
        item2.text = Personaje.listaInventario[1];
        item3.text = Personaje.listaInventario[2];
        item4.text = Personaje.listaInventario[3];
        item5.text = Personaje.listaInventario[4];
        item6.text = Personaje.listaInventario[5];
        item7.text = Personaje.listaInventario[6];
        item8.text = Personaje.listaInventario[7];
    }

    public void OnValueChangedItem1()
    {
        Personaje.listaInventario[0] = item1.text;
    }
    public void OnValueChangedItem2()
    {
        Personaje.listaInventario[1] = item2.text;
    }
    public void OnValueChangedItem3()
    {
        Personaje.listaInventario[2] = item3.text;
    }
    public void OnValueChangedItem4()
    {
        Personaje.listaInventario[3] = item4.text;
    }
    public void OnValueChangedItem5()
    {
        Personaje.listaInventario[4] = item5.text;
    }
    public void OnValueChangedItem6()
    {
        Personaje.listaInventario[5] = item6.text;
    }
    public void OnValueChangedItem7()
    {
        Personaje.listaInventario[6] = item7.text;
    }
    public void OnValueChangedItem8()
    {
        Personaje.listaInventario[7] = item8.text;
    }

    void AbrirMenuAyu()
    {
        menuAyuda.SetActive(true);
    }

    void CerrarMenuAyu()
    {
        menuAyuda.SetActive(false);
    }
}
