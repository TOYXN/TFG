using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDataPersistance
{
    void CargarData(Personaje pers);
    void GuardarData(Personaje pers);
}
