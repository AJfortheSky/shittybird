using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird : MonoBehaviour
{
    public static GameObject Bird;
    public Rigidbody2D myRidgitbody;
    public float baseVelocity = 40;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            myRidgitbody.velocity = Vector2.up * baseVelocity;
            
        }
    }
}
