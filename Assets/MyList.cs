using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyList : MonoBehaviour
{
    private List<int> a=new List<int>();
    private int test;
    void Start()
    {
        a.Add(4);
        a.Add(2);
        a.Add(3);
        a.Add(1);
       a.Add(4);
        a.Remove(4);
        
        Upgg();
    }
    

    void Upgg()
    {
        for (var i = 0; i < a.Count; i++)
        {
            print(a[i]);

        }
    }
}
