using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KupKontrol : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(15 * 0.01f, 30 * 0.01f, 45 * 0.01f);
    }
}
