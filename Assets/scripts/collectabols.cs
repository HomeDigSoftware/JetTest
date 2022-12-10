using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class collectabols
{
    public string Name;
    public int ID;
    public string Discription;
    public float TimeEffect;

    public collectabols()
    {

    }
    public collectabols(string Name, int ID, string Discription, float TimeEffect)
    {
        this.Name = Name;
        this.TimeEffect = TimeEffect;
        this.Discription = Discription;
        this.ID = ID;   
    }


}
   
