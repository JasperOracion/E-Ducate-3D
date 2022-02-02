using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuestionCollection : MonoBehaviour
{
    private QuizQuestion[] allQuestions;

    private void Awake()
    {
        LoadAllQuestions();
    }

    private void LoadAllQuestions()
    {
        if (SceneManager.GetActiveScene().name == "GrammarLevel1")
        {
            allQuestions = Resources.LoadAll<QuizQuestion>("Questions/English/Grammar/Level1");
        }
        else if (SceneManager.GetActiveScene().name == "GrammarLevel2")
        {
            allQuestions = Resources.LoadAll<QuizQuestion>("Questions/English/Grammar/Level2");
        }
        else if (SceneManager.GetActiveScene().name == "GrammarLevel3")
        {
            allQuestions = Resources.LoadAll<QuizQuestion>("Questions/English/Grammar/Level3");
        }

        else if (SceneManager.GetActiveScene().name == "SpellingLevel1")
        {
            allQuestions = Resources.LoadAll<QuizQuestion>("Questions/English/Spelling/Level1");
        }
        else if (SceneManager.GetActiveScene().name == "SpellingLevel2")
        {
            allQuestions = Resources.LoadAll<QuizQuestion>("Questions/English/Spelling/Level2");
        }
        else if (SceneManager.GetActiveScene().name == "SpellingLevel3")
        {
            allQuestions = Resources.LoadAll<QuizQuestion>("Questions/English/Spelling/Level3");
        }

        else if (SceneManager.GetActiveScene().name == "SynonymsAntonymsLevel1")
        {
            allQuestions = Resources.LoadAll<QuizQuestion>("Questions/English/SynonymsAntonyms/Level1");
        }
        else if (SceneManager.GetActiveScene().name == "SynonymsAntonymsLevel2")
        {
            allQuestions = Resources.LoadAll<QuizQuestion>("Questions/English/SynonymsAntonyms/Level2");
        }
        else if (SceneManager.GetActiveScene().name == "SynonymsAntonymsLevel3")
        {
            allQuestions = Resources.LoadAll<QuizQuestion>("Questions/English/SynonymsAntonyms/Level3");
        }



        else if (SceneManager.GetActiveScene().name == "ArithmeticLevel1")
        {
            allQuestions = Resources.LoadAll<QuizQuestion>("Questions/Math/Arithmetic/Level1");
        }
        else if (SceneManager.GetActiveScene().name == "ArithmeticLevel2")
        {
            allQuestions = Resources.LoadAll<QuizQuestion>("Questions/Math/Arithmetic/Level2");
        }
        else if (SceneManager.GetActiveScene().name == "ArithmeticLevel3")
        {
            allQuestions = Resources.LoadAll<QuizQuestion>("Questions/Math/Arithmetic/Level3");
        }

        else if (SceneManager.GetActiveScene().name == "GeometryLevel1")
        {
            allQuestions = Resources.LoadAll<QuizQuestion>("Questions/Math/Geometry/Level1");
        }
        else if (SceneManager.GetActiveScene().name == "GeometryLevel2")
        {
            allQuestions = Resources.LoadAll<QuizQuestion>("Questions/Math/Geometry/Level2");
        }
        else if (SceneManager.GetActiveScene().name == "GeometryLevel3")
        {
            allQuestions = Resources.LoadAll<QuizQuestion>("Questions/Math/Geometry/Level3");
        }

        else if (SceneManager.GetActiveScene().name == "MeasurementLevel1")
        {
            allQuestions = Resources.LoadAll<QuizQuestion>("Questions/Math/Measurement/Level1");
        }
        else if (SceneManager.GetActiveScene().name == "MeasurementLevel2")
        {
            allQuestions = Resources.LoadAll<QuizQuestion>("Questions/Math/Measurement/Level2");
        }
        else if (SceneManager.GetActiveScene().name == "MeasurementLevel3")
        {
            allQuestions = Resources.LoadAll<QuizQuestion>("Questions/Math/Measurement/Level3");
        }



        else if (SceneManager.GetActiveScene().name == "BiologyLevel1")
        {
            allQuestions = Resources.LoadAll<QuizQuestion>("Questions/Science/Biology/Level1");
        }
        else if (SceneManager.GetActiveScene().name == "BiologyLevel2")
        {
            allQuestions = Resources.LoadAll<QuizQuestion>("Questions/Science/Biology/Level2");
        }
        else if (SceneManager.GetActiveScene().name == "BiologyLevel3")
        {
            allQuestions = Resources.LoadAll<QuizQuestion>("Questions/Science/Biology/Level3");
        }

        else if (SceneManager.GetActiveScene().name == "ChemistryLevel1")
        {
            allQuestions = Resources.LoadAll<QuizQuestion>("Questions/Science/Chemistry/Level1");
        }
        else if (SceneManager.GetActiveScene().name == "ChemistryLevel2")
        {
            allQuestions = Resources.LoadAll<QuizQuestion>("Questions/Science/Chemistry/Level2");
        }
        else if (SceneManager.GetActiveScene().name == "ChemistryLevel3")
        {
            allQuestions = Resources.LoadAll<QuizQuestion>("Questions/Science/Chemistry/Level3");
        }

        else if (SceneManager.GetActiveScene().name == "EarthScienceLevel1")
        {
            allQuestions = Resources.LoadAll<QuizQuestion>("Questions/Science/EarthScience/Level1");
        }
        else if (SceneManager.GetActiveScene().name == "EarthScienceLevel2")
        {
            allQuestions = Resources.LoadAll<QuizQuestion>("Questions/Science/EarthScience/Level2");
        }
        else if (SceneManager.GetActiveScene().name == "EarthScienceLevel3")
        {
            allQuestions = Resources.LoadAll<QuizQuestion>("Questions/Science/EarthScience/Level3");
        }
    }

    public QuizQuestion GetUnaskedQuestion()
    {
        ResetQuestionsIfAllHaveBeenAsked();

        var question = allQuestions
            .Where(t => t.Asked == false)
            .OrderBy(t => UnityEngine.Random.Range(0, int.MaxValue))
            .FirstOrDefault();

        question.Asked = true;
        return question;
    }

    private void ResetQuestionsIfAllHaveBeenAsked()
    {
        if (allQuestions.Any(t => t.Asked == false) == false)
        {
            ResetQuestions();
        }
    }

    private void ResetQuestions()
    {
        foreach (var question in allQuestions)
            question.Asked = false;
    }
}