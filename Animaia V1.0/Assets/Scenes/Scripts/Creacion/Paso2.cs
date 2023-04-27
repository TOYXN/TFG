using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Paso2 : MonoBehaviour
{
    public GameObject Menu2_1;
    public GameObject Menu2_2;
    public GameObject Menu2_3;
    public GameObject Menu2_4;
    public Image imagenPaso2;

    public Button continuar1;
    public Button atras1;
    public Button continuar2;
    public Button atras2;
    public Button continuar3;
    public Button atras3;

    public Text num1;
    public Text num2;
    public Text num3;
    public Text num4;
    public Text num5;
    public Text num6;
    public Text num7;
    public Text num8;

    public Paso2_4 PasoAsig;

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
        Menu2_2.SetActive(true);
    }
    void Atras1()
    {
        Menu2_1.SetActive(false);
        imagenPaso2.color = new Vector4(255, 255, 255, 100);
    }

    void Siguiente2()
    {
        Menu2_3.SetActive(true);
    }
    void Atras2()
    {
        Menu2_2.SetActive(false);
    }

    void Siguiente3()
    {
        CalcularNumeros();
        PasoAsig.ReiniciarPersonaje();
        Menu2_4.SetActive(true);
    }
    void Atras3()
    {
        Menu2_3.SetActive(false);
    }

    void CalcularNumeros()
    {
        int[] numeros = new int[8];
        int min = 4;
        int max = 17;
        int numMenores = 0;
        for (int i = 0; i < 8; i++)
        {
            int valor = Random.Range(min, max);

            while (valor < 6) { valor = Random.Range(min, max); }
            if (valor >= 6 && valor < 8) { numMenores++; }
            numeros[i] = valor;
        }
        int j = 0;
        while (numMenores >= 3)
        {
            if (numeros[j] < 8)
            {
                numeros[j] = Random.Range(8, max);
                numMenores--;
            }
            j++;
        }
        num1.text = numeros[0].ToString();
        num2.text = numeros[1].ToString();
        num3.text = numeros[2].ToString();
        num4.text = numeros[3].ToString();
        num5.text = numeros[4].ToString();
        num6.text = numeros[5].ToString();
        num7.text = numeros[6].ToString();
        num8.text = numeros[7].ToString();
    }
}
