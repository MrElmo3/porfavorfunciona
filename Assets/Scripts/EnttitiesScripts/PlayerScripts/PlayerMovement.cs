using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    private float yAxis = 0;
    private float xAxis = 0;
    private float playerVelocity = 1.2f;
    public bool isMoving;
    
    [SerializeField]
    private Animator animator;
    private Rigidbody2D Rigidbody2D;
    private GameObject CharacterArmor;
    void Start()
    {
        // animator = GetComponent<Animator>();
        Rigidbody2D = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        yAxis = Input.GetAxisRaw("Vertical");
        xAxis = Input.GetAxisRaw("Horizontal");

        if(yAxis != 0f || xAxis != 0f){ 
            isMoving = true;
        }
        else{
            isMoving = false;
        }
        

        animator.SetFloat("xAxis", xAxis);
        animator.SetFloat("yAxis", yAxis);
        animator.SetBool("isMoving", isMoving);

        for(int i =0; i< transform.childCount; i++){
            transform.GetChild(i).GetComponent<Animator>().SetFloat("xAxis", xAxis);
            
        }
    }


    private void FixedUpdate() {
        Rigidbody2D.velocity = (new Vector2(xAxis, yAxis)) * playerVelocity;
    }
}
