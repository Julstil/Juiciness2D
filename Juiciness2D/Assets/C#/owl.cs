using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class owl : Enemy
{
    public Animator owlAnim;

    public float time = 0;
    public float endDamage = 0.3f;

    // Start is called before the first frame update
    public override void Start() //Lägger till att skada animationen inte är på från början - Edvin
    {
        base.Start();
        owlAnim.SetBool("Damage", false); 
    }

    // Update is called once per frame
    void Update() //räknar och stänger av animationen efter ett tag - Edvin
    {
        if (owlAnim.GetBool("Damage"))
        {
            time += Time.deltaTime;
        }
        if (time > endDamage)
        {
            time = 0;
            owlAnim.SetBool("Damage", false);
        }
    }

}
