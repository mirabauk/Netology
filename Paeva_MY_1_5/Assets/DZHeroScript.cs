using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;
using static UnityEngine.InputSystem.InputAction;

public class DZHeroScript : MonoBehaviour
//HeroActions
{
    public DZHeroInput controls;
    public InputAction Test;
    public InputAction Jump1;
    public GameObject smallbullet;
    public float time;
    public float timejump;
    public float SpeedRotate = 45f;
    public float SpeedMove = 2f;

    // Start is called before the first frame update
    void Awake()
    {
        controls = new DZHeroInput();
        Jump1 = new InputAction();
    }

    private void OnEnable()
    {
        controls.DZHeroControls.Enable();
        controls.DZHeroControls.HeroAttack.started += Attack;
        controls.DZHeroControls.HeroJump.performed += Jump;
        controls.DZHeroControls.Fbutton.performed += Fbut;
        controls.DZHeroControls.Ctrlbutton.performed += Ctrl;
    }

    private void Ctrl(CallbackContext obj)
    {
        Debug.Log("Control event");
    }

    private void Fbut(CallbackContext obj)
    {
        Debug.Log("F button event");
    }

    public void Jump(CallbackContext context)
    {
        if (timejump >= 0f) return; 
        GetComponent<Rigidbody>().AddForce(new Vector3(0, 5, 0), ForceMode.Impulse);
        timejump = 1f;
    }

    public void Attack(CallbackContext context)
    {
        if (time >= 0f) return;
        var clonebullet = Instantiate(smallbullet, transform.position, transform.rotation);
        time = 0.3f;
        Destroy(clonebullet, 5f);

        Debug.Log("Attack");
    }

        // Update is called once per frame
        void Update()
    {
        time -= Time.deltaTime;
        timejump -= Time.deltaTime;
        var value = controls.DZHeroControls.HeroMovement.ReadValue<Vector2>();
        transform.position += transform.TransformDirection(new Vector3(value.x, 0, value.y)) * Time.deltaTime * SpeedMove;
        var rot = controls.DZHeroControls.HeroRotate.ReadValue<float>();
        transform.Rotate(Vector3.up * rot * Time.deltaTime * SpeedRotate);
        //transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, rot * Speed, 0), Time.deltaTime);
    }

    private void OnDisable()
    {
        controls.DZHeroControls.HeroAttack.canceled -= Attack;
        controls.DZHeroControls.Disable();
    }
}




