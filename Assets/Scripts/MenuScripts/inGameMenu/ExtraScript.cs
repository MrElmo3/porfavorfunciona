using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraScript : MonoBehaviour
{   
    public GameObject parent;
    private Animator animador;
    private void Start() {
        animador = parent.GetComponent<Animator>();
        
    }
    public void ParentAnimation(){
        animador.SetBool("open",false);

        Debug.Log("hola");
    }
}
