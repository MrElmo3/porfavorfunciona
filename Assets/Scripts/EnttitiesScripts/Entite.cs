using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entite : MonoBehaviour
{
    //la vida es lo más importante
    public float life;
    
    //estadisticas básicas
    public int vitalidad; //modifica el crecimiento de vida de la entidad
    public int inteligencia; //daño mágico en caso de ser mago
    public int fuerza; //daño físico
    public int agilidad; // velocidad de ataque y probabilidad de evasion

    //funcion de atacar
    public void attack(Entite objetivo){

    }
}
