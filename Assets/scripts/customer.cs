using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class customer
{


    public string FirstName ;
    public string lastName;
    public int age;
    public string gender; 
    public string ocupation;

    public customer(string FirstName, string lastName, int age, string gender, string ocupation)
    {
        this.FirstName = FirstName;
        this.lastName = lastName;
        this.age = age;
        this.gender = gender;
        this.ocupation = ocupation; 
    }
}

    
