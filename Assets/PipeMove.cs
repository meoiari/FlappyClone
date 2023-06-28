using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMove : MonoBehaviour
{
    public float PipeSpeed = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * PipeSpeed * Time.deltaTime;

        //if(transform.position.x < -4.8)
        //{
        //    transform.position = Vector3.zero;
        //    transform.position += Vector3.right * 5;
        //    transform.position += Vector3.up * 1.5f;
        //}
    }
}
