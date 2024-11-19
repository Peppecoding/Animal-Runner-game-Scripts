using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SpwanManager : MonoBehaviour
{
     public GameObject[ ] animalPrefabs;
     private float spawnRangeX = 10;
     private float StartDelay = 2;
     private float SpwanInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating ("SpwanRandomAnimal", StartDelay,SpwanInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpwanRandomAnimal ()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX,spawnRangeX),0,20);

        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}
