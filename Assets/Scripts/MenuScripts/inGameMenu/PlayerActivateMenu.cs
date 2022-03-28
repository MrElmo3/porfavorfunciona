using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActivateMenu : MonoBehaviour
{   
    [SerializeField]
    private GameObject Menu;
    private bool open = false;

    private void Awake() {
        Menu.SetActive(false);
    }

    private void Update() {
        if(Input.GetKeyDown(KeyCode.Tab) && open == false){
            open = true;
            Menu.SetActive(true);
            for(int i = 0; i < Menu.transform.childCount; i++){
                if(i == 0){
                    Menu.transform.GetChild(i).gameObject.SetActive(true);
                    continue;
                }
                Menu.transform.GetChild(i).gameObject.SetActive(false);

                Time.timeScale = 0f; 
            }

        }
        else if(Input.GetKeyDown(KeyCode.Tab) && open == true){

            open = false;

            for(int i = 0; i < Menu.transform.childCount; i++){
                if(i == 0){
                    Menu.transform.GetChild(i).gameObject.SetActive(true);
                    continue;
                }
                Menu.transform.GetChild(i).gameObject.SetActive(false); 
            }

            Menu.SetActive(false); 

            Time.timeScale = 1f;
        }
    }
}
