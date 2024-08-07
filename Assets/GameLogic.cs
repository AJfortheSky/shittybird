using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class GameLogic : MonoBehaviour
{
    public CapsuleCollider2D ScoreTrigger;
    public bird birb;
    
    // Start is called before the first frame update
    void Start()
    {
        birb = GameObject.FindGameObjectWithTag<bird>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ScoreTrigger.IsTouching(birb.FindGameObjectWithTag<Collider2D>())) {

        }

    }

}