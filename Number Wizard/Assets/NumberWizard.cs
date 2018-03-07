using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class NumberWizard : MonoBehaviour
{

    // Use this for initialization
    int max;
    int min;
    int guess;
    public int maxGuessesAllowed = 5;

    public Text text;


    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        max = 1000;
        min = 1;
        NextGuess();

        print("======================");
        print("Welcome Number Wizard");
        print("Pick a Numer in Your Head, But Don't Tell Me!");



        print("The highest number you can pick is" + max);
        print("The lowest number you can pick is" + min);

        print("Is the numer higher or lower than " + guess);
        print("Up = higher,Down = Lower, Return = Equal");

      
    }


    // Update is called once per frame

    public void GuessLower() {
        max = guess;
        NextGuess();
    }
    public void GuessHigher() {
        min = guess;
        NextGuess();
    }

    void NextGuess()
    {
        guess = Random.Range(min, max+1);
        text.text = guess.ToString();
        maxGuessesAllowed = maxGuessesAllowed - 1;
        if (maxGuessesAllowed <= 0)
        {
            Application.LoadLevel("Win!");
        }
    }

}

