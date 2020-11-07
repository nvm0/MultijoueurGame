using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMove : NetworkBehaviour
{
    void HandleMovement()
    {
        if(isLocalPlayer){
            float moveHor = Input.GetAxis("Horizontal");
            float moveVert = Input.GetAxis("Vertical");
            Vector3 movement = new Vector3(moveHor * 0.1f ,0, moveVert*0.1f);
            transform.position = transform.position + movement;
        }
    }

    void Update(){
        HandleMovement();
    }
}
