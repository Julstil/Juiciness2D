using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goForward : MonoBehaviour
{
    public Rigidbody2D rb2d;
    public float speed = 20;
    public Vector3 direction;

    // Start is called before the first frame update
    void Start()
    {
        rb2d.velocity = direction * speed;
    }

    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
     
       print(hitInfo.name);
       Destroy(gameObject);
     
    }


}
