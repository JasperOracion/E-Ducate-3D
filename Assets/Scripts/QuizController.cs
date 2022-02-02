using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using System;

public class QuizController : MonoBehaviour
{
    private QuestionCollection questionCollection;
    private QuizQuestion currentQuestion;
    private UIController uiController;

    [SerializeField]
    private float delayBetweenQuestions = 3f;

    [SerializeField]
    private GameObject correctAnswerPopup;
    [SerializeField]
    private GameObject wrongAnswerPopup;

    [SerializeField]
    private TMP_InputField answer;
    [SerializeField]
    private TMP_InputField answer2;

    [SerializeField]
    private GameObject quizPanel;

    private int counterCorrectAnswerStreak = 0;
    private int counterNumOfQuestionsLeft = 10;
    private int counterNumOfCorrectAnswers = 0;

    [SerializeField]
    private GameObject gameOverPanel;
    [SerializeField]
    private GameObject congratulationsPanel;
    [SerializeField]
    private TextMeshProUGUI newHighScore;
    [SerializeField]
    private TextMeshProUGUI score;
    [SerializeField]
    private AudioSource BGM;
    [SerializeField]
    private AudioSource congratulations;
    [SerializeField]
    private AudioSource gameOver;

    private void Awake()
    {
        questionCollection = FindObjectOfType<QuestionCollection>();
        uiController = FindObjectOfType<UIController>();
    }

    private void Start()
    {
        score.text = counterNumOfCorrectAnswers.ToString();
        LeanTween.moveLocal(quizPanel, new Vector2(0, -1200), 0.5f);
        HealthSystem.health = 3;
        PresentQuestion();
    }

    private void PresentQuestion()
    {
        
        currentQuestion = questionCollection.GetUnaskedQuestion();
        uiController.SetupUIForQuestion(currentQuestion);
    }

    public void SubmitAnswer(int answerNumber)
    {
        bool isCorrect = answerNumber == currentQuestion.CorrectAnswer;
        uiController.HandleSubmittedAnswer(isCorrect);

        if (isCorrect == true)
        {
            counterCorrectAnswerStreak += 1;

            if (counterCorrectAnswerStreak == 3)
            {
                HealthSystem.health = HealthSystem.health + 1;
                counterCorrectAnswerStreak = 0;
            }

            counterNumOfQuestionsLeft -= 1;
            counterNumOfCorrectAnswers += 1;
            score.text = counterNumOfCorrectAnswers.ToString();

            if (counterNumOfQuestionsLeft > 0)
            {
                StartCoroutine(ShowNextQuestionAfterDelay());
            }
            else if (counterNumOfQuestionsLeft == 0)
            {
                Congratulations();
            }
        }
        else
        {
            StartCoroutine(WrongAnswer());
            counterCorrectAnswerStreak = 0;
            if (HealthSystem.health > 0)
            {
                HealthSystem.health = HealthSystem.health - 1;
            }
            if (HealthSystem.health == 0)
            {
                GameOver();
            }
        }
    }

    public void SubmitAnswerTyped()
    {
        bool isCorrect = answer.text.ToString().ToLower().Trim('\0') == currentQuestion.CorrectAnswerString.ToString().ToLower().Trim('\0');
        
        uiController.HandleSubmittedAnswer(isCorrect);

        if (isCorrect == true)
        {
            answer.text = null;
            counterCorrectAnswerStreak += 1;

            if (counterCorrectAnswerStreak == 3)
            {
                HealthSystem.health = HealthSystem.health + 1;
                counterCorrectAnswerStreak = 0;
            }

            counterNumOfQuestionsLeft -= 1;
            counterNumOfCorrectAnswers += 1;
            score.text = counterNumOfCorrectAnswers.ToString();

            if (counterNumOfQuestionsLeft > 0)
            {
                StartCoroutine(ShowNextQuestionAfterDelay());
            }
            else if (counterNumOfQuestionsLeft == 0)
            {
                Congratulations();
            }
        }
        else
        {
            StartCoroutine(WrongAnswer());
            counterCorrectAnswerStreak = 0;
            if (HealthSystem.health > 0)
            {
                HealthSystem.health = HealthSystem.health - 1;
            }
            if (HealthSystem.health == 0)
            {
                GameOver();
            }
        }
    }

