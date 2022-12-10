using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectabolsDetaBase : MonoBehaviour
{

    public collectabols[] collectabols;

 /*  public collectabols speedUp;
    public collectabols flyJet;
   public collectabols LongTime;*/
    void Start()
    {
        Debug.Log("yyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyy");
        Debug.Log(collectabols[2].Name);
        Debug.Log(collectabols[2].Discription);
        Debug.Log(collectabols[2].TimeEffect);

        Debug.Log("yaaaaaaaaaaa");
    }


}
