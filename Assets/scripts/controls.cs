using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class controls : MonoBehaviour
{
    public GameObject player1;
    public GameObject player2;
    public float speed = 1f;
    public Text tcounter;
    float startime;
    // Start is called before the first frame update
    void Start()
    {
        startime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = player2.transform.position;
        if (Input.GetKey(KeyCode.A))
        {
            pos.x -= speed *Time.deltaTime;
            
        }
        if (Input.GetKey(KeyCode.W))
        {
            pos.y += speed * Time.deltaTime;

        }
        if (Input.GetKey(KeyCode.D))
        {
            pos.x += speed * Time.deltaTime;

        }
        if (Input.GetKey(KeyCode.S))
        {
            pos.x -= speed * Time.deltaTime;
        }

        float currentime = Time.time - startime;
        if ( currentime > 50f)
        {
            tcounter.text = "end";
        }
        else
        {
            currentime = 50 - currentime;
            tcounter.text = (currentime).ToString();
        }


        Vector3 pos2 = player1.transform.position;
        if (Input.GetKey(KeyCode.J))
        {
            pos2.x -= speed * Time.deltaTime;

        }
        if (Input.GetKey(KeyCode.I))
        {
            pos2.y += speed * Time.deltaTime;

        }
        if (Input.GetKey(KeyCode.L))
        {
            pos2.x += speed * Time.deltaTime;

        }
        if (Input.GetKey(KeyCode.K))
        {
            pos2.x -= speed * Time.deltaTime;

        }

        player1.transform.position = pos2;
        
        player2.transform.position = pos;

    }
}
