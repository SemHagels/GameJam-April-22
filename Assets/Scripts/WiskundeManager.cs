using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WiskundeManager : MonoBehaviour
{
    public GameObject Q1;
    public GameObject Q2;
    public GameObject Q3;
    public GameObject Q4;
    public GameObject Q5;
    // Start is called before the first frame update
    void Start()
    {
        //turn off all exept Q1 (prefents game from breaking)
        Q1.SetActive(true);
        Q2.SetActive(false);
        Q3.SetActive(false);
        Q4.SetActive(false);
        Q5.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void CorrectAnswer()
    {
        Q1.SetActive(false);
        Q2.SetActive(true);
    }
    public void CorrectAnswer1()
    {
        Q2.SetActive(false);
        Q3.SetActive(true);
    }
    public void CorrectAnswer2()
    {
        Q3.SetActive(false);
        Q4.SetActive(true);
    }
    public void CorrectAnswer3()
    {
        Q4.SetActive(false);
        Q5.SetActive(true);
    }
    public void LastCorrect()
    {
        //load next (random) scene
    }
    public void WrongAnswer()
    {
        //loads the gameover scene
        print("GameOver!");
    }
}
