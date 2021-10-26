using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    public static BackgroundMusic BgMusic;

    private void Awake()
    {
       //Om bakgrundsmusiken redan exsisterar kommer musiken förstöras.
        if (BgMusic != null && BgMusic != this)
        {
            Destroy(this.gameObject);
            return;
        }
        //Detta gör så att Bakgrundsmusiken sen vid nästa scene inte försvinner.
        BgMusic = this;
        DontDestroyOnLoad(this);
    }

}
