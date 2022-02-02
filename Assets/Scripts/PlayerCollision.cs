using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{

    public GameObject quizPanel;
    public GameObject starStation1;
    public GameObject starStation2;
    public GameObject starStation3;
    public GameObject starStation4;
    public GameObject starStation5;
    public GameObject starStation6;
    public GameObject starStation7;
    public GameObject starStation8;
    public GameObject starStation9;
    public GameObject starStation10;
    
    public Animator transition;

    private void OnTriggerEnter(Collider collisionInfo)
    {
        if (collisionInfo.gameObject.tag == "Portal")
        {
            if (collisionInfo.gameObject.name == "ExitPortal")
            {
                LoadLevel("MainMenu");
            }
            else if (collisionInfo.gameObject.name == "PlayPortal")
            {
                LoadLevel("SubjectSelection");
            }
            else if (collisionInfo.gameObject.name == "CampPortal")
            {
                LoadLevel("Camp");
            }
            else if (collisionInfo.gameObject.name == "SubjectPortal")
            {
                LoadLevel("SubjectSelection");
            }
            else if (collisionInfo.gameObject.name == "EnglishTopicPortal")
            {
                LoadLevel("EnglishTopicSelection");
            }
            else if (collisionInfo.gameObject.name == "MathTopicPortal")
            {
                LoadLevel("MathTopicSelection");
            }
            else if (collisionInfo.gameObject.name == "ScienceTopicPortal")
            {
                LoadLevel("ScienceTopicSelection");
            }

            else if (collisionInfo.gameObject.name == "EnglishPortal")
            {
                LoadLevel("EnglishTopicSelection");
            }
            else if (collisionInfo.gameObject.name == "MathPortal")
            {
                LoadLevel("MathTopicSelection");
            }
            else if (collisionInfo.gameObject.name == "SciencePortal")
            {
                LoadLevel("ScienceTopicSelection");
            }

            else if (collisionInfo.gameObject.name == "GrammarPortal")
            {
                LoadLevel("GrammarLevelSelection");
            }
            else if (collisionInfo.gameObject.name == "SpellingPortal")
            {
                LoadLevel("SpellingLevelSelection");
            }
            else if (collisionInfo.gameObject.name == "SynonymsAntonymsPortal")
            {
                LoadLevel("SynonymsAntonymsLevelSelection");
            }
            
            else if (collisionInfo.gameObject.name == "ArithmeticPortal")
            {
                LoadLevel("ArithmeticLevelSelection");
            }
            else if (collisionInfo.gameObject.name == "GeometryPortal")
            {
                LoadLevel("GeometryLevelSelection");
            }
            else if (collisionInfo.gameObject.name == "MeasurementPortal")
            {
                LoadLevel("MeasurementLevelSelection");
            }

            else if (collisionInfo.gameObject.name == "BiologyPortal")
            {
                LoadLevel("BiologyLevelSelection");
            }
            else if (collisionInfo.gameObject.name == "ChemistryPortal")
            {
                LoadLevel("ChemistryLevelSelection");
            }
            else if (collisionInfo.gameObject.name == "EarthSciencePortal")
            {
                LoadLevel("EarthScienceLevelSelection");
            }

            else if (collisionInfo.gameObject.name == "GrammarLevel1Portal")
            {
                LoadLevel("GrammarLevel1");
            }
            else if (collisionInfo.gameObject.name == "GrammarLevel2Portal")
            {
                LoadLevel("GrammarLevel2");
            }
            else if (collisionInfo.gameObject.name == "GrammarLevel3Portal")
            {
                LoadLevel("GrammarLevel3");
            }

            else if (collisionInfo.gameObject.name == "SpellingLevel1Portal")
            {
                LoadLevel("SpellingLevel1");
            }
            else if (collisionInfo.gameObject.name == "SpellingLevel2Portal")
            {
                LoadLevel("SpellingLevel2");
            }
            else if (collisionInfo.gameObject.name == "SpellingLevel3Portal")
            {
                LoadLevel("SpellingLevel3");
            }

            else if (collisionInfo.gameObject.name == "SynonymsAntonymsLevel1Portal")
            {
                LoadLevel("SynonymsAntonymsLevel1");
            }
            else if (collisionInfo.gameObject.name == "SynonymsAntonymsLevel2Portal")
            {
                LoadLevel("SynonymsAntonymsLevel2");
            }
            else if (collisionInfo.gameObject.name == "SynonymsAntonymsLevel3Portal")
            {
                LoadLevel("SynonymsAntonymsLevel3");
            }

            else if (collisionInfo.gameObject.name == "ArithmeticLevel1Portal")
            {
                LoadLevel("ArithmeticLevel1");
            }
            else if (collisionInfo.gameObject.name == "ArithmeticLevel2Portal")
            {
                LoadLevel("ArithmeticLevel2");
            }
            else if (collisionInfo.gameObject.name == "ArithmeticLevel3Portal")
            {
                LoadLevel("ArithmeticLevel3");
            }

            else if (collisionInfo.gameObject.name == "GeometryLevel1Portal")
            {
                LoadLevel("GeometryLevel1");
            }
            else if (collisionInfo.gameObject.name == "GeometryLevel2Portal")
            {
                LoadLevel("GeometryLevel2");
            }
            else if (collisionInfo.gameObject.name == "GeometryLevel3Portal")
            {
                LoadLevel("GeometryLevel3");
            }

            else if (collisionInfo.gameObject.name == "MeasurementLevel1Portal")
            {
                LoadLevel("MeasurementLevel1");
            }
            else if (collisionInfo.gameObject.name == "MeasurementLevel2Portal")
            {
                LoadLevel("MeasurementLevel2");
            }
            else if (collisionInfo.gameObject.name == "MeasurementLevel3Portal")
            {
                LoadLevel("MeasurementLevel3");
            }

            else if (collisionInfo.gameObject.name == "BiologyLevel1Portal")
            {
                LoadLevel("BiologyLevel1");
            }
            else if (collisionInfo.gameObject.name == "BiologyLevel2Portal")
            {
                LoadLevel("BiologyLevel2");
            }
            else if (collisionInfo.gameObject.name == "BiologyLevel3Portal")
            {
                LoadLevel("BiologyLevel3");
            }

            else if (collisionInfo.gameObject.name == "ChemistryLevel1Portal")
            {
                LoadLevel("ChemistryLevel1");
            }
            else if (collisionInfo.gameObject.name == "ChemistryLevel2Portal")
            {
                LoadLevel("ChemistryLevel2");
            }
            else if (collisionInfo.gameObject.name == "ChemistryLevel3Portal")
            {
                LoadLevel("ChemistryLevel3");
            }

            else if (collisionInfo.gameObject.name == "EarthScienceLevel1Portal")
            {
                LoadLevel("EarthScienceLevel1");
            }
            else if (collisionInfo.gameObject.name == "EarthScienceLevel2Portal")
            {
                LoadLevel("EarthScienceLevel2");
            }
            else if (collisionInfo.gameObject.name == "EarthScienceLevel3Portal")
            {
                LoadLevel("EarthScienceLevel3");
            }
        }

        else if (collisionInfo.gameObject.tag == "Trigger")
        {
            if (collisionInfo.gameObject.name == "Station1Trigger")
            {
                LeanTween.moveLocal(quizPanel, new Vector2(0, 0), 2f).setEaseInBounce();
                starStation1.SetActive(false);
            }
            else if (collisionInfo.gameObject.name == "Station2Trigger")
            {
                LeanTween.moveLocal(quizPanel, new Vector2(0, 0), 2f).setEaseInBounce();
                starStation2.SetActive(false);
            }
            else if (collisionInfo.gameObject.name == "Station3Trigger")
            {
                LeanTween.moveLocal(quizPanel, new Vector2(0, 0), 2f).setEaseInBounce();
                starStation3.SetActive(false);
            }
            else if (collisionInfo.gameObject.name == "Station4Trigger")
            {
                LeanTween.moveLocal(quizPanel, new Vector2(0, 0), 2f).setEaseInBounce();
                starStation4.SetActive(false);
            }
            else if (collisionInfo.gameObject.name == "Station5Trigger")
            {
                LeanTween.moveLocal(quizPanel, new Vector2(0, 0), 2f).setEaseInBounce();
                starStation5.SetActive(false);
            }
            else if (collisionInfo.gameObject.name == "Station6Trigger")
            {
                LeanTween.moveLocal(quizPanel, new Vector2(0, 0), 2f).setEaseInBounce();
                starStation6.SetActive(false);
            }
            else if (collisionInfo.gameObject.name == "Station7Trigger")
            {
                LeanTween.moveLocal(quizPanel, new Vector2(0, 0), 2f).setEaseInBounce();
                starStation7.SetActive(false);
            }
            else if (collisionInfo.gameObject.name == "Station8Trigger")
            {
                LeanTween.moveLocal(quizPanel, new Vector2(0, 0), 2f).setEaseInBounce();
                starStation8.SetActive(false);
            }
            else if (collisionInfo.gameObject.name == "Station9Trigger")
            {
                LeanTween.moveLocal(quizPanel, new Vector2(0, 0), 2f).setEaseInBounce();
                starStation9.SetActive(false);
            }
            else if (collisionInfo.gameObject.name == "Station10Trigger")
            {
                LeanTween.moveLocal(quizPanel, new Vector2(0, 0), 2f).setEaseInBounce();
                starStation10.SetActive(false);
            }
        }
    }

    public void LoadLevel(string sceneName)
    {
        StartCoroutine(LoadSceneAsync(sceneName));
    }

    private IEnumerator LoadSceneAsync(string levelName)
    { 
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(levelName);
    }

}
