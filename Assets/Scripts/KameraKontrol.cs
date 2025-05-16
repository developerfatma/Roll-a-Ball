using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KameraKontrol : MonoBehaviour
{
    public GameObject top;
    public Vector3 aradakiFark;
    void Start()
    {
        aradakiFark = transform.position - top.transform.position;  
    }

    
    void LateUpdate()
    {
        transform.position = top.transform.position + aradakiFark;
    }
}
