using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballGenerator : MonoBehaviour
{
    public GameObject FireballPrefab;
    GameObject charator;
    // Start is called before the first frame update
    void Start()
    {
        this.charator = GameObject.Find("player");
         
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 x = charator.transform.position;
        if (Input.GetKeyDown(KeyCode.J))
        {
            GameObject go = Instantiate(FireballPrefab);
            go.transform.position = x;
        }
    }
}
