using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird : MonoBehaviour
{
    public static GameObject Bird;
    public Rigidbody2D myRidgitbody;
    public float baseVelocity = 40;
    public LogicScript logic;
    

    private void Update()
    {
        if (Input.GetKeyDown("space")) myRidgitbody.velocity = Vector2.up * baseVelocity;
        
    }
    
    
    
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Finish"))
        {
            Debug.Log("Sir they hit the second tower");
            logic.addScore();
        }
    }
}