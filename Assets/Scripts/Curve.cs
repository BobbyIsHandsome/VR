using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Curve : MonoBehaviour
{


    public float Power = 10;//���������ʱ���ٶ�/���ȵȣ�����ͨ������ģ�ⲻͬ������С
    public float Angle = 45;//����ĽǶȣ�����Ͳ��ý����˰�
    public float Gravity = -10;//��������������ٶ�
    public bool IsOne = false;


    private Vector3 MoveSpeed;//���ٶ�����
    private Vector3 GritySpeed = Vector3.zero;//�������ٶ�������tʱΪ0
    private float dTime;//�Ѿ���ȥ��ʱ��

    private Vector3 currentAngle;
    // Use this for initialization
    void Start()
    {
        //ͨ��һ����ʽ��������ٶ�����
        //�Ƕ�*����
        MoveSpeed = Quaternion.Euler(new Vector3(0, 0, Angle)) * Vector3.right * Power;
        currentAngle = Vector3.zero;
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        //��������������ٶ�
        //v = at ;
        GritySpeed.y = Gravity * (dTime += Time.fixedDeltaTime);
        //λ��ģ��켣
        transform.position += (MoveSpeed + GritySpeed) * Time.fixedDeltaTime;
        currentAngle.z = Mathf.Atan((MoveSpeed.y + GritySpeed.y) / MoveSpeed.x) * Mathf.Rad2Deg;
        transform.eulerAngles = currentAngle;


    }

   
}
