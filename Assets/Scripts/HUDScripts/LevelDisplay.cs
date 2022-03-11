using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelDisplay : MonoBehaviour
{
    [SerializeField] GameObject PlayerTarget;
    [SerializeField] Text textLevel;

    private int level;

    private void Start() {
        level = PlayerTarget.GetComponent<PlayerStadistics>().level;
    }

    private void Update() {
        if(level != PlayerTarget.GetComponent<PlayerStadistics>().level){
            level = PlayerTarget.GetComponent<PlayerStadistics>().level;
        }

        //escribiendo en el texto
        textLevel.text = level.ToString(); 
    }
}
