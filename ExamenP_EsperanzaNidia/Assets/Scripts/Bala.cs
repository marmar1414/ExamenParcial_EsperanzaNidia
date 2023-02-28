using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    [SerializeField] private float mindisY;
    [SerializeField] private float maxdistX;
    public float speed = 20;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (KeyCode(GetKey.Space))
        {
            rb.velocity = transform.forward * speed;
            rb.AddForce(mindisY * speed, 0.0f, maxdistX * speed);
        }
    }
}
