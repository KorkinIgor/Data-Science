using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyHash : MonoBehaviour
{
  public HashSet<int> a=new HashSet<int>();


   private void Start()
   {
       a.Add(2);
       a.Add(2);
      a.Add(5);
      print(a);
      
   }
}
