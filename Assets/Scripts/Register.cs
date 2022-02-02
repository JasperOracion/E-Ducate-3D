using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Text.RegularExpressions;
using UnityEngine.SceneManagement;
public class Register : MonoBehaviour
{
    public string firstName;
    public string lastName;
    public string playerAge;
    public string playerGrade;


    public TMP_InputField inputField1;
    public TMP_InputField inputField2;
    public TMP_InputField inputField3;
    public TMP_InputField inputField4;
    public GameObject incompletePanel;

    [SerializeField]
    private GameObject mainMenu;



    public void StoreName()
    {
        
        if (((!string.IsNullOrEmpty(inputField1.text))) && (!string.IsNullOrEmpty(inputField2.text)) && (!string.IsNullOrEmpty(inputField3.text)) && (!string.IsNullOrEmpty(inputField4.text)))
        {
            firstName = inputField1.text;
            lastName = inputField2.text;
            playerAge = inputField3.text;
            playerGrade = inputField4.text;
            Debug.Log("User registered");
            Debug.Log("The user data is saved");
            Debug.Log("jumps to the home screen");
            PlayerPrefs.SetString("firstName", firstName);
            PlayerPrefs.SetString("lastName", lastName);
            PlayerPrefs.SetString("age", playerAge);
            PlayerPrefs.SetString("gradeLevel", playerGrade);


            gameObject.SetActive(false);
            mainMenu.SetActive(true);
        }
        else
        {
            Debug.Log("User input in registration incomplete");
            incompletePanel.SetActive(true);
        }
    }
    public void HandleGrade(int gradeValue)//masa-save agad sa playerprefs yung grade ng player sa registration everytime na magset sya
    {
        if (gradeValue == 0)
        {
            PlayerPrefs.SetString("gradeLevel", "");
            Debug.Log("The user chose grade " + PlayerPrefs.GetString("gradeLevel"));
        }
        if (gradeValue == 1)
        {
            PlayerPrefs.SetString("gradeLevel", "1");
            Debug.Log("The user chose grade " + PlayerPrefs.GetString("gradeLevel"));

        }
        if (gradeValue == 2)
        {
            PlayerPrefs.SetString("gradeLevel", "2");
            Debug.Log("The user chose grade " + PlayerPrefs.GetString("gradeLevel"));
        }
        if (gradeValue == 3)
        {
            PlayerPrefs.SetString("gradeLevel", "3");
            Debug.Log("The user chose grade " + PlayerPrefs.GetString("gradeLevel"));
        }
    }

    public void HandleAge(int ageValue)//same ng sa taas
    {
        if (ageValue == 0)
        {
            PlayerPrefs.SetString("age", "");
            Debug.Log("The user chose age " + PlayerPrefs.GetString("age"));
        }
        if (ageValue == 1)
        {
            PlayerPrefs.SetString("age", "5");
            Debug.Log("The user chose age " + PlayerPrefs.GetString("age"));

        }
        if (ageValue == 2)
        {
            PlayerPrefs.SetString("age", "6");
            Debug.Log("The user chose age " + PlayerPrefs.GetString("age"));
        }
        if (ageValue == 3)
        {
            PlayerPrefs.SetString("age", "7");
            Debug.Log("The user chose age " + PlayerPrefs.GetString("age"));
        }
        if (ageValue == 4)
        {
            PlayerPrefs.SetString("age", "8");
            Debug.Log("The user chose age " + PlayerPrefs.GetString("age"));
        }
        if (ageValue == 5)
        {
            PlayerPrefs.SetString("age", "9");
            Debug.Log("The user chose age " + PlayerPrefs.GetString("age"));
        }
        if (ageValue == 6)
        {
            PlayerPrefs.SetString("age", "10");
            Debug.Log("The user chose age " + PlayerPrefs.GetString("age"));
        }
        if (ageValue == 7)
        {
            PlayerPrefs.SetString("age", "11");
            Debug.Log("The user chose age " + PlayerPrefs.GetString("age"));
        }
        if (ageValue == 8)
        {
            PlayerPrefs.SetString("age", "12");
            Debug.Log("The user chose age " + PlayerPrefs.GetString("age"));
        }
        if (ageValue == 9)
        {
            PlayerPrefs.SetString("age", "13");
            Debug.Log("The user chose age " + PlayerPrefs.GetString("age"));
        }
        if (ageValue == 10)
        {
            PlayerPrefs.SetString("age", "14");
            Debug.Log("The user chose age " + PlayerPrefs.GetString("age"));
        }
        if (ageValue == 11)
        {
            PlayerPrefs.SetString("age", "15");
            Debug.Log("The user chose age " + PlayerPrefs.GetString("age"));
        }
        if (ageValue == 12)
        {
            PlayerPrefs.SetString("age", "16");
            Debug.Log("The user chose age " + PlayerPrefs.GetString("age"));
        }
        if (ageValue == 13)
        {
            PlayerPrefs.SetString("age", "17");
            Debug.Log("The user chose age " + PlayerPrefs.GetString("age"));
        }
        if (ageValue == 14)
        {
            PlayerPrefs.SetString("age", "18");
            Debug.Log("The user chose age " + PlayerPrefs.GetString("age"));
        }
        if (ageValue == 15)
        {
            PlayerPrefs.SetString("age", "19");
            Debug.Log("The user chose age " + PlayerPrefs.GetString("age"));
        }
        if (ageValue == 16)
        {
            PlayerPrefs.SetString("age", "20");
            Debug.Log("The user chose age " + PlayerPrefs.GetString("age"));
        }
    }
}