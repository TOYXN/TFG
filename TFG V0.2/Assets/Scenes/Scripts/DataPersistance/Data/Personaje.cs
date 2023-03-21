using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ValoresCuerpo
{
    public int fuerza;
    public int resist;
    public int agilidad;
    public int velocidad;
    public int extra_vida = 0;

    public int bono_fuerza;
    public int bono_resist;
    public int bono_agilidad;
    public int bono_velocidad;

    public int cuerpo_act;
    public int cuerpo_max;
    public float cuerpo_hora;

    public ValoresCuerpo() { }

    public ValoresCuerpo(int fuerza, int resist, int agilidad, int velocidad)
    {
        this.fuerza = fuerza;
        this.resist = resist;
        this.agilidad = agilidad;
        this.velocidad = velocidad;

        if (fuerza >= 8) { this.bono_fuerza = (fuerza - 8) / 2; }
        else { this.bono_fuerza = (fuerza - 9) / 2; }
        if (resist >= 8) { this.bono_resist = (resist - 8) / 2; }
        else { this.bono_resist = (resist - 9) / 2; }
        if (agilidad >= 8) { this.bono_agilidad = (agilidad - 8) / 2; }
        else { this.bono_agilidad = (agilidad - 9) / 2; }
        if (velocidad >= 8) { this.bono_velocidad = (velocidad - 8) / 2; }
        else { this.bono_velocidad = (velocidad - 9) / 2; }

        this.cuerpo_max = 20 + (bono_resist * 2);
        this.cuerpo_act = cuerpo_max;
        this.cuerpo_hora = (cuerpo_max * 10.0f) / 100.0f;
    }

    //Para settear los valores de cuerpo o al actualizar valores. 
    public void ActValoresCuerpo(int fuerza, int resist, int agilidad, int velocidad)
    {
        this.fuerza = fuerza;
        this.resist = resist;
        this.agilidad = agilidad;
        this.velocidad = velocidad;

        if (fuerza >= 8) { this.bono_fuerza = (fuerza - 8) / 2; }
        else { this.bono_fuerza = (fuerza - 9) / 2; }
        if (resist >= 8) { this.bono_resist = (resist - 8) / 2; }
        else { this.bono_resist = (resist - 9) / 2; }
        if (agilidad >= 8) { this.bono_agilidad = (agilidad - 8) / 2; }
        else { this.bono_agilidad = (agilidad - 9) / 2; }
        if (velocidad >= 8) { this.bono_velocidad = (velocidad - 8) / 2; }
        else { this.bono_velocidad = (velocidad - 9) / 2; }

        this.cuerpo_max = 20 + (bono_resist * 2) + extra_vida;
        this.cuerpo_act = cuerpo_max;
        this.cuerpo_hora = (cuerpo_max * 10.0f) / 100.0f;
    }

    public void ActFuerza(int numero)
    {
        fuerza = fuerza + numero;
        if (fuerza >= 8) { bono_fuerza = (fuerza - 8) / 2; }
        else { bono_fuerza = (fuerza - 9) / 2; }
    }
    public void ActResis(int numero)
    {
        resist = resist + numero;
        if (resist >= 8) { bono_resist = (resist - 8) / 2; }
        else { bono_resist = (resist - 9) / 2; }
        cuerpo_max = 20 + (bono_resist * 2) + extra_vida;
        cuerpo_act = cuerpo_max;
        cuerpo_hora = (cuerpo_max * 10.0f) / 100.0f;
    }

    public void ActResisBuff(int numero)
    {
        resist = resist + numero;
        if (resist >= 8) { bono_resist = (resist - 8) / 2; }
        else { bono_resist = (resist - 9) / 2; }
    }

    public void ActAgil(int numero)
    {
        agilidad = agilidad + numero;
        if (agilidad >= 8) { bono_agilidad = (agilidad - 8) / 2; }
        else { bono_agilidad = (agilidad - 9) / 2; }
    }
    public void ActVel(int numero)
    {
        velocidad = velocidad + numero;
        if (velocidad >= 8) { bono_velocidad = (velocidad - 8) / 2; }
        else { bono_velocidad = (velocidad - 9) / 2; }
    }
}

[System.Serializable]
public class ValoresAlma
{
    public int poder;
    public int sentidos;
    public int memoria;
    public int persona;
    public int extra_mana = 0;

    public int bono_poder;
    public int bono_sentidos;
    public int bono_memoria;
    public int bono_persona;


    public int alma_act;
    public int alma_max;
    public float alma_hora;

    public ValoresAlma() { }

