using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movobject1 : MonoBehaviour
{
      
  
 
    public int scale = 2;
    public float speed = 1f;
      public float alto = 0.5f;
    
    void Start()
    {
        Vector3 position = transform.position ;
    }

    // Update is called once per frame
    void Update()
    {
  
         transform.Translate (new Vector3(x:speed,y:0,z:speed)* Time.deltaTime);  
           transform.localScale = (new Vector3(x:1f,y:alto,z:1f)); 
        
    }
}
