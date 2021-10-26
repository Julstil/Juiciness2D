using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class screenShake : MonoBehaviour
{
    public Vector2 frequency; //Kraften av skakningen. - Daniel
    public Vector2 amplitude; //Hur mycket det ska skakas. - Daniel
    Vector2 time = Vector2.zero; //Hur mycket tid som har gått. - Daniel
 static bool shouldShake; //En bool för ifall skärmen ska skaka eller inte. - Daniel
 static float shakeTime; //Hur länge det ska skaka. - Daniel

    // Start is called before the first frame update
    void Start()
    {
        
    }
     
    // Update is called once per frame
    void Update()
    {

        //time = Time.fixeddeltaTime
        //gameobject.pos
        //shakepos.x = Sin(rid) * amplitud.x
        //lokalpos = shakepos
    }
}
