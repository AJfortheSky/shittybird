using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class SpawnScript : MonoBehaviour
{
    private float timer = 0;
    [FormerlySerializedAs("interval")] public float spawnRate = 1;

    public GameObject myPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            
            timer = timer + Time.deltaTime;

        }else
        {

            spawnPipe();
            timer = 0;
        }

        
        
    }

    void spawnPipe()
    {
        Instantiate(myPrefab, transform.position, transform.rotation);
    }
}
