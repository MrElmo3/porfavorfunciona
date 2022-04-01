using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameMenuController : MonoBehaviour
{ 
    public enum estados 
    {
        ClosedMenu = -1,
        PauseMenu = 0,
        SaveMenu = 1,
        OptionsMenu = 2,
        ExitMenu = 3,
        InventoryMenu = 4,
        StatsMenu = 5,
    }

    [SerializeField]
    private GameObject PauseMenu;

    [SerializeField]
    private GameObject BackgoundColor;

    [SerializeField]
    private GameObject InventoryMenu;

    public estados estado;

    private void Update() {

        switch(estado){
            case estados.ClosedMenu:
                if(Input.GetKeyDown(KeyCode.Escape)){
                    PauseMenu.SetActive(true);
                    estado = estados.PauseMenu;
                    BackgoundColor.SetActive(true);
                    PauseMenu.GetComponent<PauseMenu>().PauseGame();
                }

                else if(Input.GetKeyDown(KeyCode.Tab)){
                    estado = estados.InventoryMenu;
                    InventoryMenu.SetActive(true);
                }
                break;

            case estados.PauseMenu:
                if(Input.GetKeyDown(KeyCode.Escape)){
                    estado = estados.ClosedMenu;
                    PauseMenu.GetComponent<PauseMenu>().ResumeGame();
                    BackgoundColor.SetActive(false);
                }
                break;
            
            case estados.SaveMenu: //menu de guardado
                if(Input.GetKeyDown(KeyCode.Escape)){
                    estado = estados.ClosedMenu;
                    PauseMenu.SetActive(true);
                }
                break;
            
            case estados.OptionsMenu: // menu de opciones
                if(Input.GetKeyDown(KeyCode.Escape)){
                    estado = estados.ClosedMenu;
                    PauseMenu.SetActive(true);
                }
                break;
            
            case estados.ExitMenu: // menu de salida
                if(Input.GetKeyDown(KeyCode.Escape)){
                    estado = estados.ClosedMenu;
                    PauseMenu.SetActive(true);
                }
                break;
            
            case estados.InventoryMenu: // inventario(sin pausar el juego)
                if(Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.Tab)){
                    estado = estados.ClosedMenu;
                    InventoryMenu.transform.GetChild(1).GetComponent<Animator>().SetBool("open", false);
                }
                break;
            
            case estados.StatsMenu: // stats(sin pausar el juego)
                if(Input.GetKeyDown(KeyCode.Escape)){
                    estado = estados.ClosedMenu;
                }
                break;
        }
    }

    public void ChangeState(int nuevoEstado){
        estado = (estados)nuevoEstado;
    }
}
