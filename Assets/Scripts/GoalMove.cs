using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalMove : MonoBehaviour
{
    public int time = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time++;
        if (time == 360)
        {
            time = 0;
        }
        if (time < 180)
        {
            transform.Translate(Vector3.left * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector3.right * Time.deltaTime);
        }
    }
}
