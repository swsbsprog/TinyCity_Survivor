using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetFollow : MonoBehaviour
{
    public Vector3 offset; // Å¸°Ù°ú ¶³¾îÁø °Å¸®
    private void Start()
    {
        offset = transform.position - Player.instance.transform.position;
    }
    void LateUpdate()
    {
        transform.position = Player.instance.transform.position + offset;
    }
}
