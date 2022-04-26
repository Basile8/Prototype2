using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour

{
public GameObject[] AnimalsPrefabs;
public float startDelay = 1f;
public float frequency = 2.5f;

    // Start is called before the first frame update
    void Start()
    {
    InvokeRepeating("SpawnAnimals", startDelay, frequency);
    }
    void SpawnAnimals(){
        int animalIndex = Random.Range(0, AnimalsPrefabs.Length);
        float randomX = Random.Range(-25,25);
        Instantiate(AnimalsPrefabs[animalIndex],new Vector3(randomX,0,30), AnimalsPrefabs[animalIndex].transform.rotation);
    }
    // Update is called once per frame
    void Update()
    {

    }

}
