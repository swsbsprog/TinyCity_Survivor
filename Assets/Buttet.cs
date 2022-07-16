using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttet : MonoBehaviour
{
    public Vector3 speed = new Vector3(0, 0, 3);
    void Update()
    {
        transform.Translate(speed * Time.deltaTime);
    }
}
