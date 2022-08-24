using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Power : MonoBehaviour
{
    public Transform GroundCheck;
    public float GroundCheckRadius;
    public LayerMask GroundLayer;
    public bool isTouchingGround;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        isTouchingGround = Physics2D.OverlapCircle(GroundCheck.position, GroundCheckRadius, GroundLayer);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "PowerUp")
        {
            Destroy(gameObject);
        }
    }
}
