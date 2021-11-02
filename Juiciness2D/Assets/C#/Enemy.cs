using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health;
    int startHealth;
    public static int allPows = 0;
    float time;
    public float endDamage;

    public GameObject[] Pows = new GameObject[allPows];
    GameObject POW;

    public Animator owlAnim;
    public GameObject thisObject;

    private void Start()
    {
        startHealth = health ;
        int index = Random.Range(0, Pows.Length);
        POW = Pows[index];
        owlAnim.SetBool("Damage", false);
    }

    public void TakeDamage(int damage)
    {
        health -= damage;

        time += Time.deltaTime;
        if (thisObject != FindObjectOfType<goForward>())
        {
            owlAnim.SetBool("Damage", false);
        }

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
        screenShake.shakeTime = 0.2f; //Får skärmen att skaka i 0.2f. - Daniel
        //Destroy(gameObject, 1); - Edvin
    }
}
