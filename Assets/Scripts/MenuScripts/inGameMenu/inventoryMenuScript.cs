using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inventoryMenuScript : BasicMenu
{

    public void OpenExtraMenu(){
        transform.GetChild(1).GetComponent<Animator>().SetBool("open",true);
    }

    public void CloseExtraMenu(){
        transform.GetChild(1).GetComponent<Animator>().SetBool("open",false);
    }

    public void DesactiveMenu(){
        transform.gameObject.SetActive(false);
    }
}
