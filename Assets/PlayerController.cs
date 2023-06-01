using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Animator anime;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        anime = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    { 



        float x =Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        float speed = 0.1f;
        transform.position+= new Vector3(x*speed,y*speed,0);


        if (y == 0)
        {
            anime.Play("Player");
        }
        else if (y == -1)
        {
            anime.Play("playr");
        }
        else 
        {
            anime.Play("playl");
        }
    }
}
