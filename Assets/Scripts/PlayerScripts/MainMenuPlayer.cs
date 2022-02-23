using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuPlayer : MonoBehaviour
{
    
    private Animator animator;
    private Rigidbody2D Rigidbody2D;

    private const float TimeMovementConstant = 0.5f;
    private float TimeMovement = TimeMovementConstant;
    private int direction = 1;
    private float playerVelocity = 1.2f;

    void Start()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        /*
        1 izquierda
        2 abajo
        3 derecha
        4 arriba
        */
        switch(direction){
            case 1:
                Rigidbody2D.velocity = new Vector2(-1,0)*playerVelocity;
                animator.SetFloat("xAxis", -1);
                animator.SetFloat("yAxis", 0);

                if(TimeMovement > 0.0f){
                    TimeMovement -= Time.deltaTime;
                    break;
                }

                direction++;
                TimeMovement = TimeMovementConstant;
                break;
            
            case 2:
                Rigidbody2D.velocity = new Vector2(0,-1)*playerVelocity;
                animator.SetFloat("xAxis", 0);
                animator.SetFloat("yAxis", -1);

                if(TimeMovement > 0.0f){
                    TimeMovement -= Time.deltaTime;
                    break;
                }
                
                direction++;
                TimeMovement = TimeMovementConstant;
                break;
            
            case 3:
                Rigidbody2D.velocity = new Vector2(1,0)*playerVelocity;
                animator.SetFloat("xAxis", 1);
                animator.SetFloat("yAxis", 0);

                if(TimeMovement > 0.0f){
                    TimeMovement -= Time.deltaTime;
                    break;
                }
                
                direction++;
                TimeMovement = TimeMovementConstant;
                break;
            
            case 4:
                Rigidbody2D.velocity = new Vector2(0,1)*playerVelocity;
                animator.SetFloat("xAxis", 0);
                animator.SetFloat("yAxis", 1);

                if(TimeMovement > 0.0f){
                    TimeMovement -= Time.deltaTime;
                    break;
                }
                
                direction = 1;
                TimeMovement = TimeMovementConstant;
                break;
        }
    }
}
