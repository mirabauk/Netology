using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;
using static UnityEngine.GraphicsBuffer;
using static UnityEngine.InputSystem.InputAction;
using UnityEngine.SceneManagement;
using UnityEditor;
using Newtonsoft.Json.Linq;

public class PlayerMover : MonoBehaviour
{
    public FoxMove controls;
    public InputAction Test;
    public InputAction Jump1;
    public float timehit;
    public float bump;
    public float timer;
    public float stop = 0f;
    public bool Wall = false;
    public float PlayerPosition;
    public float timecoin;
    public float timejump;
    public float SpeedMove = 4f;
    public float SpeedRun = 4f;
    public float lifes = 3;
    public float bang = 0;

    void Awake()
    {
        controls = new FoxMove();
        Jump1 = new InputAction();
    }

    private void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.centerOfMass = Vector3.zero;
        rb.inertiaTensorRotation = Quaternion.identity;
    }

    private void OnEnable()
    {
        controls.FoxMoveMap.Enable();
        controls.FoxMoveMap.FoxJump.performed += Jump;
    }
    public void Jump(CallbackContext context)
    {
        if (timejump >= 0f) return;
        GetComponent<Rigidbody>().AddForce(new Vector3(0, 7, 0), ForceMode.Impulse);
        timejump = 1f;
    }

    void Update()
    {
        timehit -= Time.deltaTime;
        timecoin -= Time.deltaTime;
        bump -= Time.deltaTime;
        timejump -= Time.deltaTime;
        var value = controls.FoxMoveMap.FoxMove.ReadValue<Vector2>();
        transform.position += transform.TransformDirection(new Vector3(value.x, 0, value.y)) * Time.deltaTime * SpeedMove;
        transform.position += transform.forward * SpeedRun * Time.deltaTime;
        PlayerPosition = (transform.position.z +9)/10;
        ScoreValue.Dyst = (float)Math.Round(PlayerPosition);

        if (Wall == true)
            stop += Time.deltaTime;

        if (stop >= 3f)
        {
            SceneManager.LoadScene("LoseScreen");
            Debug.Log("Stuck");
        }

        if (SpeedRun < 15f)
            SpeedRun += 0.1f * Time.deltaTime;

        if (lifes <= 0f)
        {
            Debug.Log("Game Over");
            SceneManager.LoadScene("LoseScreen");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Fire")
        {
            if (SpeedRun > 1f)
                SpeedRun -= 0.1f * Time.deltaTime;
            TakeDamage();
            timehit = 2f;
        }
        if (other.gameObject.tag == "Coin")
        {
            CoinPoints();
            Destroy(other.gameObject);
        }
    }

    private void OnCollisionEnter(Collision collider)
    {
        if (collider.gameObject.tag == "Obstacle")
        {
            if (SpeedRun > 1f)
                SpeedRun -= 0.1f * Time.deltaTime;
            CollideWithObstacle();
        }
        if (collider.gameObject.tag == "Chunk")
        {
            if (SpeedRun > 1f)
                SpeedRun -= 0.1f * Time.deltaTime;
            Debug.Log("Stuck");
            CollideWithChunk();
        }
        if (collider.gameObject.tag == "Lava")
        {
            Debug.Log("Lava");
            SceneManager.LoadScene("LoseScreen");
        }
    }

    private void CollideWithObstacle()
    {
        if (bump < 0)
        {
            Debug.Log("Obstacle");
            bump = 1f;
        }
    }

    private void CollideWithChunk()
    {
        Debug.Log("Timer");
        SpeedRun = 4f;
        SpeedRun += 0.1f * Time.deltaTime;
        stop = 0f;
        Wall = true;
    }

    private void OnCollisionExit(Collision collider)
    {
        if (collider.gameObject.tag == "Chunk")
        {
            Debug.Log("OffStuck");
            Wall = false;
        }
    }

    private void TakeDamage()
    {
        if (timehit < 0)
        {
            Debug.Log("Damage");
            lifes = lifes - 1f;
            timehit = 1f;
            LifesValue.LifesVal -= 1;
        }
    }

    private void CoinPoints()
    {
        if (timecoin < 0)
        {
            Debug.Log("Coin");
            ScoreValue.ScoreVal += 5;
            timecoin = 0.4f;
        }
    }

    private void OnDisable()
    {
        controls.FoxMoveMap.Disable();
    }
}
