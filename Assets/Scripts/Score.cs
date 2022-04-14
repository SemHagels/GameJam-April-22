using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;   

public class Score : MonoBehaviour
{
    public static int score;
    public Text scoreBoardText;

    private void Update()
    {
        GetComponent<Text>().text = score.ToString();
        scoreBoardText.text = score.ToString();
    }
}
