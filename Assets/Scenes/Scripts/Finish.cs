using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("You have reached school");
        Destroy(other.gameObject);
        //Hier heb je speel afgespeeld(dus volgende level laden)
    }

}
