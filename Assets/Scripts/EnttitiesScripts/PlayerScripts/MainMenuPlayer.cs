using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuPlayer : MonoBehaviour
{
    [SerializeField]
    private Transform[] nodes;
    
    private Animator animator;
    private Transform[] vertexOfSquare;

    private int direction = 1;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {   

        Vector3 nodoDireccion = nodes[direction-1].position;

        if(Vector3.Distance(nodoDireccion, transform.position) < 0.11f){
            if(direction == 4) direction = 1;
            else direction++;
        }

        Vector3 velocity = Vector3.Normalize((nodoDireccion - transform.position));
        changeAnimation(velocity);
        transform.position = transform.position + new Vector3(velocity.x, velocity.y, velocity.z) * Time.deltaTime;


    }

    private void changeAnimation(Vector3 direction){
            animator.SetBool("isMoving", true);
        if(Mathf.Abs(direction.x) > Mathf.Abs(direction.y)){
            animator.SetFloat("yAxis", 0);
            animator.SetFloat("xAxis", direction.x/Mathf.Abs(direction.x));

        }

        else{
            animator.SetFloat("yAxis", direction.y/Mathf.Abs(direction.y));
            animator.SetFloat("xAxis", 0);
        }
        
    }
}
