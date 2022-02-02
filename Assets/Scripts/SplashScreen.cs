using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplashScreen : MonoBehaviour
{

    [SerializeField]
    private GameObject register;
    [SerializeField]
    private GameObject mainMenu;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            if (PlayerPrefs.HasKey("firstName") & PlayerPrefs.HasKey("lastName") & PlayerPrefs.HasKey("age") & PlayerPrefs.HasKey("gradeLevel"))
            {
                gameObject.SetActive(false);
                mainMenu.SetActive(true);
            }
            else
            {
                gameObject.SetActive(false);
                register.SetActive(true);
            }
        }
    }
}
