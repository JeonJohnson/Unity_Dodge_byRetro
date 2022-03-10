using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float rotateTime = 10f;

    [HideInInspector]
    public float groundSpd = 0f;
    public float afterRotateTime = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        afterRotateTime += Time.deltaTime;
       
        if (afterRotateTime >= rotateTime)
        {
            afterRotateTime = 0f;
            groundSpd = Random.Range(-10f, 10f);
        }

        transform.Rotate(0f, groundSpd * Time.deltaTime, 0f);

        Debug.Log(afterRotateTime);
    }
}
