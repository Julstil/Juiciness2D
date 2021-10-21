using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int score = 0;
    public static int highScore = 0;
    public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        highScore = PlayerPrefs.GetInt("highscore", 0); //Kollar om det finns ett highscore sparat på datorn ovh tar det värdet. Om det inte finns något värde sätts den till 0. - Daniel
    }

    // Update is called once per frame
    void Update()
    {
        if (score > highScore)
        { 
            highScore = score; //Gör att highScore får scores värde om score har ett högre värde. - Daniel
            PlayerPrefs.SetInt("highscore", score); //Sparar scores värde när score som highScore när den är större än highScore. - Daniel
        }
        scoreText.text = "Score:" + score; //Skriver ut "Score:" och score variabeln, på så sätt ser man hur mycket poäng man har. - Daniel
    }
}
