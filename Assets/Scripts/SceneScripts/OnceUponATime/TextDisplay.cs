using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class TextDisplay : MonoBehaviour
{
    // Start is called before the first frame update
    // private TextMes
    public Text textMesh;
    public AudioSource tickSound;

    public float transitionTime = 5.0f;
    public float letterTransTime = 0.2f;
    public float sceneTransTime = 10.0f;
    public Image[] imagesOnScreen;
    [TextArea]
    public string[] textOnScreen;

    void Start()
    {
        textMesh.fontStyle = FontStyle.Bold;
        textMesh.text = "";
        StartCoroutine(DrawCOntroller());
    }


    IEnumerator DrawCOntroller(){
        WaitForSeconds intial_delay = new WaitForSeconds(3.0f);
        yield return intial_delay;
        GameObject.FindGameObjectWithTag("Music").GetComponent<MusicScript>().Play();

        for(int i = 0; i<textOnScreen.Length; i++){
            yield return  StartCoroutine(DrawText(i)); 
        }
        SceneManager.LoadScene("SampleScene");

    }
    IEnumerator DrawText( int indexInArray){

        textMesh.text = "";
        string showingInScreen = "$"+this.textOnScreen[indexInArray]+"</color>";
        string finalString = this.textOnScreen[indexInArray];
        int charactersNumber = finalString.Length;
        // WaitForSeconds delay = new WaitForSeconds(transitionTime/finalString.Length);
        WaitForSeconds delay = new WaitForSeconds(letterTransTime);
        WaitForSeconds endOfWordDelay = new WaitForSeconds(letterTransTime*1.5f);

        // The last text must be different 
        if( indexInArray == textOnScreen.Length-1){
            textMesh.color = Color.red;
            textMesh.fontSize = 40;
        }

        int i = 0;
        while( i<charactersNumber){
            // showingInScreen += finalString[i];

            showingInScreen = showingInScreen.Substring(0, i) + 
            showingInScreen[i+1] + showingInScreen[i] + 
            showingInScreen.Substring(i+2);
            
            textMesh.text = showingInScreen.Replace("$","<color=#00000000>");

            //Debug.Log(textMesh.text);
            tickSound.Play();

            if (finalString[i] != ' ' && finalString[i] != '.') yield return delay;
            else if( finalString[i] == ' ') yield return endOfWordDelay;
            else {
                yield return endOfWordDelay;
                yield return endOfWordDelay;
                yield return endOfWordDelay;
            }

            i++;
        }

        showingInScreen = finalString+"...";
        textMesh.text = showingInScreen;
        tickSound.Play();
        //Debug.Log(textMesh.text);
        yield return new WaitForSeconds(sceneTransTime);

    }

    private void swap ( ref char a, ref char b){
        char c = a;
        a = b;
        b = c;
    }
    private void ImagesManager( int indexTransition){


    }
}
