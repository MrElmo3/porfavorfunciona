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

    public float transitionTime = 5.0f;
    public float letterTransTime = 0.2f;
    public float sceneTransTime = 10.0f;
    public AudioSource tickSound;
    public Image[] imagesOnScreen;
    [TextArea]
    public string[] textOnScreen = {
        "Erase una vez, ",
        "Esto no deberia mostrarse",
        "Probando salto de lineadweee"};
    void Start()
    {
        textMesh.fontStyle = FontStyle.Bold;
        StartCoroutine(DrawCOntroller());
    }


    IEnumerator DrawCOntroller(){
        for(int i = 0; i<textOnScreen.Length; i++){
        textMesh.text = "";
        yield return  StartCoroutine(DrawText(i)); 
        }
        SceneManager.LoadScene("SampleScene");

    }
    IEnumerator DrawText( int indexInArray){
        string showingInScreen = "";
        string finalString = this.textOnScreen[indexInArray];
        int i = 0;
        // WaitForSeconds delay = new WaitForSeconds(transitionTime/finalString.Length);
        WaitForSeconds delay = new WaitForSeconds(letterTransTime);
        WaitForSeconds endOfWordDelay = new WaitForSeconds(letterTransTime*1.5f);


        while( i<finalString.Length){
            showingInScreen += finalString[i];
            textMesh.text = showingInScreen;
            Debug.Log(textMesh.text);
            if (finalString[i] != ' ' && finalString[i] != '.') yield return delay;
            else if( finalString[i] == ' ') yield return endOfWordDelay;
            else {
                yield return endOfWordDelay;
                yield return endOfWordDelay;
                yield return endOfWordDelay;
            }
            i++;
            tickSound.Play();
        }

        showingInScreen += "...";
        textMesh.text = showingInScreen;
        tickSound.Play();
        Debug.Log(textMesh.text);
        yield return new WaitForSeconds(sceneTransTime);

    }

    private void ImagesManager( int indexTransition){

    }
}
