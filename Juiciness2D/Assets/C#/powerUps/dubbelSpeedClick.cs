using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dubbelSpeedClick : Aim
{
    float time;
    public float dSC = 7;

    // Start is called before the first frame update
    void Start()
    {
        this.enabled = false;
    }

    private void OnEnable()
    {
        time = 0;
    }

    public override void Update()
    {
        base.Update();
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
           shoot();
        }

        time += Time.deltaTime;

        if (time >= dSC)
        {
            this.enabled = false;
        }
    }
}
