using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoreCalc : MonoBehaviour
{
    public float modules = 15;
    public float materials = 30;
    public float quizzes = 15;
    public float assignments = 30;
    public bool taught = true;
    public string courseName = "Course Name";
    private int challengeScore = 0;


    void Start()
    {
        //check if course was taught before
        if (taught == true)
        {
            //add individual scores and adjust for weights
            challengeScore = (int)(((modules * 0.15f) + (materials * 0.3f) + (quizzes * 0.15f) + (assignments * 0.3f))+1.0f);
        }
        else
        {
            //add invididual scores and adjust for weights
            challengeScore = (int)(((modules * 0.15f) + (materials * 0.3f) + (quizzes * 0.15f) + (assignments * 0.3f)));
        }
        //if max value exceeds 10, set score to 10, otherwise use regular score
        if (challengeScore > 10)
        {
            challengeScore = 10;
            Debug.LogFormat("{0}: {1}", courseName, challengeScore);
        }
        else
        {
            Debug.LogFormat("{0}: {1}", courseName, challengeScore);
        }


    }
}