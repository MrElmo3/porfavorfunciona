using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLogic : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform playerTransform;
    public GameObject player;
    public float radioActivo;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown (0)) {  
            print ("The Left mouse button was pressed");  
            float mouseXvalue = Input.GetAxis ("Mouse X");  
            float mouseYvalue = Input.GetAxis ("Mouse Y");  

            //  new Vector3(mouseXvalue, mouseYvalue) 
            // print( "Mouse: "+mouseXvalue+" "+mouseYvalue);
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3 playerPosition = Camera.main.ScreenToWorldPoint(new Vector3(playerTransform.position.x, playerTransform.position.y));

            print( mousePosition.x +" "+ mousePosition.y+"\n"+playerPosition.x+" "+playerPosition.y);
            if( Vector3.Distance( playerPosition, mousePosition) 
                <= radioActivo ) popPlayer(); 
        } 
    }

    public void popPlayer(){
        player.GetComponent<MainMenuPlayer>().popPlayer();
        GetComponent<AudioSource>().Play();
    }
}
