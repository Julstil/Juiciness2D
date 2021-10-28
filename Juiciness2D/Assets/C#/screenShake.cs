using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class screenShake : MonoBehaviour
{
    Enemy enemy;
    public Vector2 frequency; //Kraften av skakningen. - Daniel
    public Vector2 amplitude; //Hur mycket det ska skakas. - Daniel
    Vector2 time = Vector2.zero; //Hur mycket tid som har gått. - Daniel
    static bool shouldShake; //En bool för ifall skärmen ska skaka eller inte. - Daniel
    static float shakeTime; //Hur länge det ska skaka. - Daniel

    // Start is called before the first frame update
    void Start()
    {
        shouldShake = false;
    }

    // Update is called once per frame
    void Update()
    {
        time = frequency;
        Vector3 localPos = transform.position;
        if (enemy.health = 0)
        {
            if (shakeTime >= 0)
            {
                shouldShake = true;
            }

        }

        shakeTime -= Time.deltaTime;
        //time = Time.fixeddeltaTime
        //gameobject.pos
        //shakepos.x = Sin(rid) * amplitud.x
        //lokalpos = shakepos
    }
}
