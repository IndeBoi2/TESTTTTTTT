using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnGreen : MonoBehaviour
{
    void Start()
    {
        GetComponent<Renderer>().material.color = Color.green;
    }
}