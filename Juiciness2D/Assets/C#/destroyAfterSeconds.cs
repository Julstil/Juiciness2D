using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyAfterSeconds : MonoBehaviour
{
    public float timeToDie;
    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, timeToDie);
    }
}
