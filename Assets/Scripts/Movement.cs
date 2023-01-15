using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    void FixedUpdate(){
        transform.position += new Vector3(5f * Time.deltaTime, 0, 0);
        
    }
    
}
