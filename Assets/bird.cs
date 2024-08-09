using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird : MonoBehaviour
{
    public static GameObject Bird;
    public Rigidbody2D myRidgitbody;
    public float baseVelocity = 40;
    public LogicScript logic;
    



    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "TopKillBox" || other.gameObject.name == "BottomKillBox" || other.GameObject.name == "Pipe (Top)" || otherGameObject.name == "Pipe (Bottom)")
        {
            
        }
        if (other.CompareTag("Finish"))
        {
            Debug.Log("Sir they hit the second tower");
            logic.addScore();
        }
    }
    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown("space")) myRidgitbody.velocity = Vector2.up * baseVelocity;
        
    }
    
    
    

}