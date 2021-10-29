using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn_enemy: MonoBehaviour
{
    public GameObject[] objects;

    private void Start()
    {
        SpawnRandom();
    }
    public void SpawnRandom()
    {
        
        foreach (GameObject item in objects)
        {
            Instantiate(item, new Vector3(Random.Range(-6, 6), Random.Range(-3.5f, 4.3f), 0), transform.rotation);
        }

    }
}
