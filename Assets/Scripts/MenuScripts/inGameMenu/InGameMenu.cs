using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameMenu : BasicMenu
{
    private bool open = false;
    private void Update() {
        if(Input.GetKeyDown(KeyCode.Tab)){
            Debug.Log(true);
        }
        if(Input.GetKeyDown(KeyCode.Tab) && open == false){
            open = true;
            if(transform.gameObject.name == "PauseMenu"){
                transform.gameObject.SetActive(true);
            }
        }
        else if(Input.GetKeyDown(KeyCode.Tab) && open == true){
            open = false;
            transform.gameObject.SetActive(false);
        }
    }
}
