using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int speed;
    public int dashSpeed;
    private int currentSpeed;
    private Vector2 movement;
    public Rigidbody2D rb;
    private const float dashTime = 0.25f;
    private const float dashCooldown = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        currentSpeed = speed;
    }

    private void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        if (Input.GetKeyDown(KeyCode.Space))
        {
            DashProcess();
        }

    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement.normalized * currentSpeed * Time.deltaTime);
    }

    private void DashProcess()
    {
        
    }

    private IEnumerator stopDash()
    {
        yield return new WaitForSeconds(dashTime);

    }
}