    public void SubmitAnswerTyped2()
    {
        bool answer1IsCorrect = answer.text.ToString().ToLower().Trim('\0') == currentQuestion.CorrectAnswerString.ToString().ToLower().Trim('\0');
        bool answer2IsCorrect = answer2.text.ToString().ToLower().Trim('\0') == currentQuestion.CorrectAnswerString2.ToString().ToLower().Trim('\0');

        bool isCorrect = false;

        if ((answer1IsCorrect == true) && (answer2IsCorrect == true))
        {
            isCorrect = true;
        }
        
        uiController.HandleSubmittedAnswer(isCorrect);

        if (isCorrect == true)
        {
            answer.text = null;
            answer2.text = null;
            counterCorrectAnswerStreak += 1;

            if (counterCorrectAnswerStreak == 3)
            {
                HealthSystem.health = HealthSystem.health + 1;
                counterCorrectAnswerStreak = 0;
            }

            counterNumOfQuestionsLeft -= 1;
            counterNumOfCorrectAnswers += 1;
            score.text = counterNumOfCorrectAnswers.ToString();

            if (counterNumOfQuestionsLeft > 0)
            {
                StartCoroutine(ShowNextQuestionAfterDelay());
            }
            else if (counterNumOfQuestionsLeft == 0)
            {
                Congratulations();
            }
        }
        else
        {
            StartCoroutine(WrongAnswer());
            counterCorrectAnswerStreak = 0;
            if (HealthSystem.health > 0)
            {
                HealthSystem.health = HealthSystem.health - 1;
            }
            if (HealthSystem.health == 0)
            {
                GameOver();
            }
        }
    }

    private IEnumerator ShowNextQuestionAfterDelay()
    {
            yield return new WaitForSeconds(delayBetweenQuestions);
            LeanTween.moveLocal(quizPanel, new Vector2(0, -1200), 2f).setEaseInBounce();
            yield return new WaitForSeconds(delayBetweenQuestions);
            PresentQuestion();
    }

    private IEnumerator WrongAnswer()
    {
        yield return new WaitForSeconds(delayBetweenQuestions);
        wrongAnswerPopup.SetActive(false);
    }

