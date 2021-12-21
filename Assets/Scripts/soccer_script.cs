using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soccer_script : MonoBehaviour
{
    public Rigidbody rd;

    // Start is called before the first frame update
    void Start()
    {
        rd = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.UpArrow))
        //{

        //    GetComponent<Rigidbody>().AddForce(20, 0, 0);

        //    Debug.Log("按住Up");

        //}
        //else if (Input.GetKeyDown(KeyCode.DownArrow))
        //{
        //    GetComponent<Rigidbody>().AddForce(-20, 0, 0);
        //}
        //else if (Input.GetKeyDown(KeyCode.LeftArrow))
        //{
        //    GetComponent<Rigidbody>().AddForce(0, 0, 20);
        //}
        //else if (Input.GetKeyDown(KeyCode.RightArrow))
        //{
        //    GetComponent<Rigidbody>().AddForce(0, 0, -20);
        //}

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        rd.AddForce(new Vector3(v, 0, -h));

    }
}
