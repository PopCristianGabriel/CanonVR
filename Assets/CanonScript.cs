using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CanonScript : MonoBehaviour
{
    [SerializeField] GameObject canonball;
    float ROF = 0.2f;
    float fireDelay;
    float speed = 75.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButton("Fire1") && Time.time > fireDelay)
        {
            fireDelay = Time.time + ROF;
            GameObject clone = Instantiate(canonball, transform.position, transform.rotation);
            clone.GetComponent<Rigidbody>().velocity = transform.TransformDirection(new Vector3(0, 0, speed));

        }
    }
}
