using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dubbelSkada : MonoBehaviour
{
    float dubbelSkadaTid = 0;
    public float dubbelSkadaPUTid = 7;
    int saveBulletDamage;
    Aim aim;

    // Start is called before the first frame update
    public void Start()
    {
        aim = GetComponent<Aim>();
        saveBulletDamage = aim.damage;
        this.enabled = false;
    }

    private void OnEnable()
    {
        print("Script started");
    }

    private void Update()
    {
        print("override update Started");
        dubbelSkadaTid += Time.deltaTime;

        if (dubbelSkadaTid <= dubbelSkadaPUTid)
        {
            aim.damage = saveBulletDamage * 2;
        }
        else
        {
            aim.damage = saveBulletDamage;
            this.enabled = false;
        }
    }


}