    public ValoresAlma(int poder, int sentidos, int memoria, int persona)
    {
        this.poder = poder;
        this.sentidos = sentidos;
        this.memoria = memoria;
        this.persona = persona;

        if (poder >= 8) { this.bono_poder = (poder - 8) / 2; }
        else { this.bono_poder = (poder - 9) / 2; }
        if (sentidos >= 8) { this.bono_sentidos = (sentidos - 8) / 2; }
        else { this.bono_sentidos = (sentidos - 9) / 2; }
        if (memoria >= 8) { this.bono_memoria = (memoria - 8) / 2; }
        else { this.bono_memoria = (memoria - 9) / 2; }
        if (persona >= 8) { this.bono_persona = (persona - 8) / 2; }
        else { this.bono_persona = (persona - 9) / 2; }

        this.alma_max = 30 + (bono_poder * 2);
        this.alma_act = alma_max;
        this.alma_hora = (alma_max * 10.0f) / 100.0f;
    }

    //Para settear los valores de alma o al actualizar valores. 
    public void ActValoresAlma(int poder, int sentidos, int memoria, int persona)
    {
        this.poder = poder;
        this.sentidos = sentidos;
        this.memoria = memoria;
        this.persona = persona;

        if (poder >= 8) { this.bono_poder = (poder - 8) / 2; }
        else { this.bono_poder = (poder - 9) / 2; }
        if (sentidos >= 8) { this.bono_sentidos = (sentidos - 8) / 2; }
        else { this.bono_sentidos = (sentidos - 9) / 2; }
        if (memoria >= 8) { this.bono_memoria = (memoria - 8) / 2; }
        else { this.bono_memoria = (memoria - 9) / 2; }
        if (persona >= 8) { this.bono_persona = (persona - 8) / 2; }
        else { this.bono_persona = (persona - 9) / 2; }

        this.alma_max = 30 + (bono_poder * 2) + extra_mana;
        this.alma_act = alma_max;
        this.alma_hora = (alma_max * 10.0f) / 100.0f;
    }

    public void ActPoder(int numero)
    {
        poder = poder + numero;
        if (poder >= 8) { bono_poder = (poder - 8) / 2; }
        else { bono_poder = (poder - 9) / 2; }
        alma_max = 30 + (bono_poder * 2) + extra_mana;
        alma_act = alma_max;
        alma_hora = (alma_max * 10.0f) / 100.0f;
    }

    public void ActPoderBuff(int numero)
    {
        poder = poder + numero;
        if (poder >= 8) { bono_poder = (poder - 8) / 2; }
        else { bono_poder = (poder - 9) / 2; }
    }

    public void ActSent(int numero)
    {
        sentidos = sentidos + numero;
        if (sentidos >= 8) { bono_sentidos = (sentidos - 8) / 2; }
        else { bono_sentidos = (sentidos - 9) / 2; }
    }
    public void ActMemo(int numero)
    {
        memoria = memoria + numero;
        if (memoria >= 8) { bono_memoria = (memoria - 8) / 2; }
        else { bono_memoria = (memoria - 9) / 2; }
    }
    public void ActPers(int numero)
    {
        persona = persona + numero;
        if (persona >= 8) { bono_persona = (persona - 8) / 2; }
        else { bono_persona = (persona - 9) / 2; }
    }
}

[System.Serializable]
public class OtrosValores
{
    public int apt;
    public int numDados;
    public string estado;

    public OtrosValores() { }

    public OtrosValores(int apt, int numDados, string estado)
    {
        this.apt = apt;
        this.numDados = numDados;
        this.estado = estado;
    }

    //Para settear los valores o al actualizar valores. 
    public void ActOtrosValores(int apt, int numDados, string estado)
    {
        this.apt = apt;
        this.numDados = numDados;
        this.estado = estado;
    }
}

[System.Serializable]
public class Raza
{
    public string nombreRaza;
    public string descRaza;
    public string valorPrincipal;
    public string valorSecundario;
    public string valorTerciario;

    public Raza() { }

    public Raza(string nombreRaza, string descRaza, string valorPrincipal, string valorSecundario, string valorTerciario)
    {
        this.nombreRaza = nombreRaza;
        this.descRaza = descRaza;
        this.valorPrincipal = valorPrincipal;
        this.valorSecundario = valorSecundario;
        this.valorTerciario = valorTerciario;
    }

    public string GetElemRaza(string elem)
    {
        string res = " ";
        if (elem == "nombre") { res = nombreRaza; }
        else if (elem == "valor1") { res = valorPrincipal; }
        else if (elem == "valor2") { res = valorSecundario; }
        else if (elem == "valor3") { res = valorTerciario; }
        else if (elem == "descripcion") { res = descRaza; }
        return res;
    }
}

[System.Serializable]
public class Clase
{
    public string nombreClase;
    public string descClase;
    public string valorClase;

    public Hechizo[] listaHechizosClase;

    public Arma[] listaArmasClase;

    public Clase() { }

