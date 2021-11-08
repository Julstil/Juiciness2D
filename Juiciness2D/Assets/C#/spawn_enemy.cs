using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn_enemy: MonoBehaviour
{
    public GameObject[] objects;
    public float spawnRate = 2;
    public float nextSpawn = 2;

    public GameObject räv;
    public GameObject orm;

    GameObject rävObject;
    GameObject ormObject;


    private void Start()
    {
        SpawnRandom(); //första fienderna som spawnars in - Edvin
    }

    private void Update() //ifall tiden från starten av spelet har blivit mer än nextSpawn kommer ett nummer av ugglor spawnas in på ett random ställe på skärmen,
                          //ormen på sin plats och räven på sin plats - Edvin
    {
        if (Time.time > nextSpawn) 
        {
            nextSpawn = Time.time + spawnRate;
            
            SpawnRandom();

            if (rävObject == null) //räv- och ormObjecten är där för att skapa en skillnad mellan när objectet är null i scenen och null i inspectorn på objectet som
                                   //koden sitter på - Edvin
            {
               rävObject = Instantiate(räv, new Vector2(6.45f, -3.06f), Quaternion.identity);
            }

            if (ormObject == null)
            {
                ormObject = Instantiate(orm, new Vector2(-5.046929f, -3.505584f), Quaternion.identity);
            }
        }
    }

    public void SpawnRandom()
    {
        
        foreach (GameObject item in objects) //För varje gameObject som finns med i arrayn skapas gameObject på en random plats inom kamerans syn - Edvin
        {
            Instantiate(item, new Vector3(Random.Range(-6, 6), Random.Range(-3.5f, 4.3f), 0), transform.rotation);
        }

    }

}
