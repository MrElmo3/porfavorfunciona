using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : BasicMenu
{
    public void NewGame(){
        SceneManager.LoadScene("OnceUponATime");
    }
}
