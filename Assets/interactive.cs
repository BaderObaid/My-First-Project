using System.Collections;
using System.Collections.Generic;
using UnityEditor.Callbacks;
using UnityEngine;

public class interactive : MonoBehaviour
{
    // Start is called before the first frame update

   
   public float MoveSpeed;
   private float directionX, directionZ;
   
   public float speed = 0.9f;
   public float deg = 0f; 
   public float angeleinc = 0.2f;
   public float Right = 1f;

    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
        
        deg = deg + angeleinc;
        //transform.position += new Vector3(speed,0,0);
        // transform.Translate(Vector3.forward * speed * Time.deltaTime);
        // Vector3 movementDriection = new Vector3(Input.GetAxis( "Horizontal"), 0, Input.GetAxis("Vertical"));        
        
        if (Input.GetKeyDown(KeyCode.W))
        {
          transform.position += new Vector3(speed,0,0);
            
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
          transform.position += new Vector3(-speed,0,0);
            
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
          //transform.rotation = new Vector3(deg,0,0);
          transform.rotation = Quaternion.Euler(new Vector3(0,deg,0));  
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
          transform.rotation = Quaternion.Euler(new Vector3(0,deg ,0));  
            
          }
    // directionX = Input.GetAxis("Horizental") * MoveSpeed; 
    // directionZ = Input.GetAxis("Vertical") * MoveSpeed; 
        
        
        
  
    

  //  }     
  //       //deg = deg + angeleinc;
  //       //transform.Translate(0f,0f,speed * Time.deltaTime);
  //       //transform.position += new Vector3(0,directionX,0);
  //      // transform.rotation = Quaternion.Euler(new Vector3(0,directionZ,0));
  //       //transform.right += new Vector3(0,0,0);
  //       //transform.localScale = new Vector3(1,1,1);

  //       if (Input.GetKeyDown(KeyCode.W))
  //       {
  //         transform.position += new Vector3(speed,0,0);
            
  //       }

  //       if (Input.GetKeyDown(KeyCode.S))
  //       {
  //         transform.position += new Vector3(-speed,0,0);
            
  //       }

  //       if (Input.GetKeyDown(KeyCode.D))
  //       {
  //         transform.right += new Vector3(speed,0,0);
            
  //       }

  //       if (Input.GetKeyDown(KeyCode.D))
  //       {
  //         transform.right += new Vector3(speed,0,0);
            
        
    }
}