    private void GameOver()
    {
        quizPanel.SetActive(false);
        correctAnswerPopup.SetActive(false);
        wrongAnswerPopup.SetActive(false);
        gameOverPanel.SetActive(true);
        BGM.Stop();
        gameOver.Play();
        Time.timeScale = 0f;

        if (SceneManager.GetActiveScene().name == "GrammarLevel1")
        {
            if (counterNumOfCorrectAnswers > PlayerPrefs.GetInt("highScoreGrammarLevel1"))
            {
                PlayerPrefs.SetInt("highScoreGrammarLevel1", counterNumOfCorrectAnswers);
                newHighScore.text = "New High Score!";
            }
        }
        else if (SceneManager.GetActiveScene().name == "GrammarLevel2")
        {
            if (counterNumOfCorrectAnswers > PlayerPrefs.GetInt("highScoreGrammarLevel2"))
            {
                PlayerPrefs.SetInt("highScoreGrammarLevel2", counterNumOfCorrectAnswers);
                newHighScore.text = "New High Score!";
            }
        }
        else if (SceneManager.GetActiveScene().name == "GrammarLevel3")
        {
            if (counterNumOfCorrectAnswers > PlayerPrefs.GetInt("highScoreGrammarLevel3"))
            {
                PlayerPrefs.SetInt("highScoreGrammarLevel3", counterNumOfCorrectAnswers);
                newHighScore.text = "New High Score!";
            }
        }

        else if (SceneManager.GetActiveScene().name == "SpellingLevel1")
        {
            if (counterNumOfCorrectAnswers > PlayerPrefs.GetInt("highScoreSpellingLevel1"))
            {
                PlayerPrefs.SetInt("highScoreSpellingLevel1", counterNumOfCorrectAnswers);
                newHighScore.text = "New High Score!";
            }
        }
        else if (SceneManager.GetActiveScene().name == "SpellingLevel2")
        {
            if (counterNumOfCorrectAnswers > PlayerPrefs.GetInt("highScoreSpellingLevel2"))
            {
                PlayerPrefs.SetInt("highScoreSpellingLevel2", counterNumOfCorrectAnswers);
                newHighScore.text = "New High Score!";
            }
        }
        else if (SceneManager.GetActiveScene().name == "SpellingLevel3")
        {
            if (counterNumOfCorrectAnswers > PlayerPrefs.GetInt("highScoreSpellingLevel3"))
            {
                PlayerPrefs.SetInt("highScoreSpellingLevel3", counterNumOfCorrectAnswers);
                newHighScore.text = "New High Score!";
            }
        }

        else if (SceneManager.GetActiveScene().name == "SynonymsAntonymsLevel1")
        {
            if (counterNumOfCorrectAnswers > PlayerPrefs.GetInt("highScoreSynonymsAntonymsLevel1"))
            {
                PlayerPrefs.SetInt("highScoreSynonymsAntonymsLevel1", counterNumOfCorrectAnswers);
                newHighScore.text = "New High Score!";
            }
        }
        else if (SceneManager.GetActiveScene().name == "SynonymsAntonymsLevel2")
        {
            if (counterNumOfCorrectAnswers > PlayerPrefs.GetInt("highScoreSynonymsAntonymsLevel2"))
            {
                PlayerPrefs.SetInt("highScoreSynonymsAntonymsLevel2", counterNumOfCorrectAnswers);
                newHighScore.text = "New High Score!";
            }
        }
        else if (SceneManager.GetActiveScene().name == "SynonymsAntonymsLevel3")
        {
            if (counterNumOfCorrectAnswers > PlayerPrefs.GetInt("highScoreSynonymsAntonymsLevel3"))
            {
                PlayerPrefs.SetInt("highScoreSynonymsAntonymsLevel3", counterNumOfCorrectAnswers);
                newHighScore.text = "New High Score!";
            }
        }



        else if (SceneManager.GetActiveScene().name == "ArithmeticLevel1")
        {
            if (counterNumOfCorrectAnswers > PlayerPrefs.GetInt("highScoreArithmeticLevel1"))
            {
                PlayerPrefs.SetInt("highScoreArithmeticLevel1", counterNumOfCorrectAnswers);
                newHighScore.text = "New High Score!";
            }
        }
        else if (SceneManager.GetActiveScene().name == "ArithmeticLevel2")
        {
            if (counterNumOfCorrectAnswers > PlayerPrefs.GetInt("highScoreArithmeticLevel2"))
            {
                PlayerPrefs.SetInt("highScoreArithmeticLevel2", counterNumOfCorrectAnswers);
                newHighScore.text = "New High Score!";
            }
        }
        else if (SceneManager.GetActiveScene().name == "ArithmeticLevel3")
        {
            if (counterNumOfCorrectAnswers > PlayerPrefs.GetInt("highScoreArithmeticLevel3"))
            {
                PlayerPrefs.SetInt("highScoreArithmeticLevel3", counterNumOfCorrectAnswers);
                newHighScore.text = "New High Score!";
            }
        }

        else if (SceneManager.GetActiveScene().name == "GeometryLevel1")
        {
            if (counterNumOfCorrectAnswers > PlayerPrefs.GetInt("highScoreGeometryLevel1"))
            {
                PlayerPrefs.SetInt("highScoreGeometryLevel1", counterNumOfCorrectAnswers);
                newHighScore.text = "New High Score!";
            }
        }
        else if (SceneManager.GetActiveScene().name == "GeometryLevel2")
        {
            if (counterNumOfCorrectAnswers > PlayerPrefs.GetInt("highScoreGeometryLevel2"))
            {
                PlayerPrefs.SetInt("highScoreGeometryLevel2", counterNumOfCorrectAnswers);
                newHighScore.text = "New High Score!";
            }
        }
        else if (SceneManager.GetActiveScene().name == "GeometryLevel3")
        {
            if (counterNumOfCorrectAnswers > PlayerPrefs.GetInt("highScoreGeometryLevel3"))
            {
                PlayerPrefs.SetInt("highScoreGeometryLevel3", counterNumOfCorrectAnswers);
                newHighScore.text = "New High Score!";
            }
        }

        else if (SceneManager.GetActiveScene().name == "MeasurementLevel1")
        {
            if (counterNumOfCorrectAnswers > PlayerPrefs.GetInt("highScoreMeasurementLevel1"))
            {
                PlayerPrefs.SetInt("highScoreMeasurementLevel1", counterNumOfCorrectAnswers);
                newHighScore.text = "New High Score!";
            }
        }
        else if (SceneManager.GetActiveScene().name == "MeasurementLevel2")
        {
            if (counterNumOfCorrectAnswers > PlayerPrefs.GetInt("highScoreMeasurementLevel2"))
            {
                PlayerPrefs.SetInt("highScoreMeasurementLevel2", counterNumOfCorrectAnswers);
                newHighScore.text = "New High Score!";
            }
        }
        else if (SceneManager.GetActiveScene().name == "MeasurementLevel3")
        {
            if (counterNumOfCorrectAnswers > PlayerPrefs.GetInt("highScoreMeasurementLevel3"))
            {
                PlayerPrefs.SetInt("highScoreMeasurementLevel3", counterNumOfCorrectAnswers);
                newHighScore.text = "New High Score!";
            }
        }



        else if (SceneManager.GetActiveScene().name == "BiologyLevel1")
        {
            if (counterNumOfCorrectAnswers > PlayerPrefs.GetInt("highScoreBiologyLevel1"))
            {
                PlayerPrefs.SetInt("highScoreBiologyLevel1", counterNumOfCorrectAnswers);
                newHighScore.text = "New High Score!";
            }
        }
        else if (SceneManager.GetActiveScene().name == "BiologyLevel2")
        {
            if (counterNumOfCorrectAnswers > PlayerPrefs.GetInt("highScoreBiologyLevel2"))
            {
                PlayerPrefs.SetInt("highScoreBiologyLevel2", counterNumOfCorrectAnswers);
                newHighScore.text = "New High Score!";
            }
        }
        else if (SceneManager.GetActiveScene().name == "BiologyLevel3")
        {
            if (counterNumOfCorrectAnswers > PlayerPrefs.GetInt("highScoreBiologyLevel3"))
            {
                PlayerPrefs.SetInt("highScoreBiologyLevel3", counterNumOfCorrectAnswers);
                newHighScore.text = "New High Score!";
            }
        }

        else if (SceneManager.GetActiveScene().name == "ChemistryLevel1")
        {
            if (counterNumOfCorrectAnswers > PlayerPrefs.GetInt("highScoreChemistryLevel1"))
            {
                PlayerPrefs.SetInt("highScoreChemistryLevel1", counterNumOfCorrectAnswers);
                newHighScore.text = "New High Score!";
            }
        }
        else if (SceneManager.GetActiveScene().name == "ChemistryLevel2")
        {
            if (counterNumOfCorrectAnswers > PlayerPrefs.GetInt("highScoreChemistryLevel2"))
            {
                PlayerPrefs.SetInt("highScoreChemistryLevel2", counterNumOfCorrectAnswers);
                newHighScore.text = "New High Score!";
            }
        }
        else if (SceneManager.GetActiveScene().name == "ChemistryLevel3")
        {
            if (counterNumOfCorrectAnswers > PlayerPrefs.GetInt("highScoreChemistryLevel3"))
            {
                PlayerPrefs.SetInt("highScoreChemistryLevel3", counterNumOfCorrectAnswers);
                newHighScore.text = "New High Score!";
            }
        }

        else if (SceneManager.GetActiveScene().name == "EarthScienceLevel1")
        {
            if (counterNumOfCorrectAnswers > PlayerPrefs.GetInt("highScoreEarthScienceLevel1"))
            {
                PlayerPrefs.SetInt("highScoreEarthScienceLevel1", counterNumOfCorrectAnswers);
                newHighScore.text = "New High Score!";
            }
        }
        else if (SceneManager.GetActiveScene().name == "EarthScienceLevel2")
        {
            if (counterNumOfCorrectAnswers > PlayerPrefs.GetInt("highScoreEarthScienceLevel2"))
            {
                PlayerPrefs.SetInt("highScoreEarthScienceLevel2", counterNumOfCorrectAnswers);
                newHighScore.text = "New High Score!";
            }
        }
        else if (SceneManager.GetActiveScene().name == "EarthScienceLevel3")
        {
            if (counterNumOfCorrectAnswers > PlayerPrefs.GetInt("highScoreEarthScienceLevel3"))
            {
                PlayerPrefs.SetInt("highScoreEarthScienceLevel3", counterNumOfCorrectAnswers);
                newHighScore.text = "New High Score!";
            }
        }
    }

