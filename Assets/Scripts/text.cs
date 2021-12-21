using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class text : MonoBehaviour
{

    public GameObject GO;
    public int score;

    public float timer = 2.0f;
    public void UpdateScore(int score)

    {
        this.score += score;


    }
    // Use this for initialization
    void Start() { }

    // Update is called once per frame
    void Update()
    {
        if (Time.frameCount % 20 == 0)
        {
            System.Random number = new System.Random();
            int a = number.Next(1, 10); //(生成1~10之间的随机数，不包括10)
            int b = number.Next(1, 10);
            string text =  this.score.ToString();
            GO.GetComponent<TextMesh>().text = text;
        }
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            this.score -= 1;
            this.timer = 2.0f;
        }
    }
}
