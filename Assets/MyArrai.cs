using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MyArrai : MonoBehaviour
{
    public int[] f = new int[] {1, 3, 5};//Создать и заполнить массив
    public int a;
    int max=0;

    void Start()
    {


        for (int i = 0; i < f.Length; i++)
        {
            if (f[i] > 0) max = f[i];


        }

        print(max);

    }
}
