using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballController : MonoBehaviour
{
    GameObject fireball;
    // Start is called before the first frame update
    void Start()
    {
        this.fireball = GameObject.Find("MyShot_0");
    }

    // Update is called once per frame
    void Update()
    {
      

        Vector2 p1 = transform.position;
        Vector2 p2 = this.fireball.transform.position;
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 0.5f;
        float r2 = 1.0f;

        if (d < r1 + r2)
        {

            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().IncreaseHp();

            Destroy(gameObject);
        }
    }
}
