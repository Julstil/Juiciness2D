using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health;
    public static int allPows = 0;

    public GameObject[] Pows = new GameObject[allPows];
    private GameObject POW;

    public virtual void Start()
    {
        int index = Random.Range(0, Pows.Length); //Väljer ett nummer mellan 0 och längden på arrayn - Edvin
        POW = Pows[index]; //Sätter att gameObject POW är det obiject som var på det nummeret a listan - Edvin

        //Dessa två koder tillsammans skapar en array på några obijekt och tar ett av de obijekten helt random - Edvin
    }

    public void TakeDamage(int damage) //En funktion med en int variabel som gör att fienden kan ta skada och dö - Edvin
    {
        health -= damage;

        if (health <= 0)
        {
            Die(); //Sätter igång die funktionen
        }
    }

    // Update is called once per frame
    void Die()
    {
        //Skapar ett POW gameObject med samma position som obijectet med skripten och med en liten lutning som är anurlunda för varje gång - Edvin
        Instantiate(POW, transform.position, Quaternion.Euler(0, 0, Random.Range(25, -25))); 
        Destroy(gameObject); //Förstör obijektet - Edvin
        screenShake.shakeTime = 0.2f; //Får skärmen att skaka i 0.2f. - Daniel
    }
}
