using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static int Score = 0;
    public Text text;

    // Update is called once per frame
    void Update()
    {
        text.text = Score.ToString();
    }
}
