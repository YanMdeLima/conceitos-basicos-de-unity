using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalk : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public float turnSpeed;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        var vertical = Input.GetAxis("Vertical");
        var horizontal = Input.GetAxis("Horizontal");

        var turn = Input.GetAxis("Mouse X");
     

        transform.position += transform.forward * vertical * speed * Time.deltaTime;
        transform.position += transform.right * horizontal * speed * Time.deltaTime;

        transform.Rotate(new Vector3(0, turn * turnSpeed * Time.deltaTime, 0));
    }
}
