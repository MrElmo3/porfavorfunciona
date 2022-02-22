using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MannagerScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {

        if( Input.GetKeyDown(KeyCode.Space)){
            int actual_scene = SceneManager.GetActiveScene().buildIndex;
            switch(actual_scene){
                case 0:
                    SceneManager.LoadScene(actual_scene + 1);
                    break;
                case 1:
                    SceneManager.LoadScene(0);
                    break;
            }
        }

        if( Input.GetKeyDown(KeyCode.Escape)){
            Application.Quit();
        } 
        
    }
}
