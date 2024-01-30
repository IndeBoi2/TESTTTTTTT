using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enter : MonoBehaviour
{
    public GameObject Bridge;
    private void OnTriggerEnter()
    {
        Bridge.SetActive(true);
    }
}
