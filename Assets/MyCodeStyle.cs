using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MyCodeStyle : MonoBehaviour
{
    // Constant: UpperCase Snake_Case
    private const int CONSTANT_FIELD = 56;

    // Properties: PascalCase
    private static MyCodeStyle Instance;

    // Events: PascalCase
    private event EventHandler OnSomethingHappend;

    // Fields: camelCase
    private float memberVariable;

    // Function Names: PascalCase
    private void Awake()
    {
        Instance = this;

        DoSomething(10f);
    }

    // Funtion Params: camelCase
    private void DoSomething(float time)
    {
        // Do something...
        memberVariable = time + Time.deltaTime;
        if (memberVariable > 0)
        {
            // Do something else...
        }    
    }
}
