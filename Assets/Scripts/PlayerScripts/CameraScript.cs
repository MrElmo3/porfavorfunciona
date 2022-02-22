using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {
    private Transform playerTarget;

    private float smoothTime = 0.5f;
    private Vector2 CameraVelocity;


    void Start() {
        playerTarget = GameObject.FindGameObjectWithTag("Player").transform;  
    }

    void Update() {

    }

    private void FixedUpdate() {
        float posX = Mathf.Round(Mathf.SmoothDamp(transform.position.x, playerTarget.position.x, ref CameraVelocity.x, smoothTime)*100) /100;
        float posY = Mathf.Round(Mathf.SmoothDamp(transform.position.y, playerTarget.position.y, ref CameraVelocity.y, smoothTime)*100) /100;

        transform.position = new Vector3(posX, posY, transform.position.z);
    }
}