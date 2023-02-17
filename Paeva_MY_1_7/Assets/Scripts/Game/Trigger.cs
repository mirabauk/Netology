using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public Transform Player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(x : Player.transform.position.x, y : Player.transform.position.y, z : Player.transform.position.z - 25);
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.transform.position.z > 15)
        {
            //Debug.Log($"Collided with {other.gameObject.name} on Z {other.gameObject.transform.position.z}");
            Destroy(other.gameObject);
        }
    }
}
