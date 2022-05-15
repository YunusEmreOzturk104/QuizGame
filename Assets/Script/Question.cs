using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Question
{
    public string QuestionName, answerA, answerB, answerC, answerD;
    public int answer;
    public Question(string Question,string answer1,string answer2,string answer3,string answer4,int ans)
    {
        QuestionName = Question;
        answerA = answer1;
        answerB = answer2;
        answerC = answer3;
        answerD = answer4;
        answer = ans;
    }
}

    
