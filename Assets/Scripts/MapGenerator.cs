using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour
{
    
    [SerializeField]private GameObject prevCeiling;
    [SerializeField]private GameObject prevFloor;
    [SerializeField]private GameObject ceiling;
    [SerializeField]private GameObject floor;

    [SerializeField]private GameObject player;



    void Start()
    {
        
    }

    
    void FixedUpdate()
    {
        if(player.transform.position.x > floor.transform.position.x){
            var tempCeiling = prevCeiling;
            var tempFloor = prevFloor;
            prevCeiling = ceiling;
            prevFloor = floor;
            tempCeiling.transform.position += new Vector3(80,0,0);
            tempFloor.transform.position += new Vector3(80,0,0);
            ceiling = tempCeiling;
            floor = tempFloor;
        }
    }
}
