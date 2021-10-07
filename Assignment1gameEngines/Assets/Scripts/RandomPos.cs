using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPos : MonoBehaviour
{
    [SerializeField] float minRange;

    [SerializeField] float maxRange;

    [SerializeField] float vector3Y;

    // Update is called once per frame
    void Update()
    {
       if (Input.GetMouseButtonDown(0))
        {
            RandomPositions();
        }
    }
     void RandomPositions()
    {
        transform.position = new Vector3(Random.Range(-minRange, maxRange), vector3Y
            , Random.Range(-minRange, maxRange));

    }
}
