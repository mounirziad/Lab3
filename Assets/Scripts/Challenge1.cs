using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Challenge1 : MonoBehaviour
{
    //Declares final challengescore variable to be calculated at end of program.
    private float challengescorevar = 0;

    //Declares module variable to be input by user.
    public float modules;
    //Declares readingmaterials variable to be input by user.
    public float readingmaterials;
    //Declares quizamount variable to be input by user.
    public float quizamount;
    //Declares assignmentamount variable to be input by user.
    public float assignmentamount;
    //Declares hasinstructortaught variable to be input by user.
    public bool hasinstructortaught = false;
    //Declares name of course variable to be input by user.
    public string nameofcourse;

    // Start is called before the first frame update
    void Start()
    {
        //Calls method to calculate challenge score before output method, that way accurate data is output. 
        CalculateChallengeScore();
        //Calls method to output to the console. 
        DisplayScore();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CalculateChallengeScore()
    {
        //clams final challengescore varaible so it does not exceed 10 or go below 0.
        Mathf.Clamp(challengescorevar, 0, 10);
        // Calculates modules as 15 percent of challengescore
        challengescorevar += modules * 0.15f;
        // Calculates reading materials as 30 percent of challengescore
        challengescorevar += readingmaterials * 0.30f;
        // Calculates quizamount as 15 percent of challengescore
        challengescorevar += quizamount * 0.15f;
        // Calculates assignmentamount materials as 30 percent of challengescore
        challengescorevar += assignmentamount * 0.30f;
        // If the instructor has taught the course before, the challengescore will increase by 1
        if (hasinstructortaught == true)
        {
            challengescorevar += 1;
        }

    }

    void DisplayScore()
    {
        //displays name of course
        Debug.Log("Name of course: ");
        Debug.Log(nameofcourse);
        //displays challenge score
        Debug.Log("Challenge Score: ");
        Debug.Log(challengescorevar);
    }

}
