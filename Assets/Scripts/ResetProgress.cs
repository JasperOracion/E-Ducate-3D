using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetProgress : MonoBehaviour
{
    // Start is called before the first frame update
    public void ResetProgressButton()
    {
        PlayerPrefs.DeleteAll();
    }
}
