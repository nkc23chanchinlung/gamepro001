using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using TMPro;
using static System.Net.Mime.MediaTypeNames;


public class KM : MonoBehaviour
{
    float timer;
    GameObject km;
    // Start is called before the first frame update
    void Start()
    {
        timer = 0f;
        this.km = GameObject.Find("KM");
    }

    // Update is called once per frame
    void Update()
    {
        
       
        timer += Time.time;
        this.km.GetComponent<TextMeshProUGUI>().text = timer.ToString("F2") + "km";
    }
}
