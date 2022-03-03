using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : BasicMenu
{

    private void Start() {
        
    }

    public void QuitButton() {
       Application.Quit();
    //    Debug.Log("Game closed");
    }
}
