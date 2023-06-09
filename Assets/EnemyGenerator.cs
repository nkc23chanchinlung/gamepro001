using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject EnemyPrefab;
    float span = 0.07f;
    float delta = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        if(this.delta > this.span) 
        {
            this.delta = 0;
            GameObject go=Instantiate(EnemyPrefab);
            int px = Random.Range(-6, 7);
            go.transform.position = new Vector3(10, px, 0);
        }
    }
}
