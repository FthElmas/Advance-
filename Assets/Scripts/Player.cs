using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody pBody;
    
    void Awake()
    {
        pBody = GetComponent<Rigidbody>();

    }  
    
    void FixedUpdate(){
        if (Input.GetMouseButton(0)){
            pBody.AddForce(new Vector3(0,50,0), ForceMode.Acceleration);
        }

        else if(Input.GetMouseButtonUp(0)){
            pBody.velocity *= 0.10f * Time.deltaTime;
        }
    }


 }
