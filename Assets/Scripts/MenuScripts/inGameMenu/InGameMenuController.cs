using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameMenuController : MonoBehaviour
{   
    [SerializeField]
    private GameObject PauseMenu;

    [SerializeField]
    private GameObject BackgoundColor;

    [SerializeField]
    private GameObject InventoryMenu;

    public int estado = -1;

    private void Update() {

        //hora de desarrollar una maquina de estados improvisada 
        //estado -1 -> menus cerrados
        //estado 0 -> Menu de pausa
        //estado 1 -> menu de guardado
        //estado 2 -> menu de opciones
        //estado 3 -> menu de salida
        //estado 4 -> menu de inventario
        //estado 5 -> menu de stats 


        switch(estado){
            case -1:
                if(Input.GetKeyDown(KeyCode.Escape)){
                    PauseMenu.SetActive(true);
                    estado = 0;
                    BackgoundColor.SetActive(true);
                    PauseMenu.GetComponent<PauseMenu>().PauseGame();
                }
                else if(Input.GetKeyDown(KeyCode.Tab)){
                    estado = 4;
                    InventoryMenu.SetActive(true);
                }
                    break;

            case 0: //menu de pausa
                if(Input.GetKeyDown(KeyCode.Escape)){
                    estado = -1;
                    PauseMenu.GetComponent<PauseMenu>().ResumeGame();
                    BackgoundColor.SetActive(false);
                }
                break;
            
            case 1: //menu de guardado
                if(Input.GetKeyDown(KeyCode.Escape)){
                    estado = 0;
                    PauseMenu.SetActive(true);
                }
                break;
            
            case 2: // menu de opciones
                if(Input.GetKeyDown(KeyCode.Escape)){
                    estado = 0;
                    PauseMenu.SetActive(true);
                }
                break;
            
            case 3: // menu de salida
                if(Input.GetKeyDown(KeyCode.Escape)){
                    estado = 0;
                    PauseMenu.SetActive(true);
                }
                break;
            
            case 4: // inventario(sin pausar el juego)
                if(Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.Tab)){
                    estado = -1;
                    InventoryMenu.transform.GetChild(1).GetComponent<Animator>().SetBool("open", false);
                }
                break;
            
            case 5: // stats(sin pausar el juego)
                if(Input.GetKeyDown(KeyCode.Escape)){
                    estado = -1;
                }
                break;
        }
    }

    public void ChangeState(int nuevoEstado){
        estado = nuevoEstado;
    }
}
