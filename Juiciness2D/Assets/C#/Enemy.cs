using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health;
    public int startHealth;
    public static int allPows = 0;

    public GameObject[] Pows = new GameObject[allPows];
    GameObject POW;

    private void Start()
    {
        health = startHealth;
        int index = Random.Range(0, Pows.Length);
        POW = Pows[index];
    }

    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Die();
        }
    }

    // Update is called once per frame
    void Die()
    {
        Instantiate(POW, transform.position, Quaternion.Euler(0, 0, Random.Range(25, -25)));
        Destroy(gameObject);

        //Destroy(gameObject, 1); - Edvin
    }
}
