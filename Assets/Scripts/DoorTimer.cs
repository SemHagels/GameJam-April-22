using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTimer : MonoBehaviour
{
    public GameObject doorOpen1;
    public GameObject doorClosed1;
    public GameObject doorOpen2;
    public GameObject doorClosed2;
    public GameObject doorOpen3;
    public GameObject doorClosed3;
    float timer;
    float wait = 2.5f;


    void Start()
    {
        
    }

    void Update()
    {
        if (timer > wait)
        {
            doorClosed1.SetActive(true);
            doorOpen1.SetActive(false);
            doorClosed2.SetActive(true);
            doorOpen2.SetActive(false);
            doorClosed3.SetActive(true);
            doorOpen3.SetActive(false);
            timer = 0;
        }

        timer += Time.deltaTime;
    }
}
