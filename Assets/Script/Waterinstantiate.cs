using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waterinstantiate : MonoBehaviour
{

    public Transform[] spawnPoints;

    public GameObject objectToSpawn;

    public int numberOfObjects = 30;
    void Start()
    {
        //InvokeRepeating(nameof(SpawnObjects), 1, 1);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnObjects()
    {
        InvokeRepeating(nameof(Delay), .1f, 1f);
        
    }

    private void Delay()
    {
        for (int i = 0; i < numberOfObjects; i++)
        {
            // Pick a random spawn point
            int randomIndex = Random.Range(0, spawnPoints.Length);

            // Instantiate the object at the randomly selected point
            Instantiate(objectToSpawn, spawnPoints[randomIndex].position, spawnPoints[randomIndex].rotation);
        }
    }
}