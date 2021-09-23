using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeekOnechallenges : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Introduction("DJ Fisher",18,30,01,2003,75.34f,false,5);
    }

    public void Introduction(string name, int age, int day, int month, int year, float height, bool wearingWatch, int favNumber)
    {
        string clause;
        if(wearingWatch == true)
        {
            clause = " I am wearing a watch.";  
        }
        else
        {
            clause = " I am not wearing a watch.";
        }
        
        Debug.Log("Hi, my name is " + name + ". my age in years is " + age +
        ", that means my date of birth is " + day + "/" + month + "/" + year + ". I am " + height + 
        "cm tall and the rumours you have heard are " + wearingWatch + "," + clause + 
        " Finally my favorite number is " + favNumber + ", which if added my age to it would give me a number of " + (age + favNumber) + ".");
    }
}
