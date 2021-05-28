using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollow : MonoBehaviour
{

    [SerializeField]
    private Transform target;
    [SerializeField]
    private float speed = 0.125f;
    [SerializeField]
    private Vector3 offset;
    void LateUpdate()
    {
        Vector3 d_position = target.position + offset;
        Vector3 s_position = Vector3.Lerp(transform.position, d_position, speed);

        transform.position = s_position;

    }

    //[SerializeField]
    //private Transform target;
    //[SerializeField]
    //private Vector3 offset;

    //void LateUpdate()
    //{
    //    transform.position = target.position + offset;
    //}



}