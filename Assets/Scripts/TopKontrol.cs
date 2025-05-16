using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TopKontrol : MonoBehaviour
{
    public Rigidbody fizik;
    public int hiz;
    public int sayac;
    public int objeSayisi;
    public Text PuanText;
    public Text OyunBittiText;


    void Start()
    {
        fizik=GetComponent<Rigidbody>();      
    }

    
    void FixedUpdate()
    {
        float yatay = Input.GetAxis("Horizontal");
        float dikey = Input.GetAxis("Vertical");
        Vector3 vektor = new Vector3(yatay, 0, dikey);
        fizik.AddForce(vektor*hiz); 
    }

    void OnTriggerEnter(Collider other)
    {
       other.gameObject.SetActive(false);
       sayac ++;
        PuanText.text = "Puan : " + sayac;
        if(sayac == objeSayisi)
        {
            OyunBittiText.gameObject.SetActive(true);
        }
       
    }

}
