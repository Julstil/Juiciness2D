using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aim : MonoBehaviour
{
    public GameObject acornBullet;
    public Transform firePoint;
    public AudioSource shooting;
    public AudioClip shot;
    public int damage = 25;

    private void Start()
    {
        shooting.clip = shot;
    }

    // Update is called once per frame
    public virtual void Update()
    {
        Vector3 mouse = Input.mousePosition; //Skapar en lokal variabel som håller musens position i datorn i en Vector3 - Edvin

        mouse.z = 10;
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(mouse); 
        //Sätter in musen med tio unity enheter i z axeln för att sedan kunna sätta in musen i Unity världen med ScreenToWorldPoint - Edvin

        //print(mousePos); //skriver ut musens position i världen för att se att det funkar - Edvin

        float vinkel = Mathf.Atan2((mousePos.y - transform.position.y), (mousePos.x - transform.position.x))* Mathf.Rad2Deg -90;
        /*  
         * Skapar en lokal variabel som får vinkeln mellan musen och kanonen i en enhetscirkel med hjälp av arctan 2 som man skriver in ett A värde delat med ett B värde.
         * A värdet är lika med delta y, y2 är musens y position och y1 är kanonens y position.
         * B värdet är lika med delta x, x2 är musens x position och x1 är kanonens x position.
         * Arctan använder sig dock av radier och inte grader så jag multiplicera med Mathf.Rad2Deg för att få skälva graderna på vinkeln.
         * -90 är där som en offset för att få kanonen att peka uppåt och inte åt vänster - Edvin 
         */

        transform.rotation = Quaternion.Euler(0, 0, vinkel); //sätter in vinkeln i kanonens z rotation

        if (Input.GetKeyDown(KeyCode.Mouse0)) //Vänster klick
        {
            shoot();
        }

    }

    public void shoot()
    {

        // Shooting logic
        goForward Bullet = Instantiate(acornBullet, firePoint.position, firePoint.rotation).GetComponent<goForward>(); //Skapar ett material på firepoints position och rotation från scripten goForward - Edvin
        Bullet.direction = transform.up; //skottet går framåt då y-axeln är det håll som kanonen kollar åt och up - Edvin
        Bullet.bulletDamage = damage;
        shooting.Play(); //spelar skottljud

    }
}
