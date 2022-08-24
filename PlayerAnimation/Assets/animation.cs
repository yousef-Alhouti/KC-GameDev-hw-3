using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animation : MonoBehaviour
{
    public Animator animator;
    private Rigidbody2D player;

    public Transform GroundCheck;
    public float GroundCheckRadius;
    public LayerMask GroundLayer;
    public bool isTouchingGround;


    void Start()
    {
        player = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        isTouchingGround = Physics2D.OverlapCircle(GroundCheck.position, GroundCheckRadius, GroundLayer);


        animator.SetFloat("Horizontal", Input.GetAxis("Horizontal"));

        Vector3 horizontal = new Vector3(Input.GetAxis("Horizontal"), 0.0f, 0.0f);
        transform.position = transform.position + horizontal *7 * Time.deltaTime;

        if (Input.GetButtonDown("Jump") && isTouchingGround)
        {
            player.velocity = new Vector2(player.velocity.x, 7);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GroundCheckRadius = 3;
        }
    }

}
