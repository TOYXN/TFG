using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventario : MonoBehaviour
{
    public Button Ayuda;
    public GameObject menuAyuda;
    public Button CerrarMenuAyuda;

    public Button CreaObj1;
    public Button CreaObj2;
    public Button CreaObj3;
    public Button CreaObj4;
    public Button CreaObj5;

    public GameObject CreaObj1go;
    public GameObject CreaObj2go;
    public GameObject CreaObj3go;
    public GameObject CreaObj4go;
    public GameObject CreaObj5go;

    public Button CreaObj6;
    public Button CreaObj7;
    public Button CreaObj8;
    public Button CreaObj9;
    public Button CreaObj10;

    public GameObject CreaObj6go;
    public GameObject CreaObj7go;
    public GameObject CreaObj8go;
    public GameObject CreaObj9go;
    public GameObject CreaObj10go;

    public Button Obj1;
    public Button Obj2;
    public Button Obj3;
    public Button Obj4;
    public Button Obj5;

    public Text TextObj1;
    public Text TextObj2;
    public Text TextObj3;
    public Text TextObj4;
    public Text TextObj5;

    public Button Obj6;
    public Button Obj7;
    public Button Obj8;
    public Button Obj9;
    public Button Obj10;

    public Text TextObj6;
    public Text TextObj7;
    public Text TextObj8;
    public Text TextObj9;
    public Text TextObj10;

    public GameObject menuNuevoObj;
    public Text objetoAnadir;
    public Button botonAnadir;
    public Button botonCerrarNuevoObj;
    public Text botonCambiar;

    public GameObject menuObj;
    public Text nombreObjeto;
    public Text numObj;
    public Button botonEliminar;
    public Button botonCerrarObj;


    // Start is called before the first frame update
    void Start()
    {
        Ayuda.onClick.AddListener(AbrirMenuAyu);
        CerrarMenuAyuda.onClick.AddListener(CerrarMenuAyu);
        botonAnadir.onClick.AddListener(AnadirNuevoObj);
        botonCerrarNuevoObj.onClick.AddListener(CerrarMenuCrear);
        botonEliminar.onClick.AddListener(EliminarObj);
        botonCerrarObj.onClick.AddListener(CerrarMenuObjeto);

        IniciarBotonesCrear();
        IniciarBotonesObjeto();
    }

    void IniciarBotonesCrear()
    {
        CreaObj1.onClick.AddListener(Crear1);
        CreaObj2.onClick.AddListener(Crear2);
        CreaObj3.onClick.AddListener(Crear3);
        CreaObj4.onClick.AddListener(Crear4);
        CreaObj5.onClick.AddListener(Crear5);
        CreaObj6.onClick.AddListener(Crear6);
        CreaObj7.onClick.AddListener(Crear7);
        CreaObj8.onClick.AddListener(Crear8);
        CreaObj9.onClick.AddListener(Crear9);
        CreaObj10.onClick.AddListener(Crear10);
    }

    void IniciarBotonesObjeto()
    {
        Obj1.onClick.AddListener(Objeto1);
        Obj2.onClick.AddListener(Objeto2);
        Obj3.onClick.AddListener(Objeto3);
        Obj4.onClick.AddListener(Objeto4);
        Obj5.onClick.AddListener(Objeto5);
        Obj6.onClick.AddListener(Objeto6);
        Obj7.onClick.AddListener(Objeto7);
        Obj8.onClick.AddListener(Objeto8);
        Obj9.onClick.AddListener(Objeto9);
        Obj10.onClick.AddListener(Objeto10);
    }

    void AnadirNuevoObj()
    {
        if (botonCambiar.text == "1") { TextObj1.text = objetoAnadir.text; CreaObj1go.SetActive(false); }
        else if (botonCambiar.text == "2") { TextObj2.text = objetoAnadir.text; CreaObj2go.SetActive(false); }
        else if (botonCambiar.text == "3") { TextObj3.text = objetoAnadir.text; CreaObj3go.SetActive(false); }
        else if (botonCambiar.text == "4") { TextObj4.text = objetoAnadir.text; CreaObj4go.SetActive(false); }
        else if (botonCambiar.text == "5") { TextObj5.text = objetoAnadir.text; CreaObj5go.SetActive(false); }
        else if (botonCambiar.text == "6") { TextObj6.text = objetoAnadir.text; CreaObj6go.SetActive(false); }
        else if (botonCambiar.text == "7") { TextObj7.text = objetoAnadir.text; CreaObj7go.SetActive(false); }
        else if (botonCambiar.text == "8") { TextObj8.text = objetoAnadir.text; CreaObj8go.SetActive(false); }
        else if (botonCambiar.text == "9") { TextObj9.text = objetoAnadir.text; CreaObj9go.SetActive(false); }
        else if (botonCambiar.text == "10") { TextObj10.text = objetoAnadir.text; CreaObj10go.SetActive(false); }
        menuNuevoObj.SetActive(false);
    }

    void EliminarObj()
    {
        if (numObj.text == "1" ) { CreaObj1go.SetActive(true); }
        else if (numObj.text == "2") { CreaObj2go.SetActive(true); }
        else if (numObj.text == "3") { CreaObj3go.SetActive(true); }
        else if (numObj.text == "4") { CreaObj4go.SetActive(true); }
        else if (numObj.text == "5") { CreaObj5go.SetActive(true); }
        else if (numObj.text == "6") { CreaObj6go.SetActive(true); }
        else if (numObj.text == "7") { CreaObj7go.SetActive(true); }
        else if (numObj.text == "8") { CreaObj8go.SetActive(true); }
        else if (numObj.text == "9") { CreaObj9go.SetActive(true); }
        else if (numObj.text == "10") { CreaObj10go.SetActive(true); }
        menuObj.SetActive(false);
    }

    void AbrirCrearObjeto(string textoBoton)
    {
        menuNuevoObj.SetActive(true);
        botonCambiar.text = textoBoton;
    }

    void AbrirObjeto(string textoBoton, string numObjPoner)
    {
        nombreObjeto.text = textoBoton;
        numObj.text = numObjPoner;
        menuObj.SetActive(true);
    }

    void Crear1()
    {
        AbrirCrearObjeto("1");
    }

    void Crear2()
    {
        AbrirCrearObjeto("2");
    }

    void Crear3()
    {
        AbrirCrearObjeto("3");
    }

    void Crear4()
    {
        AbrirCrearObjeto("4");
    }

    void Crear5()
    {
        AbrirCrearObjeto("5");
    }

    void Crear6()
    {
        AbrirCrearObjeto("6");
    }

    void Crear7()
    {
        AbrirCrearObjeto("7");
    }

    void Crear8()
    {
        AbrirCrearObjeto("8");
    }

    void Crear9()
    {
        AbrirCrearObjeto("9");
    }

    void Crear10()
    {
        AbrirCrearObjeto("10");
    }

    void Objeto1()
    {
        AbrirObjeto(TextObj1.text, "1");
    }

    void Objeto2()
    {
        AbrirObjeto(TextObj2.text, "2");
    }

    void Objeto3()
    {
        AbrirObjeto(TextObj3.text, "3");
    }

    void Objeto4()
    {
        AbrirObjeto(TextObj4.text, "4");
    }

    void Objeto5()
    {
        AbrirObjeto(TextObj5.text, "5");
    }

    void Objeto6()
    {
        AbrirObjeto(TextObj6.text, "6");
    }

    void Objeto7()
    {
        AbrirObjeto(TextObj7.text, "7");
    }

    void Objeto8()
    {
        AbrirObjeto(TextObj8.text, "8");
    }

    void Objeto9()
    {
        AbrirObjeto(TextObj9.text, "9");
    }

    void Objeto10()
    {
        AbrirObjeto(TextObj10.text, "10");
    }


    void AbrirMenuAyu()
    {
        menuAyuda.SetActive(true);
    }

    void CerrarMenuAyu()
    {
        menuAyuda.SetActive(false);
    }

    void CerrarMenuCrear()
    {
        menuNuevoObj.SetActive(false);
    }

    void CerrarMenuObjeto()
    {
        menuObj.SetActive(false);
    }
}
