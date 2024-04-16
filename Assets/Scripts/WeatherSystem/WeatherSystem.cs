using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeatherSystem : MonoBehaviour
{
    public GameObject[] weathers;
    private float time;
    private int number;

    void Start()
    {
        number = Random.Range(0, 4);
        if (number == 0)
        {
            Instantiate(weathers[0], new Vector3(0, 10, 0), Quaternion.identity); //rain
        }
        if (number == 1)
        {
            Instantiate(weathers[1], new Vector3(0, 30, 0), Quaternion.identity); //snow
        }
        if (number == 2)
        {
            Instantiate(weathers[2], new Vector3(0, 90, 0), Quaternion.identity); //thunder
        }
        if (number == 3) 
        {
            Instantiate(weathers[3], new Vector3(0, 50, 0), Quaternion.identity); //sunny
        }
    }

    void Update()
    {
      
    }
}
