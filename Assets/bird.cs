using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird : MonoBehaviour
{
    public static GameObject Bird;
    public Rigidbody2D myRidgitbody;
    public float baseVelocity = 40;
    //public UImanager uiScript;
    public LogicScript logic;


    // Start is called before the first frame update
    private void Start()
    {

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "TopKillBox" || other.gameObject.name == "BottomKillBox" || other.gameObject.name == "Pipe (Top)" || other.gameObject.name == "Pipe (Bottom)")
        {
            Debug.Log("ur dead");
        }

        if (other.gameObject.name == "Score Trigger")
        {
            Debug.Log("adding score");
            logic.addScore();
        }
    }
    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown("space")) myRidgitbody.velocity = Vector2.up * baseVelocity;
    }
}