using UnityEngine;
using Logic;

public class CollisionManager : MonoBehaviour
{
    public CapsuleCollider2D collider;



    private void OnCollisionEnter(Collision2D collision)
    {
        if (collision.collider.IsTouchingLayers(3)) LogicManager.addScore();
    }
}