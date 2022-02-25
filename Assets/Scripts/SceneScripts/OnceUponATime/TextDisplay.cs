using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TextDisplay : MonoBehaviour
{
    // Start is called before the first frame update
    // private TextMes
    public Text textMesh;

    public float transitionTime = 5.0f;
    [SerializeField]
    private string[] textOnScreen = {
        "Erase una vez, ",
        "Este es el texto 2",
        "Probando salto de linead<bl>weee"};
    void Start()
    {
        textMesh.text = "hola como estas";
        StartCoroutine(DrawCOntroller());

    }


    IEnumerator DrawCOntroller(){
        for(int i = 0; i<textOnScreen.Length; i++){
        yield return  StartCoroutine(DrawText(i)); 
        }
    }
    IEnumerator DrawText( int indexInArray){
        string showingInScreen = "";
        string finalString = this.textOnScreen[indexInArray].Replace("<bl>","\n");
        int i = 0;
        WaitForSeconds delay = new WaitForSeconds(transitionTime/finalString.Length);

        while( i<finalString.Length){
            showingInScreen += finalString[i];
            textMesh.text = showingInScreen;
            i++;
            yield return delay;
        }
        yield break;
    }
}
