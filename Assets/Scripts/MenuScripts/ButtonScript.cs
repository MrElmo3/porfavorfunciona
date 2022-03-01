using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public AudioClip HLSound;
    public AudioClip PressedSound;

    public void Press(){
        Camera.main.GetComponent<AudioSource>().PlayOneShot(PressedSound);
    }

    public void HL(){
        Camera.main.GetComponent<AudioSource>().PlayOneShot(HLSound);
    }
}
