using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIController : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI questionText;
    [SerializeField]
    private TextMeshProUGUI questionSubtext;

    [SerializeField]
    private TextMeshProUGUI answerUnit;

    [SerializeField]
    private Image questionImage1;
    [SerializeField]
    private Image questionImage2;
    [SerializeField]
    private Image questionImage3;
    [SerializeField]
    private Image questionImage4;
    [SerializeField]
    private Image questionImage5;
    [SerializeField]
    private Image questionImage6;
    [SerializeField]
    private Image questionImage7;
    [SerializeField]
    private Image questionImage8;
    [SerializeField]
    private Image questionImage9;
    [SerializeField]
    private Image answerImage1;
    [SerializeField]
    private Image answerImage2;
    [SerializeField]
    private Image answerImage3;
    [SerializeField]
    private Image answerImage4;
    [SerializeField]
    private Image answerImage5;
    [SerializeField]
    private Image answerImage6;
    [SerializeField]
    private Image answerImage7;
    [SerializeField]
    private Image answerImage8;
    [SerializeField]
    private Sprite[] spritesGeometryLevel1;
    [SerializeField]
    private Sprite[] spritesGeometryLevel2;
    [SerializeField]
    private Sprite[] spritesGeometryLevel3;
    [SerializeField]
    private Sprite[] spritesMeasurementLevel1;
    [SerializeField]
    private Sprite[] spritesBiologyLevel1;
    [SerializeField]
    private Sprite[] spritesBiologyLevel3;
    [SerializeField]
    private Sprite[] spritesEarthScienceLevel3;
    [SerializeField]
    private Sprite[] spritesChemistryLevel1;
    [SerializeField]
    private Sprite[] spritesChemistryLevel3;
    [SerializeField]
    private Sprite[] spritesSpellingLevel1;
    [SerializeField]
    private Sprite[] spritesSpellingLevel2;
    [SerializeField]
    private Sprite[] spritesSpellingLevel3;
    [SerializeField]
    private AudioClip[] soundsSpellingLevel1;
    [SerializeField]
    private AudioClip[] soundsSpellingLevel2;
    [SerializeField]
    private AudioClip[] soundsSpellingLevel3;
    [SerializeField]
    private Sprite[] spritesGrammarLevel2;
    [SerializeField]
    private Sprite[] spritesSynonymsAntonymsLevel1;
    [SerializeField]
    private Sprite[] spritesSynonymsAntonymsLevel2;
    [SerializeField]
    private Sprite[] spritesSynonymsAntonymsLevel3;
    [SerializeField]
    private Button[] answerButtons;

    [SerializeField]
    private GameObject correctAnswerPopup;
    [SerializeField]
    private GameObject wrongAnswerPopup;

    [SerializeField]
    private AudioSource correctAnswerSFX;
    [SerializeField]
    private AudioSource wrongAnswerSFX;
    [SerializeField]
    private AudioSource audioPlaySpellingTTS;

    public void SetupUIForQuestion(QuizQuestion question)
    {
        correctAnswerPopup.SetActive(false);
        wrongAnswerPopup.SetActive(false);

        questionText.text = question.Question;

        // Geometry Level 1
        if (questionText.text == "Circle, Oval, Circle, Circle, Oval, _____?")
        {
            questionImage1.gameObject.SetActive(true);
            questionImage2.gameObject.SetActive(true);
            questionImage3.gameObject.SetActive(true);
            questionImage4.gameObject.SetActive(true);
            questionImage5.gameObject.SetActive(true);
            questionImage6.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesGeometryLevel1[6];
            questionImage2.GetComponent<Image>().sprite = spritesGeometryLevel1[14];
            questionImage3.GetComponent<Image>().sprite = spritesGeometryLevel1[6];
            questionImage4.GetComponent<Image>().sprite = spritesGeometryLevel1[6];
            questionImage5.GetComponent<Image>().sprite = spritesGeometryLevel1[14];
            questionImage6.GetComponent<Image>().sprite = spritesGeometryLevel1[11];

            answerImage1.gameObject.SetActive(true);
            answerImage3.gameObject.SetActive(true);
            answerImage5.gameObject.SetActive(true);
            answerImage7.gameObject.SetActive(true);

            answerImage1.GetComponent<Image>().sprite = spritesGeometryLevel1[6];
            answerImage3.GetComponent<Image>().sprite = spritesGeometryLevel1[14];
            answerImage5.GetComponent<Image>().sprite = spritesGeometryLevel1[22];
            answerImage7.GetComponent<Image>().sprite = spritesGeometryLevel1[17];
        }
        if (questionText.text == "Square, Rectangle, Square, Rectangle, Square, Rectangle, _____?")
        {
            questionImage1.gameObject.SetActive(true);
            questionImage2.gameObject.SetActive(true);
            questionImage3.gameObject.SetActive(true);
            questionImage4.gameObject.SetActive(true);
            questionImage5.gameObject.SetActive(true);
            questionImage6.gameObject.SetActive(true);
            questionImage7.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesGeometryLevel1[22];
            questionImage2.GetComponent<Image>().sprite = spritesGeometryLevel1[17];
            questionImage3.GetComponent<Image>().sprite = spritesGeometryLevel1[22];
            questionImage4.GetComponent<Image>().sprite = spritesGeometryLevel1[17];
            questionImage5.GetComponent<Image>().sprite = spritesGeometryLevel1[22];
            questionImage6.GetComponent<Image>().sprite = spritesGeometryLevel1[17];
            questionImage7.GetComponent<Image>().sprite = spritesGeometryLevel1[11];

            answerImage1.gameObject.SetActive(true);
            answerImage3.gameObject.SetActive(true);
            answerImage5.gameObject.SetActive(true);
            answerImage7.gameObject.SetActive(true);

            answerImage1.GetComponent<Image>().sprite = spritesGeometryLevel1[17];
            answerImage3.GetComponent<Image>().sprite = spritesGeometryLevel1[22];
            answerImage5.GetComponent<Image>().sprite = spritesGeometryLevel1[6];
            answerImage7.GetComponent<Image>().sprite = spritesGeometryLevel1[14];
        }
        if (questionText.text == "Apple, Mango, Mango, Apple, Apple, Mango, Mango, _____?")
        {
            questionImage1.gameObject.SetActive(true);
            questionImage2.gameObject.SetActive(true);
            questionImage3.gameObject.SetActive(true);
            questionImage4.gameObject.SetActive(true);
            questionImage5.gameObject.SetActive(true);
            questionImage6.gameObject.SetActive(true);
            questionImage7.gameObject.SetActive(true);
            questionImage8.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesGeometryLevel1[0];
            questionImage2.GetComponent<Image>().sprite = spritesGeometryLevel1[12];
            questionImage3.GetComponent<Image>().sprite = spritesGeometryLevel1[12];
            questionImage4.GetComponent<Image>().sprite = spritesGeometryLevel1[0];
            questionImage5.GetComponent<Image>().sprite = spritesGeometryLevel1[0];
            questionImage6.GetComponent<Image>().sprite = spritesGeometryLevel1[12];
            questionImage7.GetComponent<Image>().sprite = spritesGeometryLevel1[12];
            questionImage8.GetComponent<Image>().sprite = spritesGeometryLevel1[11];

            answerImage1.gameObject.SetActive(true);
            answerImage3.gameObject.SetActive(true);
            answerImage5.gameObject.SetActive(true);
            answerImage7.gameObject.SetActive(true);

            answerImage1.GetComponent<Image>().sprite = spritesGeometryLevel1[0];
            answerImage3.GetComponent<Image>().sprite = spritesGeometryLevel1[12];
            answerImage5.GetComponent<Image>().sprite = spritesGeometryLevel1[1];
            answerImage7.GetComponent<Image>().sprite = spritesGeometryLevel1[13];
        }
        if (questionText.text == "Cat, Cat, Cat, Dog, Dog, Dog, Cat, Cat, _____?")
        {
            questionImage1.gameObject.SetActive(true);
            questionImage2.gameObject.SetActive(true);
            questionImage3.gameObject.SetActive(true);
            questionImage4.gameObject.SetActive(true);
            questionImage5.gameObject.SetActive(true);
            questionImage6.gameObject.SetActive(true);
            questionImage7.gameObject.SetActive(true);
            questionImage8.gameObject.SetActive(true);
            questionImage9.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesGeometryLevel1[4];
            questionImage2.GetComponent<Image>().sprite = spritesGeometryLevel1[4];
            questionImage3.GetComponent<Image>().sprite = spritesGeometryLevel1[4];
            questionImage4.GetComponent<Image>().sprite = spritesGeometryLevel1[7];
            questionImage5.GetComponent<Image>().sprite = spritesGeometryLevel1[7];
            questionImage6.GetComponent<Image>().sprite = spritesGeometryLevel1[7];
            questionImage7.GetComponent<Image>().sprite = spritesGeometryLevel1[4];
            questionImage8.GetComponent<Image>().sprite = spritesGeometryLevel1[4];
            questionImage9.GetComponent<Image>().sprite = spritesGeometryLevel1[11];

            answerImage1.gameObject.SetActive(true);
            answerImage3.gameObject.SetActive(true);
            answerImage5.gameObject.SetActive(true);
            answerImage7.gameObject.SetActive(true);

            answerImage1.GetComponent<Image>().sprite = spritesGeometryLevel1[4];
            answerImage3.GetComponent<Image>().sprite = spritesGeometryLevel1[7];
            answerImage5.GetComponent<Image>().sprite = spritesGeometryLevel1[3];
            answerImage7.GetComponent<Image>().sprite = spritesGeometryLevel1[10];
        }
        if (questionText.text == "Triangle, Triangle, Trapezoid, Triangle, Triangle, Trapezoid, _____?")
        {
            questionImage1.gameObject.SetActive(true);
            questionImage2.gameObject.SetActive(true);
            questionImage3.gameObject.SetActive(true);
            questionImage4.gameObject.SetActive(true);
            questionImage5.gameObject.SetActive(true);
            questionImage6.gameObject.SetActive(true);
            questionImage7.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesGeometryLevel1[25];
            questionImage2.GetComponent<Image>().sprite = spritesGeometryLevel1[25];
            questionImage3.GetComponent<Image>().sprite = spritesGeometryLevel1[24];
            questionImage4.GetComponent<Image>().sprite = spritesGeometryLevel1[25];
            questionImage5.GetComponent<Image>().sprite = spritesGeometryLevel1[25];
            questionImage6.GetComponent<Image>().sprite = spritesGeometryLevel1[24];
            questionImage7.GetComponent<Image>().sprite = spritesGeometryLevel1[11];

            answerImage1.gameObject.SetActive(true);
            answerImage3.gameObject.SetActive(true);
            answerImage5.gameObject.SetActive(true);
            answerImage7.gameObject.SetActive(true);

            answerImage1.GetComponent<Image>().sprite = spritesGeometryLevel1[24];
            answerImage3.GetComponent<Image>().sprite = spritesGeometryLevel1[25];
            answerImage5.GetComponent<Image>().sprite = spritesGeometryLevel1[15];
            answerImage7.GetComponent<Image>().sprite = spritesGeometryLevel1[18];
        }
        if (questionText.text == "Chicken, Chicken, Egg, Egg, Chicken, Chicken, _____, _____?")
        {
            questionImage1.gameObject.SetActive(true);
            questionImage2.gameObject.SetActive(true);
            questionImage3.gameObject.SetActive(true);
            questionImage4.gameObject.SetActive(true);
            questionImage5.gameObject.SetActive(true);
            questionImage6.gameObject.SetActive(true);
            questionImage7.gameObject.SetActive(true);
            questionImage8.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesGeometryLevel1[5];
            questionImage2.GetComponent<Image>().sprite = spritesGeometryLevel1[5];
            questionImage3.GetComponent<Image>().sprite = spritesGeometryLevel1[8];
            questionImage4.GetComponent<Image>().sprite = spritesGeometryLevel1[8];
            questionImage5.GetComponent<Image>().sprite = spritesGeometryLevel1[5];
            questionImage6.GetComponent<Image>().sprite = spritesGeometryLevel1[5];
            questionImage7.GetComponent<Image>().sprite = spritesGeometryLevel1[11];
            questionImage8.GetComponent<Image>().sprite = spritesGeometryLevel1[11];

            answerImage1.gameObject.SetActive(true);
            answerImage2.gameObject.SetActive(true);
            answerImage3.gameObject.SetActive(true);
            answerImage4.gameObject.SetActive(true);
            answerImage5.gameObject.SetActive(true);
            answerImage6.gameObject.SetActive(true);
            answerImage7.gameObject.SetActive(true);
            answerImage8.gameObject.SetActive(true);

            answerImage1.GetComponent<Image>().sprite = spritesGeometryLevel1[5];
            answerImage2.GetComponent<Image>().sprite = spritesGeometryLevel1[5];
            answerImage3.GetComponent<Image>().sprite = spritesGeometryLevel1[5];
            answerImage4.GetComponent<Image>().sprite = spritesGeometryLevel1[8];
            answerImage5.GetComponent<Image>().sprite = spritesGeometryLevel1[8];
            answerImage6.GetComponent<Image>().sprite = spritesGeometryLevel1[5];
            answerImage7.GetComponent<Image>().sprite = spritesGeometryLevel1[8];
            answerImage8.GetComponent<Image>().sprite = spritesGeometryLevel1[8];
        }
        if (questionText.text == "Soccerball, Basketball, Soccerball, Basketball, Soccerball, Basketball, _____, _____?")
        {
            questionImage1.gameObject.SetActive(true);
            questionImage2.gameObject.SetActive(true);
            questionImage3.gameObject.SetActive(true);
            questionImage4.gameObject.SetActive(true);
            questionImage5.gameObject.SetActive(true);
            questionImage6.gameObject.SetActive(true);
            questionImage7.gameObject.SetActive(true);
            questionImage8.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesGeometryLevel1[20];
            questionImage2.GetComponent<Image>().sprite = spritesGeometryLevel1[2];
            questionImage3.GetComponent<Image>().sprite = spritesGeometryLevel1[20];
            questionImage4.GetComponent<Image>().sprite = spritesGeometryLevel1[2];
            questionImage5.GetComponent<Image>().sprite = spritesGeometryLevel1[20];
            questionImage6.GetComponent<Image>().sprite = spritesGeometryLevel1[2];
            questionImage7.GetComponent<Image>().sprite = spritesGeometryLevel1[11];
            questionImage8.GetComponent<Image>().sprite = spritesGeometryLevel1[11];

            answerImage1.gameObject.SetActive(true);
            answerImage2.gameObject.SetActive(true);
            answerImage3.gameObject.SetActive(true);
            answerImage4.gameObject.SetActive(true);
            answerImage5.gameObject.SetActive(true);
            answerImage6.gameObject.SetActive(true);
            answerImage7.gameObject.SetActive(true);
            answerImage8.gameObject.SetActive(true);

            answerImage1.GetComponent<Image>().sprite = spritesGeometryLevel1[20];
            answerImage2.GetComponent<Image>().sprite = spritesGeometryLevel1[20];
            answerImage3.GetComponent<Image>().sprite = spritesGeometryLevel1[20];
            answerImage4.GetComponent<Image>().sprite = spritesGeometryLevel1[2];
            answerImage5.GetComponent<Image>().sprite = spritesGeometryLevel1[2];
            answerImage6.GetComponent<Image>().sprite = spritesGeometryLevel1[20];
            answerImage7.GetComponent<Image>().sprite = spritesGeometryLevel1[2];
            answerImage8.GetComponent<Image>().sprite = spritesGeometryLevel1[2];
        }
        if (questionText.text == "Pineapple, Watermelon, Watermelon, Pineapple, Watermelon, Watermelon, _____, _____?")
        {
            questionImage1.gameObject.SetActive(true);
            questionImage2.gameObject.SetActive(true);
            questionImage3.gameObject.SetActive(true);
            questionImage4.gameObject.SetActive(true);
            questionImage5.gameObject.SetActive(true);
            questionImage6.gameObject.SetActive(true);
            questionImage7.gameObject.SetActive(true);
            questionImage8.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesGeometryLevel1[16];
            questionImage2.GetComponent<Image>().sprite = spritesGeometryLevel1[26];
            questionImage3.GetComponent<Image>().sprite = spritesGeometryLevel1[26];
            questionImage4.GetComponent<Image>().sprite = spritesGeometryLevel1[16];
            questionImage5.GetComponent<Image>().sprite = spritesGeometryLevel1[26];
            questionImage6.GetComponent<Image>().sprite = spritesGeometryLevel1[26];
            questionImage7.GetComponent<Image>().sprite = spritesGeometryLevel1[11];
            questionImage8.GetComponent<Image>().sprite = spritesGeometryLevel1[11];

            answerImage1.gameObject.SetActive(true);
            answerImage2.gameObject.SetActive(true);
            answerImage3.gameObject.SetActive(true);
            answerImage4.gameObject.SetActive(true);
            answerImage5.gameObject.SetActive(true);
            answerImage6.gameObject.SetActive(true);
            answerImage7.gameObject.SetActive(true);
            answerImage8.gameObject.SetActive(true);

            answerImage1.GetComponent<Image>().sprite = spritesGeometryLevel1[16];
            answerImage2.GetComponent<Image>().sprite = spritesGeometryLevel1[16];
            answerImage3.GetComponent<Image>().sprite = spritesGeometryLevel1[16];
            answerImage4.GetComponent<Image>().sprite = spritesGeometryLevel1[26];
            answerImage5.GetComponent<Image>().sprite = spritesGeometryLevel1[26];
            answerImage6.GetComponent<Image>().sprite = spritesGeometryLevel1[16];
            answerImage7.GetComponent<Image>().sprite = spritesGeometryLevel1[26];
            answerImage8.GetComponent<Image>().sprite = spritesGeometryLevel1[26];
        }
        if (questionText.text == "Short, T-shirt, T-shirt, T-shirt, Short, Short, _____, _____?")
        {
            questionImage1.gameObject.SetActive(true);
            questionImage2.gameObject.SetActive(true);
            questionImage3.gameObject.SetActive(true);
            questionImage4.gameObject.SetActive(true);
            questionImage5.gameObject.SetActive(true);
            questionImage6.gameObject.SetActive(true);
            questionImage7.gameObject.SetActive(true);
            questionImage8.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesGeometryLevel1[19];
            questionImage2.GetComponent<Image>().sprite = spritesGeometryLevel1[23];
            questionImage3.GetComponent<Image>().sprite = spritesGeometryLevel1[23];
            questionImage4.GetComponent<Image>().sprite = spritesGeometryLevel1[23];
            questionImage5.GetComponent<Image>().sprite = spritesGeometryLevel1[19];
            questionImage6.GetComponent<Image>().sprite = spritesGeometryLevel1[19];
            questionImage7.GetComponent<Image>().sprite = spritesGeometryLevel1[11];
            questionImage8.GetComponent<Image>().sprite = spritesGeometryLevel1[11];

            answerImage1.gameObject.SetActive(true);
            answerImage2.gameObject.SetActive(true);
            answerImage3.gameObject.SetActive(true);
            answerImage4.gameObject.SetActive(true);
            answerImage5.gameObject.SetActive(true);
            answerImage6.gameObject.SetActive(true);
            answerImage7.gameObject.SetActive(true);
            answerImage8.gameObject.SetActive(true);

            answerImage1.GetComponent<Image>().sprite = spritesGeometryLevel1[23];
            answerImage2.GetComponent<Image>().sprite = spritesGeometryLevel1[23];
            answerImage3.GetComponent<Image>().sprite = spritesGeometryLevel1[23];
            answerImage4.GetComponent<Image>().sprite = spritesGeometryLevel1[19];
            answerImage5.GetComponent<Image>().sprite = spritesGeometryLevel1[19];
            answerImage6.GetComponent<Image>().sprite = spritesGeometryLevel1[23];
            answerImage7.GetComponent<Image>().sprite = spritesGeometryLevel1[19];
            answerImage8.GetComponent<Image>().sprite = spritesGeometryLevel1[19];
        }
        if (questionText.text == "Spoon, Spoon, Fork, Spoon, Spoon, Fork, _____, _____?")
        {
            questionImage1.gameObject.SetActive(true);
            questionImage2.gameObject.SetActive(true);
            questionImage3.gameObject.SetActive(true);
            questionImage4.gameObject.SetActive(true);
            questionImage5.gameObject.SetActive(true);
            questionImage6.gameObject.SetActive(true);
            questionImage7.gameObject.SetActive(true);
            questionImage8.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesGeometryLevel1[21];
            questionImage2.GetComponent<Image>().sprite = spritesGeometryLevel1[21];
            questionImage3.GetComponent<Image>().sprite = spritesGeometryLevel1[9];
            questionImage4.GetComponent<Image>().sprite = spritesGeometryLevel1[21];
            questionImage5.GetComponent<Image>().sprite = spritesGeometryLevel1[21];
            questionImage6.GetComponent<Image>().sprite = spritesGeometryLevel1[9];
            questionImage7.GetComponent<Image>().sprite = spritesGeometryLevel1[11];
            questionImage8.GetComponent<Image>().sprite = spritesGeometryLevel1[11];

            answerImage1.gameObject.SetActive(true);
            answerImage2.gameObject.SetActive(true);
            answerImage3.gameObject.SetActive(true);
            answerImage4.gameObject.SetActive(true);
            answerImage5.gameObject.SetActive(true);
            answerImage6.gameObject.SetActive(true);
            answerImage7.gameObject.SetActive(true);
            answerImage8.gameObject.SetActive(true);

            answerImage1.GetComponent<Image>().sprite = spritesGeometryLevel1[9];
            answerImage2.GetComponent<Image>().sprite = spritesGeometryLevel1[9];
            answerImage3.GetComponent<Image>().sprite = spritesGeometryLevel1[9];
            answerImage4.GetComponent<Image>().sprite = spritesGeometryLevel1[21];
            answerImage5.GetComponent<Image>().sprite = spritesGeometryLevel1[21];
            answerImage6.GetComponent<Image>().sprite = spritesGeometryLevel1[9];
            answerImage7.GetComponent<Image>().sprite = spritesGeometryLevel1[21];
            answerImage8.GetComponent<Image>().sprite = spritesGeometryLevel1[21];
        }

        // Geometry Level 2
        if (questionText.text == "Heptagon")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesGeometryLevel2[2];
        }
        if (questionText.text == "Pentagon")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesGeometryLevel2[6];
        }
        if (questionText.text == "Decagon")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesGeometryLevel2[1];
        }
        if (questionText.text == "Octagon")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesGeometryLevel2[5];
        }
        if (questionText.text == "Nonagon")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesGeometryLevel2[4];
        }
        if (questionText.text == "Hexagon")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesGeometryLevel2[3];
        }
        if (questionText.text == "Triangle")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesGeometryLevel2[9];
        }
        if (questionText.text == "Square")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesGeometryLevel2[8];
        }
        if (questionText.text == "Circle")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesGeometryLevel2[0];
        }
        if (questionText.text == "Rectangle")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesGeometryLevel2[7];
        }

        // Geometry Level 3
        if (questionText.text == "Picture of two right triangle (same size)")
        {
            questionImage1.gameObject.SetActive(true);
            questionImage2.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesGeometryLevel3[8];
            questionImage2.GetComponent<Image>().sprite = spritesGeometryLevel3[8];
        }
        if (questionText.text == "Picture of an arrow")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesGeometryLevel3[0];
        }
        if (questionText.text == "Picture of an oval and an ellipse")
        {
            questionImage1.gameObject.SetActive(true);
            questionImage2.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesGeometryLevel3[5];
            questionImage2.GetComponent<Image>().sprite = spritesGeometryLevel3[4];
        }
        if (questionText.text == "Picture of a plant")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesGeometryLevel3[6];
        }
        if (questionText.text == "Picture of a square and a rectangle")
        {
            questionImage1.gameObject.SetActive(true);
            questionImage2.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesGeometryLevel3[9];
            questionImage2.GetComponent<Image>().sprite = spritesGeometryLevel3[7];
        }
        if (questionText.text == "Picture of a ball")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesGeometryLevel3[1];
        }
        if (questionText.text == "Side view picture of a dog")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesGeometryLevel3[2];
        }
        if (questionText.text == "Picture of two ellipses (same size)")
        {
            questionImage1.gameObject.SetActive(true);
            questionImage2.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesGeometryLevel3[4];
            questionImage2.GetComponent<Image>().sprite = spritesGeometryLevel3[4];
        }
        if (questionText.text == "Picture of two trapezoids (different size)")
        {
            questionImage1.gameObject.SetActive(true);
            questionImage2.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesGeometryLevel3[10];
            questionImage2.GetComponent<Image>().sprite = spritesGeometryLevel3[11];
        }
        if (questionText.text == "Picture of an egg")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesGeometryLevel3[3];
        }

        // Measurement Level 1
        if (questionText.text == "Pen or Ruler" || questionText.text == "Car or Bus" || questionText.text == "Tower or Tree" || questionText.text == "Motorcycle or Train" || questionText.text == "Snake or Worm")
        {
            questionSubtext.text = "Which of these is longer? (real-world scale)";
        }
        if (questionText.text == "Sack of Rice or Cotton Candy" || questionText.text == "Mobile Phone or Television" || questionText.text == "Clip or Pencil" || questionText.text == "Bucket of Water or Water Spray" || questionText.text == "Laptop or Paper")
        {
            questionSubtext.text = "Which of these is heavier? (real-world scale)";
        }

        if (questionText.text == "Pen or Ruler")
        {
            questionImage1.gameObject.SetActive(true);
            questionImage2.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesMeasurementLevel1[0];
            questionImage2.GetComponent<Image>().sprite = spritesMeasurementLevel1[1];

            answerImage1.gameObject.SetActive(true);
            answerImage3.gameObject.SetActive(true);

            answerImage1.GetComponent<Image>().sprite = spritesMeasurementLevel1[0];
            answerImage3.GetComponent<Image>().sprite = spritesMeasurementLevel1[1];
        }
        if (questionText.text == "Car or Bus")
        {
            questionImage1.gameObject.SetActive(true);
            questionImage2.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesMeasurementLevel1[3];
            questionImage2.GetComponent<Image>().sprite = spritesMeasurementLevel1[2];

            answerImage1.gameObject.SetActive(true);
            answerImage3.gameObject.SetActive(true);

            answerImage1.GetComponent<Image>().sprite = spritesMeasurementLevel1[3];
            answerImage3.GetComponent<Image>().sprite = spritesMeasurementLevel1[2];
        }
        if (questionText.text == "Tower or Tree")
        {
            questionImage1.gameObject.SetActive(true);
            questionImage2.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesMeasurementLevel1[4];
            questionImage2.GetComponent<Image>().sprite = spritesMeasurementLevel1[5];

            answerImage1.gameObject.SetActive(true);
            answerImage3.gameObject.SetActive(true);

            answerImage1.GetComponent<Image>().sprite = spritesMeasurementLevel1[4];
            answerImage3.GetComponent<Image>().sprite = spritesMeasurementLevel1[5];
        }
        if (questionText.text == "Motorcycle or Train")
        {
            questionImage1.gameObject.SetActive(true);
            questionImage2.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesMeasurementLevel1[6];
            questionImage2.GetComponent<Image>().sprite = spritesMeasurementLevel1[7];

            answerImage1.gameObject.SetActive(true);
            answerImage3.gameObject.SetActive(true);

            answerImage1.GetComponent<Image>().sprite = spritesMeasurementLevel1[6];
            answerImage3.GetComponent<Image>().sprite = spritesMeasurementLevel1[7];
        }
        if (questionText.text == "Snake or Worm")
        {
            questionImage1.gameObject.SetActive(true);
            questionImage2.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesMeasurementLevel1[8];
            questionImage2.GetComponent<Image>().sprite = spritesMeasurementLevel1[9];

            answerImage1.gameObject.SetActive(true);
            answerImage3.gameObject.SetActive(true);

            answerImage1.GetComponent<Image>().sprite = spritesMeasurementLevel1[8];
            answerImage3.GetComponent<Image>().sprite = spritesMeasurementLevel1[9];
        }
        if (questionText.text == "Sack of Rice or Cotton Candy")
        {
            questionImage1.gameObject.SetActive(true);
            questionImage2.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesMeasurementLevel1[11];
            questionImage2.GetComponent<Image>().sprite = spritesMeasurementLevel1[10];

            answerImage1.gameObject.SetActive(true);
            answerImage3.gameObject.SetActive(true);

            answerImage1.GetComponent<Image>().sprite = spritesMeasurementLevel1[11];
            answerImage3.GetComponent<Image>().sprite = spritesMeasurementLevel1[10];
        }
        if (questionText.text == "Mobile Phone or Television")
        {
            questionImage1.gameObject.SetActive(true);
            questionImage2.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesMeasurementLevel1[12];
            questionImage2.GetComponent<Image>().sprite = spritesMeasurementLevel1[13];

            answerImage1.gameObject.SetActive(true);
            answerImage3.gameObject.SetActive(true);

            answerImage1.GetComponent<Image>().sprite = spritesMeasurementLevel1[12];
            answerImage3.GetComponent<Image>().sprite = spritesMeasurementLevel1[13];
        }
        if (questionText.text == "Clip or Pencil")
        {
            questionImage1.gameObject.SetActive(true);
            questionImage2.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesMeasurementLevel1[14];
            questionImage2.GetComponent<Image>().sprite = spritesMeasurementLevel1[15];

            answerImage1.gameObject.SetActive(true);
            answerImage3.gameObject.SetActive(true);

            answerImage1.GetComponent<Image>().sprite = spritesMeasurementLevel1[14];
            answerImage3.GetComponent<Image>().sprite = spritesMeasurementLevel1[15];
        }
        if (questionText.text == "Bucket of Water or Water Spray")
        {
            questionImage1.gameObject.SetActive(true);
            questionImage2.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesMeasurementLevel1[16];
            questionImage2.GetComponent<Image>().sprite = spritesMeasurementLevel1[17];

            answerImage1.gameObject.SetActive(true);
            answerImage3.gameObject.SetActive(true);

            answerImage1.GetComponent<Image>().sprite = spritesMeasurementLevel1[16];
            answerImage3.GetComponent<Image>().sprite = spritesMeasurementLevel1[17];
        }
        if (questionText.text == "Laptop or Paper")
        {
            questionImage1.gameObject.SetActive(true);
            questionImage2.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesMeasurementLevel1[18];
            questionImage2.GetComponent<Image>().sprite = spritesMeasurementLevel1[19];

            answerImage1.gameObject.SetActive(true);
            answerImage3.gameObject.SetActive(true);

            answerImage1.GetComponent<Image>().sprite = spritesMeasurementLevel1[18];
            answerImage3.GetComponent<Image>().sprite = spritesMeasurementLevel1[19];
        }

        // Measurement Level 3
        if (questionText.text == "7 cm = ________ mm")
        {
            answerUnit.text = "mm";
        }
        if (questionText.text == "5 m = ________ cm")
        {
            answerUnit.text = "cm";
        }
        if (questionText.text == "96 in = ________ ft" || questionText.text == "8 yd = ________ ft" || questionText.text == "60 in = ________ ft" || questionText.text == "11 yd = ________ ft")
        {
            answerUnit.text = "ft";
        }
        if (questionText.text == "2,000 ml = ________ L")
        {
            answerUnit.text = "L";
        }
        if (questionText.text == "9 L = ________ ml")
        {
            answerUnit.text = "ml";
        }
        if (questionText.text == "1 mi = ________ yd" || questionText.text == "3 mi = ________ yd")
        {
            answerUnit.text = "yd";
        }

        // Biology Level 1
        if (questionText.text == "Guitar")
        {
            questionImage1.gameObject.SetActive(true);
            questionImage2.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesBiologyLevel1[1];
            questionImage2.GetComponent<Image>().sprite = spritesBiologyLevel1[0];
        }
        if (questionText.text == "Ice Cream")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesBiologyLevel1[2];
        }
        if (questionText.text == "Fire")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesBiologyLevel1[3];
        }
        if (questionText.text == "Book")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesBiologyLevel1[4];
        }
        if (questionText.text == "Flower")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesBiologyLevel1[5];
        }
        if (questionText.text == "Drums")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesBiologyLevel1[6];
        }
        if (questionText.text == "Cake")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesBiologyLevel1[7];
        }
        if (questionText.text == "Ice")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesBiologyLevel1[8];
        }
        if (questionText.text == "Television")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesBiologyLevel1[9];
        }
        if (questionText.text == "Skunk")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesBiologyLevel1[10];
        }

        // Biology Level 2
        if (questionText.text == "Whale")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesBiologyLevel3[0];
        }
        if (questionText.text == "Turtle")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesBiologyLevel3[1];
        }
        if (questionText.text == "Peacock")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesBiologyLevel3[2];
        }
        if (questionText.text == "Lion")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesBiologyLevel3[3];
        }
        if (questionText.text == "Snake")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesBiologyLevel3[4];
        }
        if (questionText.text == "Shark")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesBiologyLevel3[5];
        }
        if (questionText.text == "Goldfish")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesBiologyLevel3[6];
        }
        if (questionText.text == "Frog")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesBiologyLevel3[7];
        }
        if (questionText.text == "Ostrich")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesBiologyLevel3[8];
        }
        if (questionText.text == "Salamander")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesBiologyLevel3[9];
        }

        // Earth Science Level 3
        if (questionText.text == "Sea")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesEarthScienceLevel3[0];
        }
        if (questionText.text == "Luzon Rainforests")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesEarthScienceLevel3[1];
        }
        if (questionText.text == "Prairie")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesEarthScienceLevel3[2];
        }
        if (questionText.text == "Sahara Desert")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesEarthScienceLevel3[3];
        }
        if (questionText.text == "Alaska")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesEarthScienceLevel3[4];
        }
        if (questionText.text == "Mojave Desert")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesEarthScienceLevel3[5];
        }
        if (questionText.text == "Pampas")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesEarthScienceLevel3[6];
        }
        if (questionText.text == "Pond")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesEarthScienceLevel3[7];
        }
        if (questionText.text == "Antarctica")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesEarthScienceLevel3[8];
        }
        if (questionText.text == "Mindanao Montane Rainforests")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesEarthScienceLevel3[9];
        }

        // Chemistry Level 1
        if (questionText.text == "Air")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesChemistryLevel1[0];
        }
        if (questionText.text == "Soup")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesChemistryLevel1[1];
        }
        if (questionText.text == "Mobile Phone")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesChemistryLevel1[2];
        }
        if (questionText.text == "Tea")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesChemistryLevel1[3];
        }
        if (questionText.text == "Picture Frame")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesChemistryLevel1[4];
        }
        if (questionText.text == "Milk")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesChemistryLevel1[5];
        }
        if (questionText.text == "Balloon")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesChemistryLevel1[6];
        }
        if (questionText.text == "Basketball")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesChemistryLevel1[7];
        }
        if (questionText.text == "Swimming Pool")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesChemistryLevel1[8];
        }
        if (questionText.text == "Apple")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesChemistryLevel1[9];
        }

        // Chemistry Level 3
        if (questionText.text == "boiling water and salt")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesChemistryLevel3[0];
        }
        if (questionText.text == "separating coffee flavour from coffee beans")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesChemistryLevel3[1];
        }
        if (questionText.text == "separating nails from wood chips")
        {
            questionImage1.gameObject.SetActive(true);
            questionImage2.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesChemistryLevel3[2];
            questionImage2.GetComponent<Image>().sprite = spritesChemistryLevel3[3];
        }
        if (questionText.text == "separating pebbles and sand")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesChemistryLevel3[4];
        }
        if (questionText.text == "pouring off water, leaving rice behind")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesChemistryLevel3[5];
        }
        if (questionText.text == "separating metals in a scrapyard")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesChemistryLevel3[6];
        }
        if (questionText.text == "boiling water and sugar")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesChemistryLevel3[7];
        }
        if (questionText.text == "pouring off water, leaving sand behind")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesChemistryLevel3[8];
        }
        if (questionText.text == "separating pasta and water")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesChemistryLevel3[9];
        }
        if (questionText.text == "separating sand and gravel")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesChemistryLevel3[10];
        }

        // Spelling Level 1
        if (questionText.text == "bat")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesSpellingLevel1[0];

            questionSubtext.text = "a  t  b";

            audioPlaySpellingTTS.clip = soundsSpellingLevel1[0];
        }
        if (questionText.text == "hit")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesSpellingLevel1[1];

            questionSubtext.text = "t  h  i";

            audioPlaySpellingTTS.clip = soundsSpellingLevel1[1];
        }
        if (questionText.text == "jet")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesSpellingLevel1[2];

            questionSubtext.text = "e  t  j";

            audioPlaySpellingTTS.clip = soundsSpellingLevel1[2];
        }
        if (questionText.text == "mom")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesSpellingLevel1[3];

            questionSubtext.text = "o  m  m";

            audioPlaySpellingTTS.clip = soundsSpellingLevel1[3];
        }
        if (questionText.text == "flat")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesSpellingLevel1[4];

            questionSubtext.text = "a  l  f  t";

            audioPlaySpellingTTS.clip = soundsSpellingLevel1[4];
        }
        if (questionText.text == "mat")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesSpellingLevel1[5];

            questionSubtext.text = "t  m  a";

            audioPlaySpellingTTS.clip = soundsSpellingLevel1[5];
        }
        if (questionText.text == "fit")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesSpellingLevel1[6];

            questionSubtext.text = "t  f  i";

            audioPlaySpellingTTS.clip = soundsSpellingLevel1[6];
        }
        if (questionText.text == "net")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesSpellingLevel1[7];

            questionSubtext.text = "e  n  t";

            audioPlaySpellingTTS.clip = soundsSpellingLevel1[7];
        }
        if (questionText.text == "spot")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesSpellingLevel1[8];

            questionSubtext.text = "o  s  t  p";

            audioPlaySpellingTTS.clip = soundsSpellingLevel1[8];
        }
        if (questionText.text == "land")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesSpellingLevel1[9];

            questionSubtext.text = "d  a  l  n";

            audioPlaySpellingTTS.clip = soundsSpellingLevel1[9];
        }

        // Spelling Level 2
        if (questionText.text == "girl")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesSpellingLevel2[0];

            questionSubtext.text = "r  i  l  g";

            audioPlaySpellingTTS.clip = soundsSpellingLevel2[0];
        }
        if (questionText.text == "sleep")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesSpellingLevel2[1];

            questionSubtext.text = "e  s  e  l  p";

            audioPlaySpellingTTS.clip = soundsSpellingLevel2[1];
        }
        if (questionText.text == "shirt")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesSpellingLevel2[2];

            questionSubtext.text = "h  s  t  r  i";

            audioPlaySpellingTTS.clip = soundsSpellingLevel2[2];
        }
        if (questionText.text == "apple")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesSpellingLevel2[3];

            questionSubtext.text = "e  p  l  p  a";

            audioPlaySpellingTTS.clip = soundsSpellingLevel2[3];
        }
        if (questionText.text == "ate")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesSpellingLevel2[4];

            questionSubtext.text = "t  e  a";

            audioPlaySpellingTTS.clip = soundsSpellingLevel2[4];
        }
        if (questionText.text == "back")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesSpellingLevel2[5];

            questionSubtext.text = "a  c  b  k";

            audioPlaySpellingTTS.clip = soundsSpellingLevel2[5];
        }
        if (questionText.text == "call")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesSpellingLevel2[6];

            questionSubtext.text = "l  c  a  l";

            audioPlaySpellingTTS.clip = soundsSpellingLevel2[6];
        }
        if (questionText.text == "sing")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesSpellingLevel2[7];

            questionSubtext.text = "i  s  g  n";

            audioPlaySpellingTTS.clip = soundsSpellingLevel2[7];
        }
        if (questionText.text == "base")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesSpellingLevel2[8];

            questionSubtext.text = "e  b  s  a";

            audioPlaySpellingTTS.clip = soundsSpellingLevel2[8];
        }
        if (questionText.text == "baby")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesSpellingLevel2[9];

            questionSubtext.text = "y  b  b  a";

            audioPlaySpellingTTS.clip = soundsSpellingLevel2[9];
        }

        // Spelling Level 3
        if (questionText.text == "clock")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesSpellingLevel3[0];

            questionSubtext.text = "o  c  k  l  c";

            audioPlaySpellingTTS.clip = soundsSpellingLevel3[0];
        }
        if (questionText.text == "stairs")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesSpellingLevel3[1];

            questionSubtext.text = "i  s  a  t  s  r";

            audioPlaySpellingTTS.clip = soundsSpellingLevel3[1];
        }
        if (questionText.text == "balloon")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesSpellingLevel3[2];

            questionSubtext.text = "l  b  o  n  o  l  a";

            audioPlaySpellingTTS.clip = soundsSpellingLevel3[2];
        }
        if (questionText.text == "queen")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesSpellingLevel3[3];

            questionSubtext.text = "n  u  e  q  e";

            audioPlaySpellingTTS.clip = soundsSpellingLevel3[3];
        }
        if (questionText.text == "young")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesSpellingLevel3[4];

            questionSubtext.text = "u  g  n  y  o";

            audioPlaySpellingTTS.clip = soundsSpellingLevel3[4];
        }
        if (questionText.text == "leave")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesSpellingLevel3[5];

            questionSubtext.text = "v  l  a  e  e";

            audioPlaySpellingTTS.clip = soundsSpellingLevel3[5];
        }
        if (questionText.text == "trouble")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesSpellingLevel3[6];

            questionSubtext.text = "b  l  t  r  u  o  e";

            audioPlaySpellingTTS.clip = soundsSpellingLevel3[6];
        }
        if (questionText.text == "shiny")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesSpellingLevel3[7];

            questionSubtext.text = "i  s  y  h  n";

            audioPlaySpellingTTS.clip = soundsSpellingLevel3[7];
        }
        if (questionText.text == "health")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesSpellingLevel3[8];

            questionSubtext.text = "h  t  h  a  e  l";

            audioPlaySpellingTTS.clip = soundsSpellingLevel3[8];
        }
        if (questionText.text == "heard")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesSpellingLevel3[9];

            questionSubtext.text = "d  h  r  e  a";

            audioPlaySpellingTTS.clip = soundsSpellingLevel3[9];
        }

        // Grammar Level 2
        if (questionText.text == "Paula keeps on _________ of best gift for his father.")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesGrammarLevel2[0];
        }
        if (questionText.text == "Kyla is _________ because she got the lowest score on exam.")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesGrammarLevel2[1];
        }
        if (questionText.text == "Claire is _________.")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesGrammarLevel2[2];
        }
        if (questionText.text == "Jolly is _____ because it’s his first time joining a quiz bee.")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesGrammarLevel2[3];
        }

        // Synonyms Antonyms Level 1
        if (questionText.text == "Synonym of little")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesSynonymsAntonymsLevel1[0];
        }
        if (questionText.text == "Synonym of large")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesSynonymsAntonymsLevel1[1];
        }
        if (questionText.text == "Synonym of mad")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesSynonymsAntonymsLevel1[2];
        }
        if (questionText.text == "Synonym of unhappy")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesSynonymsAntonymsLevel1[3];
        }
        if (questionText.text == "Synonym of beautiful")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesSynonymsAntonymsLevel1[4];
        }
        if (questionText.text == "Antonym of hot")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesSynonymsAntonymsLevel1[5];
        }
        if (questionText.text == "Antonym of happy")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesSynonymsAntonymsLevel1[6];
        }
        if (questionText.text == "Antonym of bottom")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesSynonymsAntonymsLevel1[7];
        }
        if (questionText.text == "Antonym of big")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesSynonymsAntonymsLevel1[8];
        }
        if (questionText.text == "Antonym of short")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesSynonymsAntonymsLevel1[9];
        }

        // Synonyms Antonyms Level 2
        if (questionText.text == "Synonym of shut")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesSynonymsAntonymsLevel2[0];
        }
        if (questionText.text == "Synonym of sketch")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesSynonymsAntonymsLevel2[1];
        }
        if (questionText.text == "Synonym of quick")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesSynonymsAntonymsLevel2[2];
        }
        if (questionText.text == "Synonym of look")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesSynonymsAntonymsLevel2[3];
        }
        if (questionText.text == "Synonym of scared")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesSynonymsAntonymsLevel2[4];
        }
        if (questionText.text == "Antonym of fast")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesSynonymsAntonymsLevel2[5];
        }
        if (questionText.text == "Antonym of wet")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesSynonymsAntonymsLevel2[6];
        }
        if (questionText.text == "Antonym of woman")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesSynonymsAntonymsLevel2[7];
        }
        if (questionText.text == "Antonym of soft")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesSynonymsAntonymsLevel2[8];
        }
        if (questionText.text == "Antonym of little")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesSynonymsAntonymsLevel2[9];
        }

        // Synonyms Antonyms Level 3
        if (questionText.text == "Synonym of garbage")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesSynonymsAntonymsLevel3[0];
        }
        if (questionText.text == "Synonym of sick")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesSynonymsAntonymsLevel3[1];
        }
        if (questionText.text == "Synonym of begin")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesSynonymsAntonymsLevel3[2];
        }
        if (questionText.text == "Synonym of shout")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesSynonymsAntonymsLevel3[3];
        }
        if (questionText.text == "Synonym of similar")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesSynonymsAntonymsLevel3[4];
        }
        if (questionText.text == "Antonym of left")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesSynonymsAntonymsLevel3[5];
        }
        if (questionText.text == "Antonym of sick")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesSynonymsAntonymsLevel3[6];
        }
        if (questionText.text == "Antonym of full")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesSynonymsAntonymsLevel3[7];
        }
        if (questionText.text == "Antonym of light")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesSynonymsAntonymsLevel3[8];
        }
        if (questionText.text == "Antonym of good")
        {
            questionImage1.gameObject.SetActive(true);

            questionImage1.GetComponent<Image>().sprite = spritesSynonymsAntonymsLevel3[9];
        }

        for (int i = 0; i < question.Answers.Length; i++)
        {
            answerButtons[i].GetComponentInChildren<Text>().text = question.Answers[i];
            answerButtons[i].gameObject.SetActive(true);
        }

        for (int i = question.Answers.Length; i < answerButtons.Length; i++)
        {
            answerButtons[i].gameObject.SetActive(false);
        }
    }

    public void HandleSubmittedAnswer(bool isCorrect)
    {
        if (isCorrect)
        {
            correctAnswerSFX.Play();
            ToggleAnswerButtons(false);
            ShowCorrectAnswerPopup();
            StartCoroutine(ResetImages());
        }
        else
        {
            wrongAnswerSFX.Play();
            ShowWrongAnswerPopup();
        }
    }

    private void ToggleAnswerButtons(bool value)
    {
        for (int i = 0; i < answerButtons.Length; i++)
        {
            answerButtons[i].gameObject.SetActive(value);
        }
    }

    private IEnumerator ResetImages()
    {
            yield return new WaitForSeconds(6f);
            questionImage1.gameObject.SetActive(false);
            questionImage2.gameObject.SetActive(false);
            questionImage3.gameObject.SetActive(false);
            questionImage4.gameObject.SetActive(false);
            questionImage5.gameObject.SetActive(false);
            questionImage6.gameObject.SetActive(false);
            questionImage7.gameObject.SetActive(false);
            questionImage8.gameObject.SetActive(false);
            questionImage9.gameObject.SetActive(false);

            questionImage1.GetComponent<Image>().sprite = null;
            questionImage2.GetComponent<Image>().sprite = null;
            questionImage3.GetComponent<Image>().sprite = null;
            questionImage4.GetComponent<Image>().sprite = null;
            questionImage5.GetComponent<Image>().sprite = null;
            questionImage6.GetComponent<Image>().sprite = null;
            questionImage7.GetComponent<Image>().sprite = null;
            questionImage8.GetComponent<Image>().sprite = null;
            questionImage9.GetComponent<Image>().sprite = null;

            answerImage1.gameObject.SetActive(false);
            answerImage2.gameObject.SetActive(false);
            answerImage3.gameObject.SetActive(false);
            answerImage4.gameObject.SetActive(false);
            answerImage5.gameObject.SetActive(false);
            answerImage6.gameObject.SetActive(false);
            answerImage7.gameObject.SetActive(false);
            answerImage8.gameObject.SetActive(false);

            answerImage1.GetComponent<Image>().sprite = null;
            answerImage2.GetComponent<Image>().sprite = null;
            answerImage3.GetComponent<Image>().sprite = null;
            answerImage4.GetComponent<Image>().sprite = null;
            answerImage5.GetComponent<Image>().sprite = null;
            answerImage6.GetComponent<Image>().sprite = null;
            answerImage7.GetComponent<Image>().sprite = null;
            answerImage8.GetComponent<Image>().sprite = null;
    }

    private void ShowCorrectAnswerPopup()
    {
        correctAnswerPopup.SetActive(true);
    }

    private void ShowWrongAnswerPopup()
    {
        wrongAnswerPopup.SetActive(true);
    }

    public void PlaySpellingTTS()
    {
        audioPlaySpellingTTS.Play();
    }
}