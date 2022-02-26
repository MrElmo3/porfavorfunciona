using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicScript : MonoBehaviour
{
    public AudioSource music;

    private void Awake() {
        DontDestroyOnLoad( this.gameObject );
    }

    private void Start() {
        music.Play();
    }
}
