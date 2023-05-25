using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using TMPro;
using static System.Net.Mime.MediaTypeNames;


public class KM : MonoBehaviour
{
    GameObject km;
    // Start is called before the first frame update
    void Start()
    {
        this.km = GameObject.Find("KM");
    }

    // Update is called once per frame
    void Update()
    {
        float timer = 0f;
        timer += Time.time*100;
        this.km.GetComponent<TextMeshProUGUI>().text = timer.ToString("F2") + "km";
    }
}
