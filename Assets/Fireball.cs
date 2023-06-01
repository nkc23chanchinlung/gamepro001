using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour

{
    GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        this.enemy = GameObject.Find("EnemyPrefab");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0.1f, 0);
        if (transform.position.x > 9)
        {
            Destroy(gameObject);
        }
        //Vector2 p1 = transform.position;
        //Vector2 p2 = this.enemy.transform.position;
        //Vector2 dir = p1 - p2;
        //float d = dir.magnitude;
        //float r1 = 0.5f;
        //float r2 = 1.0f;

        //if (d < r1 + r2)
        //{

        //    GameObject director = GameObject.Find("GameDirector");
        //    director.GetComponent<GameDirector>().DecreaseHp();

        //    Destroy(gameObject);
        //}

    }
    void OnTriggerEnter2D(Collider2D c)
    {
        //Debug.Log(OnTriggerEnter);
        if (c.gameObject.name == "EnemyPrefab")
        {
            Destroy(gameObject);
        }
    }
}
