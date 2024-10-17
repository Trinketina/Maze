using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
    public GameObject dis;
    public Sprite sprite;
    public SpriteRenderer spriteRend;
    public bool isActive;
    public bool isPressed = false;
    // Start is called before the first frame update
    void Start()
    {
        isActive = dis.activeSelf;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && !isPressed)
        {
            dis.SetActive(!isActive);
            isPressed = true;
            spriteRend.sprite = sprite;
        }
    }
}
