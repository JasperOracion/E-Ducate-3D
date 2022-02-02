using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenQuestion : MonoBehaviour
{
    public void StartQuestion()
    {
        transform.LeanMove(new Vector2(0, 0), 1f);
    }
}
