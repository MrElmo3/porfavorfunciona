using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    public void StartButton() {
        SceneManager.LoadScene("OnceUponATime");
    }

    public void QuitButton() {
       Application.Quit();
    //    Debug.Log("Game closed");
    }
}
