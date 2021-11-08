using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goForward : MonoBehaviour
{
    public Rigidbody2D rb2d;
    public float speed = 20;
    public Vector3 direction;
    public int bulletDamage = 25;


    // Start is called before the first frame update
    public virtual void Start()
    {
        rb2d.velocity = direction * speed; // -hastigheten av skottet är lika med dess riktning gånger speed som är satt till 20 - Edvin
    }

    public virtual void OnTriggerEnter2D(Collider2D hitInfo)
    {
        owl Owl = hitInfo.GetComponent<owl>(); //Skapar en referens till owl scripten på föremålet den träffar - Edvin
        Enemy enemy = hitInfo.GetComponent<Enemy>(); //Skapar en referens till enemy scripten på föremålet den träffar - Edvin
        if (enemy != null) //ifall obijektet med denna script inte inte träffar ett obijekt med enemy scripten eller med en script som ärver från den händer detta:
        {
            enemy.TakeDamage(bulletDamage); //obijektet med enemy scripten eller med en script som ärver från den kommer att ta skada = bulletDamage - Edvin
            Owl.owlAnim.SetBool("Damage", true); // sätter på skada animationen på ugglan - Edvin
        }
        
        if (hitInfo.tag == "dSC") // vid kollision av ett obiject med tagen dSC händer detta:
        {
            dubbelSpeedClick dSC = FindObjectOfType<dubbelSpeedClick>(); //Hittar obijektet med dubbelSpeedClick skrippten - Edvin
            dSC.enabled = true; //Startar dubbelSpeedClick scripten - Edvin
        }
        
        if (hitInfo.tag == "DS") // vid kollision av ett obiject med tagen DS händer detta:
        {
            dubbelSkada DS = FindObjectOfType<dubbelSkada>(); //Hittar obijektet med dubbel skada skrippten - Edvin
            DS.enabled = true; //Startar dubbel skada scripten - Edvin
        }
            Destroy(gameObject); //förstör skott spriten vid kollision med en trigger - Edvin
    }

}
