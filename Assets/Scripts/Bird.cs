using UnityEngine;
using UnityEngine.Serialization;


public class Bird : MonoBehaviour
{
    public GameObject birdPlayer;
    public Rigidbody2D myRigidbody2D;
    public float baseVelocity = 40;
    public LogicScript logic;
    public UImanager ui;
    public Pipemove pipe;


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "TopKillBox" || other.gameObject.name == "BottomKillBox" || other.gameObject.name == "Pipe (Top)" || other.gameObject.name == "Pipe (Bottom)")
        {
            ui.gameOver();
        }

        if (other.gameObject.name == "Score Trigger")
        {
            Debug.Log("adding score");
            logic.addScore();
            pipe.trackScore();
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
        if (Input.GetKeyDown("space"))
        {
            Debug.Log("Space pressed");
            myRigidbody2D.velocity = Vector2.up * baseVelocity;
        }
    }

    private void RotationManager()
    {

        if (myRigidbody2D.velocity.y > 0 && birdPlayer.transform.rotation.y > -40)
        {
            birdPlayer.transform.Rotate(0f, 0f, -2f);
            
        }
        if (myRigidbody2D.velocity.y > 0 && birdPlayer.transform.rotation.y > 40)
        {
            birdPlayer.transform.Rotate(0f, 0f, 2f);
            
        }

    }
}
