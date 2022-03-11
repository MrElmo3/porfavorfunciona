using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entite : MonoBehaviour
{
    //la vida es lo más importante
    public float life;

    public int level;
    
    //estadisticas básicas
    public int vitality; //modifica el crecimiento de vida de la entidad
    public int intelligence; //daño mágico en caso de ser mago
    public int strength; //daño físico
    public int agility; // velocidad de ataque y probabilidad de evasion

    //funcion de atacar
    public void attack(Entite objetivo){

    }
}
