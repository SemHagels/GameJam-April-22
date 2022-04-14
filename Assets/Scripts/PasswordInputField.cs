using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PasswordInputField : MonoBehaviour
{

    public InputField inputfield;
    public Text Hint;

   int number = 0;  
   int Int;
    public void Start()
    {
        number = Random.Range(0, 10);
        Debug.Log(number);
    }

    public void CheckInput()
    {
        int.TryParse(inputfield.text, out Int);

        if (Int <= number)
        {
            // Debug.Log("Guess higher");
            Hint.text = "Guess higher";
        }
        else if (Int >= number)
        {
            //Debug.Log("Guess Lower");
            Hint.text = "Guess Lower";
        }

        if (inputfield.text == number.ToString())     // check inputfield contains the string password
        {
           //Debug.Log("Password accepted");     // just a debug.Log to show that the password is correct (can be removed)
            Hint.text = "Password accepted, GG";
            SceneManager.LoadScene("SampleScene");  // fill in the name of the scene you want to load
        }
        else
        {
            //Debug.Log("Wrong Password, Please try again");
          //  Hint.text = "Wrong Password, Please try again";
        }

        
    }
}