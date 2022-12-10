using System.Collections;
using System.Collections.Generic;
using UnityEditor.Profiling.Memory.Experimental;
using UnityEngine;

public class customerdatabase : MonoBehaviour
{
    public customer[] add_customers;
    public customer cus1;
    public customer cus2;
    public customer cus3;
    

    void Start()
    {

        cus1 = new customer("tzaf", "havia", 35, "man", "indy game dev");
        cus2 = new customer("natnat", "havia", 35, "woman", "indy 3d artict");
        cus3 = new customer("yahav", "havia", 5, "woman", "game tasting"); 


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
