using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Moving : MonoBehaviour
{
   public float speed = 0.01f;
   public float deg = 0f; 
   public float angeleinc = 0.3f;
   public float Right = 1f;
   public Vector3 Scalefactor = new Vector3(0.01f,0.01f,0.01f); 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //deg = deg + angeleinc;
        transform.Translate(0f,0f,speed * Time.deltaTime);
        //transform.position += new Vector3(0,speed,0);
        //transform.rotation = Quaternion.Euler(new Vector3(0,0,0));
        //transform.right += new Vector3(0,0,0);
        //transform.localScale = new Vector3(1,1,1);
    
    }
}
