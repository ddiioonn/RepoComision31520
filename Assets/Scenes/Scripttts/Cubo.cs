using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubo : MonoBehaviour
{
    public int vidaCubo = 1;
      public float speed = 0.5f;
      
    public float direccion= 0.5f;// esto va??
    
    void Start()
    {
        vidaCubo = 10;
         transform.position += new Vector3(x:speed,y:0,z:speed);
    
    }


    // Update is called once per frame
    void Update()
    {
         
        
        MovCubo ();// actualiza constantemente MovCubo??
        CurarCubo ();
        DañarCubo ();

        Debug.Log (vidaCubo);
    }
   public void MovCubo ()
    {

         transform.Translate (new Vector3(x:speed,y:0,z:speed)* Time.deltaTime);  
           transform.localScale += (new Vector3(x:0.1f,y:direccion,z:1f)* Time.deltaTime);

        }

           void CurarCubo ()
    {
 transform.localScale += (new Vector3(x:1f,y:1,z:1f));// afecta el tamaño 
        vidaCubo += 2;
        }
           void DañarCubo ()
        
    {

transform.localScale -= (new Vector3(x:1f,y:1,z:1f)); 
        vidaCubo -= 1;
        }
}
