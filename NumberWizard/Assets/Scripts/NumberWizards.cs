using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizards : MonoBehaviour {

    int m_max;
    int m_min;
    int m_guess;

    void Start () {

        StartGame();
       
	}
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            m_min = m_guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {        
            m_max = m_guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            print("I Won!");
            StartGame();
        }
    }

    private void StartGame()
    {
        m_max = 1000;
        m_min = 1;
        m_guess = 0;

        print("=============================");
        print("Here is the NumberWizard Game");
        print("Pick a number within rang of " + m_max + " and " + m_min);
        print("Is the number higher or lower than: " + m_guess);
        print("Press up arrow for higher, down arrow for lower, return = qeual!");

        m_max += 1;

    }

    private void NextGuess()
    {
        m_guess = (m_max + m_min) / 2;
        print("Higher or Lower: " + m_guess);
        print("Up arrow for Higher, down arrow for Lower, Enter for qeual!");
    }
}