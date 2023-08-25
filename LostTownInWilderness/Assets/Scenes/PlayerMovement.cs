using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public int playerSpeed;
    // Start is called before the first frame update
    private void Update()
    {
        Movement();
    }

    public void Movement()
    {
            rb.velocity = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"))* playerSpeed * Time.deltaTime;
    }
}
