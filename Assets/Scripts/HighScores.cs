using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScores : MonoBehaviour
{

    [SerializeField]
    private Text textFirstName, textLastName, textGradeLevel;

    [SerializeField]
    private GameObject mainMenu;
    [SerializeField]
    private GameObject scores;
    
    private int highScoreGrammarLevel1;
    private int highScoreGrammarLevel2;
    private int highScoreGrammarLevel3;

    private int highScoreSpellingLevel1;
    private int highScoreSpellingLevel2;
    private int highScoreSpellingLevel3;

    private int highScoreSynonymsAntonymsLevel1;
    private int highScoreSynonymsAntonymsLevel2;
    private int highScoreSynonymsAntonymsLevel3;

    private int highScoreArithmeticLevel1;
    private int highScoreArithmeticLevel2;
    private int highScoreArithmeticLevel3;

    private int highScoreGeometryLevel1;
    private int highScoreGeometryLevel2;
    private int highScoreGeometryLevel3;

    private int highScoreMeasurementLevel1;
    private int highScoreMeasurementLevel2;
    private int highScoreMeasurementLevel3;

    private int highScoreBiologyLevel1;
    private int highScoreBiologyLevel2;
    private int highScoreBiologyLevel3;

    private int highScoreChemistryLevel1;
    private int highScoreChemistryLevel2;
    private int highScoreChemistryLevel3;

    private int highScoreEarthScienceLevel1;
    private int highScoreEarthScienceLevel2;
    private int highScoreEarthScienceLevel3;

    public int numOfStars;


    public Image[] starsGrammarLevel1;
    public Image[] starsGrammarLevel2;
    public Image[] starsGrammarLevel3;

    public Image[] starsSpellingLevel1;
    public Image[] starsSpellingLevel2;
    public Image[] starsSpellingLevel3;

    public Image[] starsSynonymsAntonymsLevel1;
    public Image[] starsSynonymsAntonymsLevel2;
    public Image[] starsSynonymsAntonymsLevel3;

    public Image[] starsArithmeticLevel1;
    public Image[] starsArithmeticLevel2;
    public Image[] starsArithmeticLevel3;

    public Image[] starsGeometryLevel1;
    public Image[] starsGeometryLevel2;
    public Image[] starsGeometryLevel3;

    public Image[] starsMeasurementLevel1;
    public Image[] starsMeasurementLevel2;
    public Image[] starsMeasurementLevel3;

    public Image[] starsBiologyLevel1;
    public Image[] starsBiologyLevel2;
    public Image[] starsBiologyLevel3;

    public Image[] starsChemistryLevel1;
    public Image[] starsChemistryLevel2;
    public Image[] starsChemistryLevel3;

    public Image[] starsEarthScienceLevel1;
    public Image[] starsEarthScienceLevel2;
    public Image[] starsEarthScienceLevel3;


    public Sprite fullStar;
    public Sprite emptyStar;

    void Start()
    {

        textFirstName.text = PlayerPrefs.GetString("firstName");
        textLastName.text = PlayerPrefs.GetString("lastName");
        textGradeLevel.text = "Grade " + PlayerPrefs.GetString("gradeLevel");

        highScoreGrammarLevel1 = PlayerPrefs.GetInt("highScoreGrammarLevel1");
        highScoreGrammarLevel2 = PlayerPrefs.GetInt("highScoreGrammarLevel2");
        highScoreGrammarLevel3 = PlayerPrefs.GetInt("highScoreGrammarLevel3");

        highScoreSpellingLevel1 = PlayerPrefs.GetInt("highScoreSpellingLevel1");
        highScoreSpellingLevel2 = PlayerPrefs.GetInt("highScoreSpellingLevel2");
        highScoreSpellingLevel3 = PlayerPrefs.GetInt("highScoreSpellingLevel3");

        highScoreSynonymsAntonymsLevel1 = PlayerPrefs.GetInt("highScoreSynonymsAntonymsLevel1");
        highScoreSynonymsAntonymsLevel2 = PlayerPrefs.GetInt("highScoreSynonymsAntonymsLevel2");
        highScoreSynonymsAntonymsLevel3 = PlayerPrefs.GetInt("highScoreSynonymsAntonymsLevel3");

        highScoreArithmeticLevel1 = PlayerPrefs.GetInt("highScoreArithmeticLevel1");
        highScoreArithmeticLevel2 = PlayerPrefs.GetInt("highScoreArithmeticLevel2");
        highScoreArithmeticLevel3 = PlayerPrefs.GetInt("highScoreArithmeticLevel3");

        highScoreGeometryLevel1 = PlayerPrefs.GetInt("highScoreGeometryLevel1");
        highScoreGeometryLevel2 = PlayerPrefs.GetInt("highScoreGeometryLevel2");
        highScoreGeometryLevel3 = PlayerPrefs.GetInt("highScoreGeometryLevel3");

        highScoreMeasurementLevel1 = PlayerPrefs.GetInt("highScoreMeasurementLevel1");
        highScoreMeasurementLevel2 = PlayerPrefs.GetInt("highScoreMeasurementLevel2");
        highScoreMeasurementLevel3 = PlayerPrefs.GetInt("highScoreMeasurementLevel3");

        highScoreBiologyLevel1 = PlayerPrefs.GetInt("highScoreBiologyLevel1");
        highScoreBiologyLevel2 = PlayerPrefs.GetInt("highScoreBiologyLevel2");
        highScoreBiologyLevel3 = PlayerPrefs.GetInt("highScoreBiologyLevel3");

        highScoreChemistryLevel1 = PlayerPrefs.GetInt("highScoreChemistryLevel1");
        highScoreChemistryLevel2 = PlayerPrefs.GetInt("highScoreChemistryLevel2");
        highScoreChemistryLevel3 = PlayerPrefs.GetInt("highScoreChemistryLevel3");

        highScoreEarthScienceLevel1 = PlayerPrefs.GetInt("highScoreEarthScienceLevel1");
        highScoreEarthScienceLevel2 = PlayerPrefs.GetInt("highScoreEarthScienceLevel2");
        highScoreEarthScienceLevel3 = PlayerPrefs.GetInt("highScoreEarthScienceLevel3");

    }

    public void ScoresCloseButton()
    {
        scores.SetActive(false);
        mainMenu.SetActive(true);
    }

    void Update()
    {

        UpdateGrammarLevel1();
        UpdateGrammarLevel2();
        UpdateGrammarLevel3();

        UpdateSpellingLevel1();
        UpdateSpellingLevel2();
        UpdateSpellingLevel3();

        UpdateSynonymsAntonymsLevel1();
        UpdateSynonymsAntonymsLevel2();
        UpdateSynonymsAntonymsLevel3();

        UpdateArithmeticLevel1();
        UpdateArithmeticLevel2();
        UpdateArithmeticLevel3();

        UpdateGeometryLevel1();
        UpdateGeometryLevel2();
        UpdateGeometryLevel3();

        UpdateMeasurementLevel1();
        UpdateMeasurementLevel2();
        UpdateMeasurementLevel3();

        UpdateBiologyLevel1();
        UpdateBiologyLevel2();
        UpdateBiologyLevel3();

        UpdateChemistryLevel1();
        UpdateChemistryLevel2();
        UpdateChemistryLevel3();

        UpdateEarthScienceLevel1();
        UpdateEarthScienceLevel2();
        UpdateEarthScienceLevel3();

    }

    void UpdateGrammarLevel1()
    {
        if (highScoreGrammarLevel1 > numOfStars)
        {
            highScoreGrammarLevel1 = numOfStars;
        }

        for (int i = 0; i < starsGrammarLevel1.Length; i++)
        {
            if (i < highScoreGrammarLevel1)
            {
                starsGrammarLevel1[i].sprite = fullStar;
            }
            else
            {
                starsGrammarLevel1[i].sprite = emptyStar;
            }
            if (i < numOfStars)
            {
                starsGrammarLevel1[i].enabled = true;
            }
            else
            {
                starsGrammarLevel1[i].enabled = false;
            }
        }
    }

    void UpdateGrammarLevel2()
    {
        if (highScoreGrammarLevel2 > numOfStars)
        {
            highScoreGrammarLevel2 = numOfStars;
        }

        for (int i = 0; i < starsGrammarLevel2.Length; i++)
        {
            if (i < highScoreGrammarLevel2)
            {
                starsGrammarLevel2[i].sprite = fullStar;
            }
            else
            {
                starsGrammarLevel2[i].sprite = emptyStar;
            }
            if (i < numOfStars)
            {
                starsGrammarLevel2[i].enabled = true;
            }
            else
            {
                starsGrammarLevel2[i].enabled = false;
            }
        }
    }

    void UpdateGrammarLevel3()
    {
        if (highScoreGrammarLevel3 > numOfStars)
        {
            highScoreGrammarLevel3 = numOfStars;
        }

        for (int i = 0; i < starsGrammarLevel3.Length; i++)
        {
            if (i < highScoreGrammarLevel3)
            {
                starsGrammarLevel3[i].sprite = fullStar;
            }
            else
            {
                starsGrammarLevel3[i].sprite = emptyStar;
            }
            if (i < numOfStars)
            {
                starsGrammarLevel3[i].enabled = true;
            }
            else
            {
                starsGrammarLevel3[i].enabled = false;
            }
        }
    }

    void UpdateSpellingLevel1()
    {
        if (highScoreSpellingLevel1 > numOfStars)
        {
            highScoreSpellingLevel1 = numOfStars;
        }

        for (int i = 0; i < starsSpellingLevel1.Length; i++)
        {
            if (i < highScoreSpellingLevel1)
            {
                starsSpellingLevel1[i].sprite = fullStar;
            }
            else
            {
                starsSpellingLevel1[i].sprite = emptyStar;
            }
            if (i < numOfStars)
            {
                starsSpellingLevel1[i].enabled = true;
            }
            else
            {
                starsSpellingLevel1[i].enabled = false;
            }
        }
    }

    void UpdateSpellingLevel2()
    {
        if (highScoreSpellingLevel2 > numOfStars)
        {
            highScoreSpellingLevel2 = numOfStars;
        }

        for (int i = 0; i < starsSpellingLevel2.Length; i++)
        {
            if (i < highScoreSpellingLevel2)
            {
                starsSpellingLevel2[i].sprite = fullStar;
            }
            else
            {
                starsSpellingLevel2[i].sprite = emptyStar;
            }
            if (i < numOfStars)
            {
                starsSpellingLevel2[i].enabled = true;
            }
            else
            {
                starsSpellingLevel2[i].enabled = false;
            }
        }
    }

    void UpdateSpellingLevel3()
    {
        if (highScoreSpellingLevel3 > numOfStars)
        {
            highScoreSpellingLevel3 = numOfStars;
        }

        for (int i = 0; i < starsSpellingLevel3.Length; i++)
        {
            if (i < highScoreSpellingLevel3)
            {
                starsSpellingLevel3[i].sprite = fullStar;
            }
            else
            {
                starsSpellingLevel3[i].sprite = emptyStar;
            }
            if (i < numOfStars)
            {
                starsSpellingLevel3[i].enabled = true;
            }
            else
            {
                starsSpellingLevel3[i].enabled = false;
            }
        }
    }

    void UpdateSynonymsAntonymsLevel1()
    {
        if (highScoreSynonymsAntonymsLevel1 > numOfStars)
        {
            highScoreSynonymsAntonymsLevel1 = numOfStars;
        }

        for (int i = 0; i < starsSynonymsAntonymsLevel1.Length; i++)
        {
            if (i < highScoreSynonymsAntonymsLevel1)
            {
                starsSynonymsAntonymsLevel1[i].sprite = fullStar;
            }
            else
            {
                starsSynonymsAntonymsLevel1[i].sprite = emptyStar;
            }
            if (i < numOfStars)
            {
                starsSynonymsAntonymsLevel1[i].enabled = true;
            }
            else
            {
                starsSynonymsAntonymsLevel1[i].enabled = false;
            }
        }
    }

    void UpdateSynonymsAntonymsLevel2()
    {
        if (highScoreSynonymsAntonymsLevel2 > numOfStars)
        {
            highScoreSynonymsAntonymsLevel2 = numOfStars;
        }

        for (int i = 0; i < starsSynonymsAntonymsLevel2.Length; i++)
        {
            if (i < highScoreSynonymsAntonymsLevel2)
            {
                starsSynonymsAntonymsLevel2[i].sprite = fullStar;
            }
            else
            {
                starsSynonymsAntonymsLevel2[i].sprite = emptyStar;
            }
            if (i < numOfStars)
            {
                starsSynonymsAntonymsLevel2[i].enabled = true;
            }
            else
            {
                starsSynonymsAntonymsLevel2[i].enabled = false;
            }
        }
    }

    void UpdateSynonymsAntonymsLevel3()
    {
        if (highScoreSynonymsAntonymsLevel3 > numOfStars)
        {
            highScoreSynonymsAntonymsLevel3 = numOfStars;
        }

        for (int i = 0; i < starsSynonymsAntonymsLevel3.Length; i++)
        {
            if (i < highScoreSynonymsAntonymsLevel3)
            {
                starsSynonymsAntonymsLevel3[i].sprite = fullStar;
            }
            else
            {
                starsSynonymsAntonymsLevel3[i].sprite = emptyStar;
            }
            if (i < numOfStars)
            {
                starsSynonymsAntonymsLevel3[i].enabled = true;
            }
            else
            {
                starsSynonymsAntonymsLevel3[i].enabled = false;
            }
        }
    }

    void UpdateArithmeticLevel1()
    {
        if (highScoreArithmeticLevel1 > numOfStars)
        {
            highScoreArithmeticLevel1 = numOfStars;
        }

        for (int i = 0; i < starsArithmeticLevel1.Length; i++)
        {
            if (i < highScoreArithmeticLevel1)
            {
                starsArithmeticLevel1[i].sprite = fullStar;
            }
            else
            {
                starsArithmeticLevel1[i].sprite = emptyStar;
            }
            if (i < numOfStars)
            {
                starsArithmeticLevel1[i].enabled = true;
            }
            else
            {
                starsArithmeticLevel1[i].enabled = false;
            }
        }
    }

    void UpdateArithmeticLevel2()
    {
        if (highScoreArithmeticLevel2 > numOfStars)
        {
            highScoreArithmeticLevel2 = numOfStars;
        }

        for (int i = 0; i < starsArithmeticLevel2.Length; i++)
        {
            if (i < highScoreArithmeticLevel2)
            {
                starsArithmeticLevel2[i].sprite = fullStar;
            }
            else
            {
                starsArithmeticLevel2[i].sprite = emptyStar;
            }
            if (i < numOfStars)
            {
                starsArithmeticLevel2[i].enabled = true;
            }
            else
            {
                starsArithmeticLevel2[i].enabled = false;
            }
        }
    }

    void UpdateArithmeticLevel3()
    {
        if (highScoreArithmeticLevel3 > numOfStars)
        {
            highScoreArithmeticLevel3 = numOfStars;
        }

        for (int i = 0; i < starsArithmeticLevel3.Length; i++)
        {
            if (i < highScoreArithmeticLevel3)
            {
                starsArithmeticLevel3[i].sprite = fullStar;
            }
            else
            {
                starsArithmeticLevel3[i].sprite = emptyStar;
            }
            if (i < numOfStars)
            {
                starsArithmeticLevel3[i].enabled = true;
            }
            else
            {
                starsArithmeticLevel3[i].enabled = false;
            }
        }
    }

    void UpdateGeometryLevel1()
    {
        if (highScoreGeometryLevel1 > numOfStars)
        {
            highScoreGeometryLevel1 = numOfStars;
        }

        for (int i = 0; i < starsGeometryLevel1.Length; i++)
        {
            if (i < highScoreGeometryLevel1)
            {
                starsGeometryLevel1[i].sprite = fullStar;
            }
            else
            {
                starsGeometryLevel1[i].sprite = emptyStar;
            }
            if (i < numOfStars)
            {
                starsGeometryLevel1[i].enabled = true;
            }
            else
            {
                starsGeometryLevel1[i].enabled = false;
            }
        }
    }

    void UpdateGeometryLevel2()
    {
        if (highScoreGeometryLevel2 > numOfStars)
        {
            highScoreGeometryLevel2 = numOfStars;
        }

        for (int i = 0; i < starsGeometryLevel2.Length; i++)
        {
            if (i < highScoreGeometryLevel2)
            {
                starsGeometryLevel2[i].sprite = fullStar;
            }
            else
            {
                starsGeometryLevel2[i].sprite = emptyStar;
            }
            if (i < numOfStars)
            {
                starsGeometryLevel2[i].enabled = true;
            }
            else
            {
                starsGeometryLevel2[i].enabled = false;
            }
        }
    }

    void UpdateGeometryLevel3()
    {
        if (highScoreGeometryLevel3 > numOfStars)
        {
            highScoreGeometryLevel3 = numOfStars;
        }

        for (int i = 0; i < starsGeometryLevel3.Length; i++)
        {
            if (i < highScoreGeometryLevel3)
            {
                starsGeometryLevel3[i].sprite = fullStar;
            }
            else
            {
                starsGeometryLevel3[i].sprite = emptyStar;
            }
            if (i < numOfStars)
            {
                starsGeometryLevel3[i].enabled = true;
            }
            else
            {
                starsGeometryLevel3[i].enabled = false;
            }
        }
    }

    void UpdateMeasurementLevel1()
    {
        if (highScoreMeasurementLevel1 > numOfStars)
        {
            highScoreMeasurementLevel1 = numOfStars;
        }

        for (int i = 0; i < starsMeasurementLevel1.Length; i++)
        {
            if (i < highScoreMeasurementLevel1)
            {
                starsMeasurementLevel1[i].sprite = fullStar;
            }
            else
            {
                starsMeasurementLevel1[i].sprite = emptyStar;
            }
            if (i < numOfStars)
            {
                starsMeasurementLevel1[i].enabled = true;
            }
            else
            {
                starsMeasurementLevel1[i].enabled = false;
            }
        }
    }

    void UpdateMeasurementLevel2()
    {
        if (highScoreMeasurementLevel2 > numOfStars)
        {
            highScoreMeasurementLevel2 = numOfStars;
        }

        for (int i = 0; i < starsMeasurementLevel2.Length; i++)
        {
            if (i < highScoreMeasurementLevel2)
            {
                starsMeasurementLevel2[i].sprite = fullStar;
            }
            else
            {
                starsMeasurementLevel2[i].sprite = emptyStar;
            }
            if (i < numOfStars)
            {
                starsMeasurementLevel2[i].enabled = true;
            }
            else
            {
                starsMeasurementLevel2[i].enabled = false;
            }
        }
    }

    void UpdateMeasurementLevel3()
    {
        if (highScoreMeasurementLevel3 > numOfStars)
        {
            highScoreMeasurementLevel3 = numOfStars;
        }

        for (int i = 0; i < starsMeasurementLevel3.Length; i++)
        {
            if (i < highScoreMeasurementLevel3)
            {
                starsMeasurementLevel3[i].sprite = fullStar;
            }
            else
            {
                starsMeasurementLevel3[i].sprite = emptyStar;
            }
            if (i < numOfStars)
            {
                starsMeasurementLevel3[i].enabled = true;
            }
            else
            {
                starsMeasurementLevel3[i].enabled = false;
            }
        }
    }

    void UpdateBiologyLevel1()
    {
        if (highScoreBiologyLevel1 > numOfStars)
        {
            highScoreBiologyLevel1 = numOfStars;
        }

        for (int i = 0; i < starsBiologyLevel1.Length; i++)
        {
            if (i < highScoreBiologyLevel1)
            {
                starsBiologyLevel1[i].sprite = fullStar;
            }
            else
            {
                starsBiologyLevel1[i].sprite = emptyStar;
            }
            if (i < numOfStars)
            {
                starsBiologyLevel1[i].enabled = true;
            }
            else
            {
                starsBiologyLevel1[i].enabled = false;
            }
        }
    }

    void UpdateBiologyLevel2()
    {
        if (highScoreBiologyLevel2 > numOfStars)
        {
            highScoreBiologyLevel2 = numOfStars;
        }

        for (int i = 0; i < starsBiologyLevel2.Length; i++)
        {
            if (i < highScoreBiologyLevel2)
            {
                starsBiologyLevel2[i].sprite = fullStar;
            }
            else
            {
                starsBiologyLevel2[i].sprite = emptyStar;
            }
            if (i < numOfStars)
            {
                starsBiologyLevel2[i].enabled = true;
            }
            else
            {
                starsBiologyLevel2[i].enabled = false;
            }
        }
    }

    void UpdateBiologyLevel3()
    {
        if (highScoreBiologyLevel3 > numOfStars)
        {
            highScoreBiologyLevel3 = numOfStars;
        }

        for (int i = 0; i < starsBiologyLevel3.Length; i++)
        {
            if (i < highScoreBiologyLevel3)
            {
                starsBiologyLevel3[i].sprite = fullStar;
            }
            else
            {
                starsBiologyLevel3[i].sprite = emptyStar;
            }
            if (i < numOfStars)
            {
                starsBiologyLevel3[i].enabled = true;
            }
            else
            {
                starsBiologyLevel3[i].enabled = false;
            }
        }
    }

    void UpdateChemistryLevel1()
    {
        if (highScoreChemistryLevel1 > numOfStars)
        {
            highScoreChemistryLevel1 = numOfStars;
        }

        for (int i = 0; i < starsChemistryLevel1.Length; i++)
        {
            if (i < highScoreChemistryLevel1)
            {
                starsChemistryLevel1[i].sprite = fullStar;
            }
            else
            {
                starsChemistryLevel1[i].sprite = emptyStar;
            }
            if (i < numOfStars)
            {
                starsChemistryLevel1[i].enabled = true;
            }
            else
            {
                starsChemistryLevel1[i].enabled = false;
            }
        }
    }

    void UpdateChemistryLevel2()
    {
        if (highScoreChemistryLevel2 > numOfStars)
        {
            highScoreChemistryLevel2 = numOfStars;
        }

        for (int i = 0; i < starsChemistryLevel2.Length; i++)
        {
            if (i < highScoreChemistryLevel2)
            {
                starsChemistryLevel2[i].sprite = fullStar;
            }
            else
            {
                starsChemistryLevel2[i].sprite = emptyStar;
            }
            if (i < numOfStars)
            {
                starsChemistryLevel2[i].enabled = true;
            }
            else
            {
                starsChemistryLevel2[i].enabled = false;
            }
        }
    }

    void UpdateChemistryLevel3()
    {
        if (highScoreChemistryLevel3 > numOfStars)
        {
            highScoreChemistryLevel3 = numOfStars;
        }

        for (int i = 0; i < starsChemistryLevel3.Length; i++)
        {
            if (i < highScoreChemistryLevel3)
            {
                starsChemistryLevel3[i].sprite = fullStar;
            }
            else
            {
                starsChemistryLevel3[i].sprite = emptyStar;
            }
            if (i < numOfStars)
            {
                starsChemistryLevel3[i].enabled = true;
            }
            else
            {
                starsChemistryLevel3[i].enabled = false;
            }
        }
    }

    void UpdateEarthScienceLevel1()
    {
        if (highScoreEarthScienceLevel1 > numOfStars)
        {
            highScoreEarthScienceLevel1 = numOfStars;
        }

        for (int i = 0; i < starsEarthScienceLevel1.Length; i++)
        {
            if (i < highScoreEarthScienceLevel1)
            {
                starsEarthScienceLevel1[i].sprite = fullStar;
            }
            else
            {
                starsEarthScienceLevel1[i].sprite = emptyStar;
            }
            if (i < numOfStars)
            {
                starsEarthScienceLevel1[i].enabled = true;
            }
            else
            {
                starsEarthScienceLevel1[i].enabled = false;
            }
        }
    }

    void UpdateEarthScienceLevel2()
    {
        if (highScoreEarthScienceLevel2 > numOfStars)
        {
            highScoreEarthScienceLevel2 = numOfStars;
        }

        for (int i = 0; i < starsEarthScienceLevel2.Length; i++)
        {
            if (i < highScoreEarthScienceLevel2)
            {
                starsEarthScienceLevel2[i].sprite = fullStar;
            }
            else
            {
                starsEarthScienceLevel2[i].sprite = emptyStar;
            }
            if (i < numOfStars)
            {
                starsEarthScienceLevel2[i].enabled = true;
            }
            else
            {
                starsEarthScienceLevel2[i].enabled = false;
            }
        }
    }

    void UpdateEarthScienceLevel3()
    {
        if (highScoreEarthScienceLevel3 > numOfStars)
        {
            highScoreEarthScienceLevel3 = numOfStars;
        }

        for (int i = 0; i < starsEarthScienceLevel3.Length; i++)
        {
            if (i < highScoreEarthScienceLevel3)
            {
                starsEarthScienceLevel3[i].sprite = fullStar;
            }
            else
            {
                starsEarthScienceLevel3[i].sprite = emptyStar;
            }
            if (i < numOfStars)
            {
                starsEarthScienceLevel3[i].enabled = true;
            }
            else
            {
                starsEarthScienceLevel3[i].enabled = false;
            }
        }
    }

}
