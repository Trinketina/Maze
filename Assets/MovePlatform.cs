using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MovePlatform : MonoBehaviour
{
    public float speed;
    public int startingPoint;
    public float rayDistance = 2;

    public Transform[] points;
    private int i;
    public Rigidbody2D rb;
    private bool isBlocked_ = false;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = points[startingPoint].position;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        /*
        Vector2 direction = (points[i].transform.position - transform.position);
        RaycastHit2D hit = Physics2D.Raycast(transform.position, direction, 4f);
        Debug.DrawRay(transform.position, direction, Color.red);

        // Check if the raycast hit an obstacle
        if (hit.collider != null)
        {
            {
                if (hit.collider.CompareTag("Falling"))
                {
                    Debug.Log("COLLIDED");
                    isBlocked_ = true;
                }
                else
                {
                    isBlocked_ = false;
                }
            }
        }
        else isBlocked_ = false;
        */
        if (!isBlocked_)
        {
            if (Vector2.Distance(transform.position, points[i].position) < 0.02f)
            {
                i++;
                if (i == points.Length)
                {
                    i = 0;
                }
            }
            transform.position = Vector2.MoveTowards(transform.position, points[i].position, speed * Time.deltaTime);
        }
    }
    private void FixedUpdate()
    {
      
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Falling"))
        {
            isBlocked_ = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Falling"))
        {
            isBlocked_ = false;
        }
    }
}