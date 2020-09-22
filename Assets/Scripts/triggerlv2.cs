using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerlv2 : MonoBehaviour
{
    public Transform cameraTransform; 
    private Transform cameraFocusTarget;
    bool FollowCircle;

    void Start(){
        FollowCircle = false;
    }

    //Automatically happen when something w/ rigidbody2d enters the trigger
    void OnTriggerEnter2D(Collider2D activator){
        if(activator.tag == "Disappear" && FollowCircle == false){
        FollowCircle = true;
        }
        if(FollowCircle == true){
        //Debug.Log(activator.name + "somthing entered the trigger");
        cameraFocusTarget = activator.transform; //start camera following this object

        }
       

    }
    //Automatically happen when something with rigidbody2D exits the trigger
    void OnTriggerExit2D(Collider2D activator){
        //if this object exited the trigger, stop the camera from following it
        if(activator.transform == cameraFocusTarget){
            FollowCircle = false;
            cameraFocusTarget = null; //empty out the value
        }
    }
    void Update(){
        if(cameraFocusTarget != null && FollowCircle == true ){//only if it has something to follow
             //Move the camera to focus on the object that entered this trigger
        cameraTransform.position = cameraFocusTarget.position + new Vector3 (0f, 0f, -10f);
        }
       
    }
}
