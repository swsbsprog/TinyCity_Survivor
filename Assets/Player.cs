using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Player : MonoBehaviour
{
    static public Player instance;
    private void Awake() => instance = this;

    public Transform clickPointer;

    public NavMeshAgent agent;
    public Animator animator;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
    }

    public GameObject bullet;
    public Vector3 bulletOffset = new Vector3(0, 1, 0);
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //if (Physics.Raycast(ray, out RaycastHit hitInfo))
            //{
            //    clickPointer.position = hitInfo.point;
            //    agent.destination = hitInfo.point;
            //}
            Fire(); // 
        }

        velocity = agent.velocity.magnitude;
        animator.SetFloat("Speed", agent.velocity.magnitude);
    }

    private void Fire()
    {
        var bulletPos = transform.position
            + transform.up * bulletOffset.y
            + transform.right * bulletOffset.x
            + transform.forward * bulletOffset.z;
        var newBullet = Instantiate(bullet, bulletPos, transform.rotation);
    }

    public float velocity;
}