    private void Congratulations()
    {
        quizPanel.SetActive(false);
        correctAnswerPopup.SetActive(false);
        wrongAnswerPopup.SetActive(false);
        congratulationsPanel.SetActive(true);
        congratulations.Play();
        Time.timeScale = 0f;

        if (SceneManager.GetActiveScene().name == "GrammarLevel1")
        {
            if (counterNumOfCorrectAnswers > PlayerPrefs.GetInt("highScoreGrammarLevel1"))
            {
                PlayerPrefs.SetInt("highScoreGrammarLevel1", counterNumOfCorrectAnswers);
                newHighScore.text = "New High Score!";
            }
        }
        else if (SceneManager.GetActiveScene().name == "GrammarLevel2")
        {
            if (counterNumOfCorrectAnswers > PlayerPrefs.GetInt("highScoreGrammarLevel2"))
            {
                PlayerPrefs.SetInt("highScoreGrammarLevel2", counterNumOfCorrectAnswers);
                newHighScore.text = "New High Score!";
            }
        }
        else if (SceneManager.GetActiveScene().name == "GrammarLevel3")
        {
            if (counterNumOfCorrectAnswers > PlayerPrefs.GetInt("highScoreGrammarLevel3"))
            {
                PlayerPrefs.SetInt("highScoreGrammarLevel3", counterNumOfCorrectAnswers);
                newHighScore.text = "New High Score!";
            }
        }

        else if (SceneManager.GetActiveScene().name == "SpellingLevel1")
        {
            if (counterNumOfCorrectAnswers > PlayerPrefs.GetInt("highScoreSpellingLevel1"))
            {
                PlayerPrefs.SetInt("highScoreSpellingLevel1", counterNumOfCorrectAnswers);
                newHighScore.text = "New High Score!";
            }
        }
        else if (SceneManager.GetActiveScene().name == "SpellingLevel2")
        {
            if (counterNumOfCorrectAnswers > PlayerPrefs.GetInt("highScoreSpellingLevel2"))
            {
                PlayerPrefs.SetInt("highScoreSpellingLevel2", counterNumOfCorrectAnswers);
                newHighScore.text = "New High Score!";
            }
        }
        else if (SceneManager.GetActiveScene().name == "SpellingLevel3")
        {
            if (counterNumOfCorrectAnswers > PlayerPrefs.GetInt("highScoreSpellingLevel3"))
            {
                PlayerPrefs.SetInt("highScoreSpellingLevel3", counterNumOfCorrectAnswers);
                newHighScore.text = "New High Score!";
            }
        }

        else if (SceneManager.GetActiveScene().name == "SynonymsAntonymsLevel1")
        {
            if (counterNumOfCorrectAnswers > PlayerPrefs.GetInt("highScoreSynonymsAntonymsLevel1"))
            {
                PlayerPrefs.SetInt("highScoreSynonymsAntonymsLevel1", counterNumOfCorrectAnswers);
                newHighScore.text = "New High Score!";
            }
        }
        else if (SceneManager.GetActiveScene().name == "SynonymsAntonymsLevel2")
        {
            if (counterNumOfCorrectAnswers > PlayerPrefs.GetInt("highScoreSynonymsAntonymsLevel2"))
            {
                PlayerPrefs.SetInt("highScoreSynonymsAntonymsLevel2", counterNumOfCorrectAnswers);
                newHighScore.text = "New High Score!";
            }
        }
        else if (SceneManager.GetActiveScene().name == "SynonymsAntonymsLevel3")
        {
            if (counterNumOfCorrectAnswers > PlayerPrefs.GetInt("highScoreSynonymsAntonymsLevel3"))
            {
                PlayerPrefs.SetInt("highScoreSynonymsAntonymsLevel3", counterNumOfCorrectAnswers);
                newHighScore.text = "New High Score!";
            }
        }



        else if (SceneManager.GetActiveScene().name == "ArithmeticLevel1")
        {
            if (counterNumOfCorrectAnswers > PlayerPrefs.GetInt("highScoreArithmeticLevel1"))
            {
                PlayerPrefs.SetInt("highScoreArithmeticLevel1", counterNumOfCorrectAnswers);
                newHighScore.text = "New High Score!";
            }
        }
        else if (SceneManager.GetActiveScene().name == "ArithmeticLevel2")
        {
            if (counterNumOfCorrectAnswers > PlayerPrefs.GetInt("highScoreArithmeticLevel2"))
            {
                PlayerPrefs.SetInt("highScoreArithmeticLevel2", counterNumOfCorrectAnswers);
                newHighScore.text = "New High Score!";
            }
        }
        else if (SceneManager.GetActiveScene().name == "ArithmeticLevel3")
        {
            if (counterNumOfCorrectAnswers > PlayerPrefs.GetInt("highScoreArithmeticLevel3"))
            {
                PlayerPrefs.SetInt("highScoreArithmeticLevel3", counterNumOfCorrectAnswers);
                newHighScore.text = "New High Score!";
            }
        }

        else if (SceneManager.GetActiveScene().name == "GeometryLevel1")
        {
            if (counterNumOfCorrectAnswers > PlayerPrefs.GetInt("highScoreGeometryLevel1"))
            {
                PlayerPrefs.SetInt("highScoreGeometryLevel1", counterNumOfCorrectAnswers);
                newHighScore.text = "New High Score!";
            }
        }
        else if (SceneManager.GetActiveScene().name == "GeometryLevel2")
        {
            if (counterNumOfCorrectAnswers > PlayerPrefs.GetInt("highScoreGeometryLevel2"))
            {
                PlayerPrefs.SetInt("highScoreGeometryLevel2", counterNumOfCorrectAnswers);
                newHighScore.text = "New High Score!";
            }
        }
        else if (SceneManager.GetActiveScene().name == "GeometryLevel3")
        {
            if (counterNumOfCorrectAnswers > PlayerPrefs.GetInt("highScoreGeometryLevel3"))
            {
                PlayerPrefs.SetInt("highScoreGeometryLevel3", counterNumOfCorrectAnswers);
                newHighScore.text = "New High Score!";
            }
        }

        else if (SceneManager.GetActiveScene().name == "MeasurementLevel1")
        {
            if (counterNumOfCorrectAnswers > PlayerPrefs.GetInt("highScoreMeasurementLevel1"))
            {
                PlayerPrefs.SetInt("highScoreMeasurementLevel1", counterNumOfCorrectAnswers);
                newHighScore.text = "New High Score!";
            }
        }
        else if (SceneManager.GetActiveScene().name == "MeasurementLevel2")
        {
            if (counterNumOfCorrectAnswers > PlayerPrefs.GetInt("highScoreMeasurementLevel2"))
            {
                PlayerPrefs.SetInt("highScoreMeasurementLevel2", counterNumOfCorrectAnswers);
                newHighScore.text = "New High Score!";
            }
        }
        else if (SceneManager.GetActiveScene().name == "MeasurementLevel3")
        {
            if (counterNumOfCorrectAnswers > PlayerPrefs.GetInt("highScoreMeasurementLevel3"))
            {
                PlayerPrefs.SetInt("highScoreMeasurementLevel3", counterNumOfCorrectAnswers);
                newHighScore.text = "New High Score!";
            }
        }



        else if (SceneManager.GetActiveScene().name == "BiologyLevel1")
        {
            if (counterNumOfCorrectAnswers > PlayerPrefs.GetInt("highScoreBiologyLevel1"))
            {
                PlayerPrefs.SetInt("highScoreBiologyLevel1", counterNumOfCorrectAnswers);
                newHighScore.text = "New High Score!";
            }
        }
        else if (SceneManager.GetActiveScene().name == "BiologyLevel2")
        {
            if (counterNumOfCorrectAnswers > PlayerPrefs.GetInt("highScoreBiologyLevel2"))
            {
                PlayerPrefs.SetInt("highScoreBiologyLevel2", counterNumOfCorrectAnswers);
                newHighScore.text = "New High Score!";
            }
        }
        else if (SceneManager.GetActiveScene().name == "BiologyLevel3")
        {
            if (counterNumOfCorrectAnswers > PlayerPrefs.GetInt("highScoreBiologyLevel3"))
            {
                PlayerPrefs.SetInt("highScoreBiologyLevel3", counterNumOfCorrectAnswers);
                newHighScore.text = "New High Score!";
            }
        }

        else if (SceneManager.GetActiveScene().name == "ChemistryLevel1")
        {
            if (counterNumOfCorrectAnswers > PlayerPrefs.GetInt("highScoreChemistryLevel1"))
            {
                PlayerPrefs.SetInt("highScoreChemistryLevel1", counterNumOfCorrectAnswers);
                newHighScore.text = "New High Score!";
            }
        }
        else if (SceneManager.GetActiveScene().name == "ChemistryLevel2")
        {
            if (counterNumOfCorrectAnswers > PlayerPrefs.GetInt("highScoreChemistryLevel2"))
            {
                PlayerPrefs.SetInt("highScoreChemistryLevel2", counterNumOfCorrectAnswers);
                newHighScore.text = "New High Score!";
            }
        }
        else if (SceneManager.GetActiveScene().name == "ChemistryLevel3")
        {
            if (counterNumOfCorrectAnswers > PlayerPrefs.GetInt("highScoreChemistryLevel3"))
            {
                PlayerPrefs.SetInt("highScoreChemistryLevel3", counterNumOfCorrectAnswers);
                newHighScore.text = "New High Score!";
            }
        }

        else if (SceneManager.GetActiveScene().name == "EarthScienceLevel1")
        {
            if (counterNumOfCorrectAnswers > PlayerPrefs.GetInt("highScoreEarthScienceLevel1"))
            {
                PlayerPrefs.SetInt("highScoreEarthScienceLevel1", counterNumOfCorrectAnswers);
                newHighScore.text = "New High Score!";
            }
        }
        else if (SceneManager.GetActiveScene().name == "EarthScienceLevel2")
        {
            if (counterNumOfCorrectAnswers > PlayerPrefs.GetInt("highScoreEarthScienceLevel2"))
            {
                PlayerPrefs.SetInt("highScoreEarthScienceLevel2", counterNumOfCorrectAnswers);
                newHighScore.text = "New High Score!";
            }
        }
        else if (SceneManager.GetActiveScene().name == "EarthScienceLevel3")
        {
            if (counterNumOfCorrectAnswers > PlayerPrefs.GetInt("highScoreEarthScienceLevel3"))
            {
                PlayerPrefs.SetInt("highScoreEarthScienceLevel3", counterNumOfCorrectAnswers);
                newHighScore.text = "New High Score!";
            }
        }

    }
}