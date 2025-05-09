using UnityEngine;


public class RandomMovement2 : MonoBehaviour
{
    public Transform[] patrolPoints;
    public int targetPoint;
    public float speed;

    void Start()
    {
        targetPoint = 0;
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, patrolPoints[0].position, speed * Time.deltaTime);
    }
}
