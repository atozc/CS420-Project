using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuizManager : MonoBehaviour
{
    public List<QuestionsAndAnswers> QnA;
    public GameObject[] options;
    public int currentQuestion;

    public GameObject QuizPanel;
    public GameObject GameOverPanel;
    public GameObject TakeQuizPanel;

    public Text QuestionTxt;
    public Text ScoreTxt;

    int totalQuestions = 0;
    public int score;

    private void Start()
    {
        GameOverPanel.SetActive(false);
        TakeQuizPanel.SetActive(true);
        QuizPanel.SetActive(false);
    }

    public void backToFacts()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void takeQuiz()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void startGame()
    {
        totalQuestions = QnA.Count;
        QuizPanel.SetActive(true);
        GameOverPanel.SetActive(false);
        TakeQuizPanel.SetActive(false);
        generateQuestion();
    }

    public void GameOver()
    {
        QuizPanel.SetActive(false);
        GameOverPanel.SetActive(true);
        TakeQuizPanel.SetActive(false);
        ScoreTxt.text = "Score: " + score + "/" + totalQuestions;
    }

    public void correct()
    {
        //when answer is right, increment score by one and get next question
        score += 1;
        QnA.RemoveAt(currentQuestion);
        generateQuestion();
    }

    public void wrong()
    {
        QnA.RemoveAt(currentQuestion);
        generateQuestion();
    }

    void SetAnswers()
    {
        for(int i = 0; i < options.Length; i++)
        {
            options[i].GetComponent<AnswerScript>().isCorrect = false;
            options[i].transform.GetChild(0).GetComponent<Text>().text = QnA[currentQuestion].Answers[i];

            if(QnA[currentQuestion].CorrectAnswerIndex == i+1)
            {
            options[i].GetComponent<AnswerScript>().isCorrect = true; 
            }
        
        }

    }

    void generateQuestion()
    {
        if(QnA.Count > 0)
        {
            currentQuestion = Random.Range(0, QnA.Count);
            QuestionTxt.text = QnA[currentQuestion].Question;
            SetAnswers();
        }
        else
        {
            Debug.Log("Out of Questions");
            GameOver();
        }


    }
}
