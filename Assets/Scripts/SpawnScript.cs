using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class SpawnScript : MonoBehaviour
{
    private float timer = 0;

    public float spawnRate = 2;

    //[FormerlySerializedAs("interval")] 
    public GameObject myPrefab;
    private float heightOffset = 9;

    // Start is called before the first frame update
    private void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    private void Update()
    {
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            spawnPipe();
            timer = 0;
        }
    }

    private void spawnPipe()
    {
        var lowestPoint = transform.position.y - heightOffset;
        var highestPoint = transform.position.y + heightOffset;


        Instantiate(myPrefab, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0),
            transform.rotation);
    }
}