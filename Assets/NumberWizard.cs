using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int min = 1;
    int max = 1000;
    int guess = 500;
    
    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        min = 1;
        max = 1000;
        guess = 500;
        max ++;
        Debug.Log("Welcome to Number Wizard!");
        Debug.Log("Pick a number.");
        Debug.Log("The lowest number you can choose is " + min);
        Debug.Log("The highest number you can choose is " + max);
        Debug.Log("Is your number higher or lower than " + guess + "?");
        Debug.Log("Press Up Arrow for higher, Down Arrow for lower or Return if it's the correct number.");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            GuessNext();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            GuessNext();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("I found the correct number!");
            StartGame();
        }
    }

    void GuessNext()
    {
        guess = (min + max) / 2;
        Debug.Log("Is your number " + guess +"? If not, is your number higher or lower than it?");
    }
}
