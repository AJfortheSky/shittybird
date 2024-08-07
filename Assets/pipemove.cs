using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipemove : MonoBehaviour
{
    
    
    private float movespeed = 15;
    private float lifeTime = 10;
    private bool die = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * movespeed) * Time.deltaTime;

        lifeTime -=Time.deltaTime;

        if (lifeTime <= 0)
        {
            die = true;
        }
        if (die == true)
        {
            DestroyImmediate (gameObject, true);
        }
    }
}
