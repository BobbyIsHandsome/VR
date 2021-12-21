using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stopball : MonoBehaviour
{
    public GameObject GO;
    public GameObject ball2;
    public float dist = 0;
    public Transform target;
    public Rigidbody rb;
    public float forward; //150000
    public float up;//2000
    public int score;
    public float timer = 5.0f;
    public bool shot = false;
    public int num;
    public int difficulty;
    public void shoot()
    {
        if (this.shot == false)
        {
            this.rb = GetComponent<Rigidbody>();
            this.rb.AddForce((this.target.transform.position - this.transform.position).normalized * 300);
            this.shot = true;
        }
    }
    // Use this for initialization
    void Start()
    {
        dist = Vector3.Distance(target.position, transform.position);
        this.rb = GetComponent<Rigidbody>();
        if (this.num == 1)
        {
            this.rb.AddForce((this.target.transform.position - this.transform.position).normalized * 300);
            this.shot = true;
        }
        score += 10;
        GO.SendMessage("UpdateScore", score);
    }

    // Update is called once per frame
    void Update()
    {
        if (shot == true)
        {

            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                this.timer = 3.0f;
                ball2.SendMessage("shoot");
            }

        }
    }
}
