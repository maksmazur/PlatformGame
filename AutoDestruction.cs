using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDestruction : MonoBehaviour
{

    public float timeToDestruction;
   
    void Start()
    {
        Destroy(this.gameObject, timeToDestruction);
      
       
    }

    
    void Update()
    {
        
    }
}
