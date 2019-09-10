using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoregoal : MonoBehaviour
{
    public GameObject ball;
    public GameObject player1st;
    public GameObject player2nd;
    public Text scoredisplay;
    public int playerscore = 0;
    Vector3 player1;
    Vector3 player2;
    Vector3 ballvec;
    // Start is called before the first frame update
    void Start()
    {
        player1 = player1st.transform.position;
        player2 = player2nd.transform.position;
        ballvec = ball.transform.position;

    }

    // Update is called once per frame
    void Update()
    { }
    void OnTriggerEnter(Collider impactobject)
    {
        if(impactobject.gameObject == ball)
        {
            ++playerscore;
            scoredisplay.text = playerscore.ToString();
            
            
            ball.transform.position = ballvec;
            player1st.transform.position = player1;
            player2nd.transform.position = player2;

        }
    }
}
    
