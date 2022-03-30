using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraScript : MonoBehaviour
{   
    private Animator animador;
    private void Start() {
        animador = gameObject.GetComponentInParent(typeof(Animator)) as Animator;

    }
    public void ParentAnimation(){
        animador.SetBool("open",false);

        Debug.Log("hola");
    }
}
