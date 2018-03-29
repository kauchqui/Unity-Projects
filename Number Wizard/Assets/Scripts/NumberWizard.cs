using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {
    int max = 1000;
    int min = 1;
    int guess = 500;
    // Storing the initial text and starting parameters
    void initialText()
    {
        max = max + 1;
        print("Welcome to number Wizard");
        print("Pick a number in your head, but don't tell me!");

        print("The highest number you may choose is " + max);
        print("The lowest number you may choose is " + min);
        startGuessing();
    }
    void nextGuess()
    {
        guess = (max + min) / 2;
        print("Higher or lower than " + guess);
    }
    void startGuessing()
    {
        print("Is the number higher or lower than "+ guess);
        print("Up arrow for higher, down for lower, return for equal");
    }
    // Use this for initialization
    void Start ()
    {
        initialText();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            nextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            nextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            print("I won!");
            max = 1000;
            guess = 500;
            min = 1;
            initialText();
        }
    }
}
