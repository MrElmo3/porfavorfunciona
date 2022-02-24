using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void StartButton() {
        SceneManager.LoadScene("SampleScene");
    }

    // Update is called once per frame
    public void QuitButton() {
       Application.Quit();
    //    Debug.Log("Game closed");
    }
}
