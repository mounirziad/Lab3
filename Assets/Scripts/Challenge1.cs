using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Challenge1 : MonoBehaviour
{
    private float challengescorevar = 0;


    public float modules;

    public float readingmaterials;

    public float quizamount;

    public float assignmentamount;

    public bool hasinstructortaught = false;

    public string nameofcourse;

    // Start is called before the first frame update
    void Start()
    {
        CalculateChallengeScore();
        DisplayScore();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CalculateChallengeScore()
    {
        Mathf.Clamp(challengescorevar, 0, 10);
      
        challengescorevar += modules * 0.15f;
        challengescorevar += readingmaterials * 0.30f;
        challengescorevar += quizamount * 0.15f;
        challengescorevar += assignmentamount * 0.30f;
        if (hasinstructortaught == true)
        {
            challengescorevar += 1;
        }

    }

    void DisplayScore()
    {
        Debug.Log("Name of course: ");
        Debug.Log(nameofcourse);
        Debug.Log("Challenge Score: ");
        Debug.Log(challengescorevar);
    }

}
