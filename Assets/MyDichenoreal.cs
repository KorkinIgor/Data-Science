using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyDichenoreal : MonoBehaviour
{

    private Dictionary<string, string> a=new Dictionary<string, string>();


    private void Start()
    {
        a.Add("one","honda");
        a.Add("two","touta");
        a.Add("three","mercedes");
        print(a["one"]);
    }
}
