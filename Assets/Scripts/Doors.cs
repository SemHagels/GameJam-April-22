using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doors : MonoBehaviour
{
    public GameObject doorOpen1;
    public GameObject doorClosed1;
    public GameObject doorOpen2;
    public GameObject doorClosed2;
    public GameObject doorOpen3;
    public GameObject doorClosed3;
    float timer;
    float wait1 = 2f;
    int door1 ;
    int door2;
    int door3;
    int check1;
    int check2 = 1;


    void Start()
    {
        
    }

    
    void Update()
    {
        if (check1 < check2)
        {
            if (timer > wait1)

            {
                check1++;
                print("test");
                timer = 0;
                check1 = 0;
                door1 = Random.Range(1, 3);
                door2 = Random.Range(1, 3);
                door3 = Random.Range(1, 3);
                if (door1 == 2)
                {
                    Door1();
                }
                if (door2 == 2)
                {
                    Door2();
                }
                if (door3 == 2)
                {
                    Door3();
                }
            }
        }
        timer += Time.deltaTime;
    }
    

    public void Door1()
    {
        doorClosed1.SetActive(false);
        doorOpen1.SetActive(true);
    }
    public void Door2()
    {
        doorClosed2.SetActive(false);
        doorOpen2.SetActive(true);
    }
    public void Door3()
    {
        doorClosed3.SetActive(false);
        doorOpen3.SetActive(true);
    }
}