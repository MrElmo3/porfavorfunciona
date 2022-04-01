using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsInGameMenu : BasicMenu
{

    [SerializeField]
    private GameObject control;

    private void Update() {
        if(control.GetComponent<InGameMenuController>().estado == InGameMenuController.estados.OptionsMenu){

        }

        else{
            transform.gameObject.SetActive(false);
        }
    }
}