    public Clase(string nombreClase, string descClase, string valorClase)
    {
        this.nombreClase = nombreClase;
        this.descClase = descClase;
        this.valorClase = valorClase;
        listaHechizosClase = new Hechizo[8];
        listaArmasClase = new Arma[6];
    }

    public string GetElemClase(string elem)
    {
        string res = " ";
        if (elem == "nombre") { res = nombreClase; }
        else if (elem == "valor") { res = valorClase; }
        else if (elem == "descripcion") { res = descClase; }
        return res;
    }
}

[System.Serializable]
public class Hechizo
{
    public string nombreHechizo;
    public string descHechizo;
    public string tipoHechizo;
    public int costeHechizo;
    public int dadoHechizo;

    public Hechizo()
    {
        this.nombreHechizo = "";
        this.descHechizo = "";
        this.costeHechizo = 4;
        this.dadoHechizo = 4;
        this.tipoHechizo = "";
    }

    public Hechizo(string nombreHechizo, string descHechizo, int costeHechizo, int dadoHechizo, string tipoHechizo)
    {
        this.nombreHechizo = nombreHechizo;
        this.descHechizo = descHechizo;
        this.costeHechizo = costeHechizo;
        this.dadoHechizo = dadoHechizo;
        this.tipoHechizo = tipoHechizo;
    }
}

[System.Serializable]
public class Monedero
{
    public int Paladio;
    public int Platino;
    public int Oro;
    public int Plata;

    public Monedero() { }

    public Monedero(int Paladio, int Platino, int Oro, int Plata)
    {
        this.Paladio = Paladio;
        this.Platino = Platino;
        this.Oro = Oro;
        this.Plata = Plata;
    }
}





[System.Serializable]
public class Personaje
{
    public string nombre;
    public int nivel;
    public int exp;
    public int expProxNivel;
    
    public string accVent1;
    public string accVent2;
    public string accVent3;
    public string accVent4;

    public bool cargado;
    public int valorCargado;

    public bool oculto;

    public Arma ArmaEquipada;
    public Hechizo[] listaHechizos;
    public int hechizosGuard;

    public Clase _clase;
    public Raza _raza;

    public ValoresCuerpo _cuerpo;
    public ValoresAlma _alma;
    public OtrosValores _otros;
    public Monedero _monedero;
    public string[] listaInventario;

    public string idiomas;
    public string desc;
    public string gustos;
    public string aversiones;
    public string ideales;
    public string vinculos;

    public Personaje()
    {
        this.nombre = " ";
        this.nivel = 1;
        this.exp = 0;
        this.expProxNivel = 100;
        this.hechizosGuard = 0;
        this.accVent1 = "PERCIBIR";
        this.accVent2 = "SALTAR";
        this.accVent3 = "BOTÁNICA";
        this.accVent4 = "SIGILAR";
        this._clase = new Clase("Cazador", " ", "AGILIDAD");
        this.ArmaEquipada = new Arma("Espadon", "Arma ligera de corto alcance para cortes y puñaladas. Puede ser lanzada como ataque.", 12, "FUERZA");
        this.listaHechizos = new Hechizo[8];
        this._raza = new Raza("Humano", " ", "VELOCIDAD", "AGILIDAD", "PERSONALIDAD");
        this._cuerpo = new ValoresCuerpo(8, 8, 8, 8);
        this._alma = new ValoresAlma(8, 8, 8, 8);
        this._otros = new OtrosValores();
        this._monedero = new Monedero(0, 0, 0, 0);
        this._otros.numDados = 1 + (nivel / 2);
        this._otros.apt = 2 + (_cuerpo.bono_velocidad / 2);
        this._otros.estado = "ESTABLE";
        this.oculto = false;
        this.cargado = false;
        this.valorCargado = 0;
        this.listaInventario = new string[8];
        this.idiomas = "";
        this.desc = "";
        this.gustos = "";
        this.aversiones = "";
        this.ideales = "";
        this.vinculos = "";
    }

    public void ActualizarValores(int fuerza, int resist, int agilidad, int velocidad, int poder, int sentidos, int memoria, int persona)
    {
        _cuerpo.ActValoresCuerpo(fuerza, resist, agilidad, velocidad);
        _alma.ActValoresAlma(poder, sentidos, memoria, persona);
        _otros.apt = 2 + (_cuerpo.bono_velocidad/2);
        _otros.numDados = 1 + (nivel/2);
    }

