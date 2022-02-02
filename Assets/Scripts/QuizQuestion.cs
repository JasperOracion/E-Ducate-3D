using UnityEditor;
using UnityEngine;

[CreateAssetMenuAttribute]
public class QuizQuestion : ScriptableObject
{
    [SerializeField]
    private string question;

    [SerializeField]
    private string[] answers;

    [SerializeField]
    private int correctAnswer;
    [SerializeField]
    private string correctAnswerString;
    [SerializeField]
    private string correctAnswerString2;

    public string Question { get { return question; } }
    public string[] Answers { get { return answers; } }
    public int CorrectAnswer { get { return correctAnswer; } }
    public string CorrectAnswerString { get { return correctAnswerString; } }
    public string CorrectAnswerString2 { get { return correctAnswerString2; } }

    public bool Asked { get; internal set; }

    private void OnValidate()
    {
        if (correctAnswer > answers.Length)
        {
            correctAnswer = 0;
        }
    }
}