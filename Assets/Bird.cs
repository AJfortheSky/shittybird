using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Bird : MonoBehaviour
{
    public GameObject birdPlayer;
    public Rigidbody2D myRidgitbody;
    public float baseVelocity = 40;
    public LogicScript logic;
    public UImanager UI;

    // Start is called before the first frame update
    private void Start()
    {

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "TopKillBox" || other.gameObject.name == "BottomKillBox" || other.gameObject.name == "Pipe (Top)" || other.gameObject.name == "Pipe (Bottom)")
        {
            UI.gameOver();
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
        InputManager();
        RotationManager();
    }


    private void InputManager()
    {
        if (Input.GetKeyDown("space")) myRidgitbody.velocity = Vector2.up * baseVelocity;
    }

    private void RotationManager()
    {

        if (myRidgitbody.velocity.y > 0 && birdPlayer.transform.rotation.y > -40)
        {
            birdPlayer.transform.Rotate(0f, 0f, -2f);
            
        }
        if (myRidgitbody.velocity.y < 0 && birdPlayer.transform.rotation.y > 40)
        {
            birdPlayer.transform.Rotate(0f, 0f, 2f);
            
        }

    }
}
