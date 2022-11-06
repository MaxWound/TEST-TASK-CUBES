using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    private float Speed;
    private float Range;

    private float TimerTime;
    private void Start()
    {
        Speed = CubeSpawner.instance.GetSpeed();
        Range = CubeSpawner.instance.GetRange();
    }
    private void Update()
    {
        transform.position = transform.position + new Vector3(Speed * Time.deltaTime, 0f, 0f);
        if(transform.position.x >= Range)
        {
            Destroy(gameObject);
        }
        

    }
}
