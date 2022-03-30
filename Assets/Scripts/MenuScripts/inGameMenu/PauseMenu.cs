using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : BasicMenu
{
    public void PauseGame(){
        Time.timeScale = 0f;
    }

    public void ResumeGame(){
        Time.timeScale = 1f;
        transform.gameObject.SetActive(false);
    }

}
