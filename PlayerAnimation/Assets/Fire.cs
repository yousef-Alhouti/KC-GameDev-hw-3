using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    SpriteRenderer sprite;
    public bool facingright = true;

    public GameObject bullet;
    GameObject BulletClone;
    public int speed;

    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Bullet();
    }
    void FlipPlayer()
    {
        if (Input.GetKeyDown(KeyCode.A) && facingright == true)
        {

            facingright = true;

        }
        else if (Input.GetKeyDown(KeyCode.A) && facingright == true)
        {

            facingright = false;

        }
    }

    void Bullet()
    {
        BulletClone = Instantiate(bullet, transform.position, transform.rotation);
        BulletClone.GetComponent<Rigidbody2D>().velocity = transform.right * speed;
        Destroy(BulletClone, 1.5f);
    }
}
