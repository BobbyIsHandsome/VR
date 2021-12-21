using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed;
    public float m_speed = 5f;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float MoveX = Input.GetAxis("Horizontal");
        float MoveY = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(MoveX, 0, MoveY) *
            Time.deltaTime * speed);
        if (Input.GetButtonDown("Jump"))
        {
            Rigidbody rig = GetComponent<Rigidbody>();
            rig.AddForce(new Vector3(0, 0.5f, 0), ForceMode.Impulse);
        }
        MoveControlByTranslate();
    }
    //Translate�ƶ����ƺ���
    void MoveControlByTranslate()
    {

        if (Input.GetKey(KeyCode.W) | Input.GetKey(KeyCode.UpArrow)) //ǰ
        {

            this.transform.Translate(Vector3.forward * m_speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S) | Input.GetKey(KeyCode.DownArrow)) //��
        {

            this.transform.Translate(Vector3.forward * -m_speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A) | Input.GetKey(KeyCode.LeftArrow)) //��
        {

            this.transform.Translate(Vector3.right * -m_speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D) | Input.GetKey(KeyCode.RightArrow)) //��
        {

            this.transform.Translate(Vector3.right * m_speed * Time.deltaTime);
        }
    }

}
