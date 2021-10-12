using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("SampleScene"); //Laddar in scenen "SampleScene" om man trycker på Space i menyn. - Daniel
        }

        if (Input.GetKeyDown(KeyCode.O))
        {
            
        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            Application.Quit(); //Stänger ner programmet om man trycker på shift i menyn. - Daniel
        }
    }
}
