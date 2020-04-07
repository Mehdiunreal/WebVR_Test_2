using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateBalls : MonoBehaviour
{
    public GameObject targetBall;

    private void Start()
    {
        InvokeRepeating("InstantiateTheBall", 10, 5);
    }
    void Update()
    {
    }

    void InstantiateTheBall()
    {
        Instantiate(targetBall, this.transform.position, Quaternion.identity);
    }
}
