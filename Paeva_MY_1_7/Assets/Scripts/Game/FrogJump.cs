using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.InputSystem.InputAction;

public class FrogJump : Obstacle
{
    public float timejump;

    void Start()
    {
        //Debug.Log("Frog is alive");
    }

    void Update()
    {
        Jump();
        timejump -= Time.deltaTime;
    }

    public void OnCollisionEnter(Collision collider)
    {
        if (collider.gameObject.CompareTag("Lava"))
        {
            Destroy(this.gameObject);
            //Debug.Log("Frog is destroyed");
        }
    }
    public void Jump()
    {
        if (timejump >= 0f ) return;

        GetComponent<Rigidbody>().AddForce(new Vector3(0, 5, 0), ForceMode.Impulse);
        timejump = 2f;
    }
}