using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject _bullet;
    public float time;

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        var x = Input.GetAxis("Horizontal") * Time.deltaTime;
        var z = Input.GetAxis("Vertical") * Time.deltaTime;

        transform.position += new Vector3(x, 0f, z);

        if (time < 0f)
        {
            if (Input.GetKey(KeyCode.Mouse0))
            {
                var clonebullet = Instantiate(_bullet, transform.position, transform.rotation);
                Destroy(clonebullet, 5f);
                time = 1.5f;
            }
        }
    }
}