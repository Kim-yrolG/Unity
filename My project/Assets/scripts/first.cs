using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class first: MonoBehaviour
{
    // Start is called before the first frame update
    public int count = 0;
    private float value = 2.0f;
    void Start()
    {
        Debug.Log("첫프레임에서");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(count);
        count++;
    }
}

