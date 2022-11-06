using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    public static CubeSpawner instance;
    [SerializeField]
    float Speed;
    [SerializeField]
    float Range;
    [SerializeField]
    float DelayTime;

    [SerializeField]
    GameObject CubeToSpawn;

    private float TimerTime;

    private void Awake()
    {
        if(instance != null && instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }

    }
    private void FixedUpdate()
    {
        TimerTime += Time.fixedDeltaTime;
        if(TimerTime >= DelayTime)
        {
            SpawnCube();
            TimerTime = 0;
        }
    }

    public void SetSpeed(float speed)
    {
        Speed = speed;
    }

    public void SetRange(float range)
    {
        Range = range;
    }

    public void SetTime(float time)
    {
        DelayTime = time;
    }

    public float GetSpeed()
    {
        return Speed;
    }
    public float GetRange()
    {
        return Range;
    }
    private void SpawnCube()
    {
        Instantiate(CubeToSpawn, transform.position,transform.rotation);
    }
}
