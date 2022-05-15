using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Competition : MonoBehaviour
{
    public TextMeshProUGUI questionName, answerA, answerB, answerC, answerD,soccerText;
    Questions qs;
    public List<bool> questionsAsked;
    public int answer;
    public int soccer=-1;
    void Start()
    {
        qs = GetComponent<Questions>();
        for (int i = 0; i < qs.questions.Count; i++)
        {
            questionsAsked.Add(false);
        }
        QuestionAdd();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void QuestionAdd()
    {
        for (int i = 0; i < questionsAsked.Count; i++)
        {
            if (questionsAsked[i] == false)
            {
                int questionCount = Random.Range(0, questionsAsked.Count);
                if (questionsAsked[questionCount] == false)
                {
                    questionsAsked[questionCount] = true;
                    soccer++;
                    soccerText.text = " " + soccer;
                    questionName.text = qs.questions[questionCount].QuestionName;
                    answerA.text = qs.questions[questionCount].answerA;
                    answerB.text = qs.questions[questionCount].answerB;
                    answerC.text = qs.questions[questionCount].answerC;
                    answerD.text = qs.questions[questionCount].answerD;
                    answer = qs.questions[questionCount].answer;
                }
                else
                {
                    QuestionAdd();
                }
                break;
            }
            if (i == questionsAsked.Count - 1)
            {
                Debug.Log("Game Win");
            }
        }
        
       
    }
    public void Answer(int value)
    {
        if (value == answer)
        {
            QuestionAdd();
        }
        else
        {
            Debug.Log("False Answer");
        }
    }
}
