using UnityEngine;
using System;

public class FollowScript : MonoBehaviour
{
    public Transform targetObj;
    private Transform self;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        self = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        self.transform.position = Vector3.MoveTowards (self.position, targetObj.position, 4* Time.deltaTime);
    }
}
