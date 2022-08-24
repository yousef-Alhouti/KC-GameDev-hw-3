using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;

    public Transform GroundCheck;
    public LayerMask groundlayer;
    public float rad;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Patrol();
    }

    void Patrol()
    {
        rb.velocity = new Vector2(1f * speed, 0f);

        bool isGrounded = Physics2D.OverlapCircle(GroundCheck.position, rad, groundlayer);

        if (!isGrounded)
        {
            transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
            speed = -speed;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(gameObject.tag == "Bullet")
        {
            Destroy(gameObject);
        }
        else if (gameObject.tag == "Bullet")
        {
            SceneManager.LoadScene(0);
        }

    }

}
