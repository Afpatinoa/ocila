using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sin_Oscilation : MonoBehaviour
{
    float escalarX = 4, escalarY = 4;
   
    void Update()
    {
        transform.position = new Vector3(Mathf.Sin(Time.time) * escalarX, Mathf.Sin(Time.time) * escalarY, 0f);
    }
}
