using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.Windows.Speech;

public class PlayerCollision : MonoBehaviour
{
    public Rigidbody2D rb;
    public float sideMovement = 2;
    private bool isColliding;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!isColliding)
        {
            float r = Input.GetAxis("Horizontal");

            rb.velocity += new Vector2(r * sideMovement * Time.deltaTime , 0);
            Debug.Log("movement " + r * sideMovement * Time.deltaTime);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        isColliding = true;
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        isColliding = false;
    }
}
