using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetFollow : MonoBehaviour
{
    public Vector3 offset; // Ÿ�ٰ� ������ �Ÿ�
    private void Start()
    {
        offset = transform.position - Player.instance.transform.position;
    }
    void LateUpdate()
    {
        transform.position = Player.instance.transform.position + offset;
    }
}
