using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 12;
    private float spawnPositionZ = 30;


    +
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimals", 2, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    void SpawnRandomAnimals()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPosition = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPositionZ);

        //int animalIndex = Random.Range(0, 3); 
        //when 'S' is pressed, this sets the animalIndex figure to randomize within the range of available items in the array starting at 0 and ending before 3 (it doesnt use 3).
        //'animalPrefabs.Length' sets the number of possible items to circle through as the number of the animalPrefabs array.

        //Instantiate(animalPrefabs[animalIndex], new Vector3(0, 0, 30), animalPrefabs[animalIndex].transform.rotation); //creates instances of animalPrefabs at position (0,0,30)

        Instantiate(animalPrefabs[animalIndex], spawnPosition, animalPrefabs[animalIndex].transform.rotation);
    }
}
