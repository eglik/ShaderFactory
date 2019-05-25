using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionEdgeDissolve : MonoBehaviour
{
    [SerializeField]
    private float minValue;
    
    [SerializeField]
    private float maxValue;

    private float value;

    [SerializeField]
    private float timer;

    [SerializeField]
    private float speed;

    void Update()
    {
        timer += Time.deltaTime * speed;

        GetComponent<Renderer>().material.SetFloat("_Value", Mathf.Lerp(minValue, maxValue, Mathf.Repeat(timer, 1)));
        Debug.Log(GetComponent<Renderer>().material.GetFloat("_Value"));
    }
}