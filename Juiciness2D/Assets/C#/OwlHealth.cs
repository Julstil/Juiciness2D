using UnityEngine;
using System.Collections;
//den här koden är ugglans hp 
//Morgan
public class OwlHealth: MonoBehaviour
{

    public int maxHealth = 100;
    public int curHealth = 100;



    public float healthBarLength;


    // Use this for initialization
    void Start()
    {

        healthBarLength = 0;

    }

    // Update is called once per frame
    void Update()
    {

        AddjustCurrentHealth(0);

    }

    void OnGUI()
    {

        GUI.Box(new Rect(10, 10, healthBarLength, 20), curHealth + "/" + maxHealth);

    }

    public void AddjustCurrentHealth(int adj)
    {

        curHealth += adj;

        if (curHealth < 0)
            curHealth = 0;

        if (curHealth > maxHealth)
            curHealth = maxHealth;

        if (maxHealth < 1)
            maxHealth = 1;


        healthBarLength = (0) * (curHealth / (float)maxHealth);

    }
}