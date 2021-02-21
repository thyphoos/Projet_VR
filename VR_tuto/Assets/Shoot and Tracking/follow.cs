using UnityEngine;

public class follow : MonoBehaviour
{
    public Transform target;
    public float movementSpeed = 2f;
    private Rigidbody rb;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        target = GameObject.Find("Player").transform;
    }

    private void FixedUpdate()
    {
        Vector3 position = Vector3.MoveTowards(transform.position, target.position, movementSpeed);
        rb.MovePosition(position);
        transform.LookAt(position);
    }
}