    public void ActualizarValor(string nombreValor, int numero)
    {
        if (nombreValor == "FUERZA") { _cuerpo.ActFuerza(numero); }
        else if (nombreValor == "RESISTENCIA") { _cuerpo.ActResis(numero); }
        else if (nombreValor == "AGILIDAD") { _cuerpo.ActAgil(numero); }
        else if (nombreValor == "VELOCIDAD") { _cuerpo.ActVel(numero); _otros.apt = 2 + (_cuerpo.bono_velocidad / 2); }

        else if (nombreValor == "PODER") { _alma.ActPoder(numero); }
        else if (nombreValor == "SENTIDOS") { _alma.ActSent(numero); }
        else if (nombreValor == "MEMORIA") { _alma.ActMemo(numero); }
        else if (nombreValor == "PERSONALIDAD") { _alma.ActPers(numero); }

        else if (nombreValor == "CUERPOACT") { _cuerpo.cuerpo_act = numero; }
        else if (nombreValor == "ALMAACT") { _alma.alma_act = numero; }
    }

    public void ActualizarValorBuff(string nombreValor, int numero)
    {
        if (nombreValor == "FUERZA") { _cuerpo.ActFuerza(numero); }
        else if (nombreValor == "RESISTENCIA") { _cuerpo.ActResisBuff(numero); }
        else if (nombreValor == "AGILIDAD") { _cuerpo.ActAgil(numero); }
        else if (nombreValor == "VELOCIDAD") { _cuerpo.ActVel(numero); _otros.apt = 2 + (_cuerpo.bono_velocidad / 2); }

        else if (nombreValor == "PODER") { _alma.ActPoderBuff(numero); }
        else if (nombreValor == "SENTIDOS") { _alma.ActSent(numero); }
        else if (nombreValor == "MEMORIA") { _alma.ActMemo(numero); }
        else if (nombreValor == "PERSONALIDAD") { _alma.ActPers(numero); }
    }

    public void ActualizarEstado(string estado)
    {
        _otros.estado = estado;
    }

    public void SubirNivel()
    {
        _cuerpo.extra_vida = 8 * nivel;
        _cuerpo.ActResis(0);
        _alma.extra_mana = 8 * nivel;
        _alma.ActPoder(0);
        nivel++;
        _otros.numDados = 1 + (nivel / 2);
    }

    public int Valor(string nombreValor)
    {
        int res = 0;
        if      (nombreValor == "FUERZA") { res = _cuerpo.fuerza; }
        else if (nombreValor == "RESISTENCIA") { res = _cuerpo.resist; }
        else if (nombreValor == "AGILIDAD") { res = _cuerpo.agilidad; }
        else if (nombreValor == "VELOCIDAD") { res = _cuerpo.velocidad; }

        else if (nombreValor == "PODER") { res = _alma.poder; }
        else if (nombreValor == "SENTIDOS") { res = _alma.sentidos; }
        else if (nombreValor == "MEMORIA") { res = _alma.memoria; }
        else if (nombreValor == "PERSONALIDAD") { res = _alma.persona; }

        else if (nombreValor == "CUERPOACT") { res = _cuerpo.cuerpo_act; }
        else if (nombreValor == "CUERPOMAX") { res = _cuerpo.cuerpo_max; }

        else if (nombreValor == "ALMAACT") { res = _alma.alma_act; }
        else if (nombreValor == "ALMAMAX") { res = _alma.alma_max; }
        return res;
    }

    public float PuntosHora(string nombreValor)
    {
        float res = 0.0f;
        if (nombreValor == "CUERPO") { res = _cuerpo.cuerpo_hora; }
        else if (nombreValor == "ALMA") { res = _alma.alma_hora; }
        return res;
    }

    public int BonoValor(string nombreValor)
    {
        int res = 0;
        if (nombreValor == "FUERZA") { res = _cuerpo.bono_fuerza; }
        else if (nombreValor == "RESISTENCIA") { res = _cuerpo.bono_resist; }
        else if (nombreValor == "AGILIDAD") { res = _cuerpo.bono_agilidad; }
        else if (nombreValor == "VELOCIDAD") { res = _cuerpo.bono_velocidad; }

        else if (nombreValor == "PODER") { res = _alma.bono_poder; }
        else if (nombreValor == "SENTIDOS") { res = _alma.bono_sentidos; }
        else if (nombreValor == "MEMORIA") { res = _alma.bono_memoria; }
        else if (nombreValor == "PERSONALIDAD") { res = _alma.bono_persona; }
        return res;
    }

    public int PCActual()
    {
        int res = _cuerpo.cuerpo_act;
        return res;
    }

    public int PCMaxima()
    {
        int res = _cuerpo.cuerpo_max;
        return res;
    }

    public int PAActual()
    {
        int res = _alma.alma_act;
        return res;
    }

    public int PAMaxima()
    {
        int res = _alma.alma_max;
        return res;
    }

    public string ElemRaza(string elem)
    {
        return _raza.GetElemRaza(elem);
    }

    public string ElemClase(string elem)
    {
        return _clase.GetElemClase(elem);
    }
}
