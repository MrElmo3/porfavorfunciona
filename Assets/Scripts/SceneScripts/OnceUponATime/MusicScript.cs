using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicScript : MonoBehaviour
{
    public AudioSource music;

    private void Awake() {
        DontDestroyOnLoad( this.gameObject );
    }

    public void Play() {
        music.Play();
    }
}
