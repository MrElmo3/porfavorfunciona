using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CombatMenu : BasicMenu {

    private void Start() {
        
    }

    public void ScapeButton() {
        SceneManager.LoadScene("SampleScene");
    }

}
