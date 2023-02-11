using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PCPA : MonoBehaviour, IDataPersistance
{
    public Text puntosCuerpo;
    public Text puntosCuerpoHora;
    public Text puntosAlma;
    public Text puntosAlmaHora;
    public Button botonCuerpo;
    public Button botonAlma;

    public GameObject menuCuerpo;
    public Text puntosCuerpoActu;
    public Text puntosCuerpoMax;
    public Text puntosEntradosCuerpo;
    public Button restarPC;
    public Button sumarPC;
    public Button cerrarMenuCuerpo;

    public GameObject menuAlma;
    public Text puntosAlmaActu;
    public Text puntosAlmaMax;
    public Text puntosEntradosAlma;
    public Button restarPA;
    public Button sumarPA;
    public Button cerrarMenuAlma;

    public GameObject menuDescanso;
    public Button botonDescanso;
    public Button botonCerrarDescanso;
    public Button botonDescansar;
    public Text horasDescanso;

    public Personaje Personaje;

    public void CargarData(Personaje pers)
    {
        this.Personaje = pers;
    }

    public void GuardarData(Personaje pers)
    {
        pers = this.Personaje;
    }

    void Start()
    {
        botonCuerpo.onClick.AddListener(AbrirMenuCuerpo);
        botonAlma.onClick.AddListener(AbrirMenuAlma);
        restarPC.onClick.AddListener(RestarPC);
        sumarPC.onClick.AddListener(SumarPC);
        cerrarMenuCuerpo.onClick.AddListener(CerrarCuerpo);
        restarPA.onClick.AddListener(RestarPA);
        sumarPA.onClick.AddListener(SumarPA);
        cerrarMenuAlma.onClick.AddListener(CerrarAlma);
        botonDescanso.onClick.AddListener(AbrirDescanso);
        botonDescansar.onClick.AddListener(CuracionDescanso);
        botonCerrarDescanso.onClick.AddListener(CerrarDescanso);
    }
    
    void AbrirMenuCuerpo()
    {
        puntosCuerpoActu.text = Personaje.Valor("CUERPOACT").ToString();
        puntosCuerpoMax.text = Personaje.Valor("CUERPOMAX").ToString();
        menuCuerpo.SetActive(true);
    }

    void AbrirMenuAlma()
    {
        puntosAlmaActu.text = Personaje.Valor("ALMAACT").ToString();
        puntosAlmaMax.text = Personaje.Valor("ALMAMAX").ToString();
        menuAlma.SetActive(true);
    }

    void RestarPC()
    {
        int valorRestar;
        int.TryParse(puntosEntradosCuerpo.text, out valorRestar);
        int PCAct = Personaje.Valor("CUERPOACT");
        int resultado = PCAct - valorRestar;
        int PCMax = Personaje.Valor("CUERPOMAX");
        puntosCuerpoActu.text = resultado.ToString();
        puntosCuerpo.text = resultado + "/" + PCMax;
        Personaje.ActualizarValor("CUERPOACT", resultado);
    }

    void SumarPC()
    {
        int valorSumar;
        int.TryParse(puntosEntradosCuerpo.text, out valorSumar);
        int PCAct = Personaje.Valor("CUERPOACT");
        int resultado = PCAct + valorSumar;
        int PCMax = Personaje.Valor("CUERPOMAX");
        if (resultado >= PCMax) { resultado = PCMax; }
        puntosCuerpoActu.text = resultado.ToString();
        puntosCuerpo.text = resultado + "/" + PCMax;
        Personaje.ActualizarValor("CUERPOACT", resultado);
    }

    void RestarPA()
    {
        int valorRestar;
        int.TryParse(puntosEntradosAlma.text, out valorRestar);
        int PAAct = Personaje.Valor("ALMAACT");
        int resultado = PAAct - valorRestar;
        int PAMax = Personaje.Valor("ALMAMAX");
        puntosAlmaActu.text = resultado.ToString();
        puntosAlma.text = resultado + "/" + PAMax;
        Personaje.ActualizarValor("ALMAACT", resultado);
    }

    void SumarPA()
    {
        int valorSumar;
        int.TryParse(puntosEntradosAlma.text, out valorSumar);
        int PAAct = Personaje.Valor("ALMAACT");
        int resultado = PAAct + valorSumar;
        int PAMax = Personaje.Valor("ALMAMAX");
        if (resultado >= PAMax) { resultado = PAMax; }
        puntosAlmaActu.text = resultado.ToString();
        puntosAlma.text = resultado + "/" + PAMax;
        Personaje.ActualizarValor("ALMAACT", resultado);
    }

    void CerrarCuerpo()
    {
        menuCuerpo.SetActive(false);
    }

    void CerrarAlma()
    {
        menuAlma.SetActive(false);
    }

    public void ActPuntos()
    {
        int PCAct = Personaje.Valor("CUERPOACT");
        int PCMax = Personaje.Valor("CUERPOMAX");
        int PAAct = Personaje.Valor("ALMAACT");
        int PAMax = Personaje.Valor("ALMAMAX");
        float PCHora = Personaje.PuntosHora("CUERPO");
        float PAHora = Personaje.PuntosHora("ALMA");
        puntosCuerpo.text = PCAct + "/" + PCMax;
        puntosAlma.text = PAAct + "/" + PAMax;
        puntosCuerpoHora.text = PCHora.ToString("F1") + " / HORA";
        puntosAlmaHora.text = PAHora.ToString("F1") + " / HORA";
    }

    void AbrirDescanso()
    {
        menuDescanso.SetActive(true);
    }

    void CuracionDescanso()
    {
        float valorHoras;
        float.TryParse(horasDescanso.text, out valorHoras);

        float PCHora = Personaje.PuntosHora("CUERPO");
        int PCAct = Personaje.Valor("CUERPOACT");
        int curarCuerpo = (int) (PCHora * valorHoras);
        int resultadoCuerpo = PCAct + curarCuerpo;
        int PCMax = Personaje.Valor("CUERPOMAX");
        if (resultadoCuerpo >= PCMax) { resultadoCuerpo = PCMax; }
        puntosCuerpo.text = resultadoCuerpo + "/" + PCMax;
        Personaje.ActualizarValor("CUERPOACT", resultadoCuerpo);

        float PAHora = Personaje.PuntosHora("ALMA");
        int PAAct = Personaje.Valor("ALMAACT");
        int curarAlma = (int)(PAHora * valorHoras);
        int resultadoAlma = PAAct + curarAlma;
        int PAMax = Personaje.Valor("ALMAMAX");
        if (resultadoAlma >= PAMax) { resultadoAlma = PAMax; }
        puntosAlma.text = resultadoAlma + "/" + PAMax;
        Personaje.ActualizarValor("ALMAACT", resultadoAlma);
    }

    void CerrarDescanso()
    {
        menuDescanso.SetActive(false);
    }
}
