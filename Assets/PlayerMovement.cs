using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D _compRigidbody2D;
    private SpriteRenderer _compSpriteRenderer;
    public int speed;
    public int xDirection;
    public int yDirection;
    // Start is called before the first frame update
    void Awake()
    {
        _compRigidbody2D = GetComponent<Rigidbody2D>();
        _compSpriteRenderer = GetComponent<SpriteRenderer>();
    }
    void Start()
    {
        speed = 5;
        xDirection = 1;
        yDirection = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        _compRigidbody2D.velocity = new Vector2(speed * xDirection, speed * yDirection);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Horizontal")
        {
            xDirection = xDirection * -1;
            if (_compSpriteRenderer.flipX == true)
            {
                _compSpriteRenderer.flipX = false;
            }
            else
            {
                _compSpriteRenderer.flipX = true;
            }
        }
        if (collision.gameObject.tag == "Vertical")
        {
            yDirection = yDirection * -1;
            if (_compSpriteRenderer.flipY == true)
            {
                _compSpriteRenderer.flipY = false;
            }
            else
            {
                _compSpriteRenderer.flipY = true;
            }
        }
    }
}
