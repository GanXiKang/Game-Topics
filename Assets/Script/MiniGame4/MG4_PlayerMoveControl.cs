using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG4_PlayerMoveControl : MonoBehaviour
{
    Rigidbody rb;

    public float speed = 5;
    public float jump = 10;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        Vector3 vSpeed = new Vector3(this.transform.forward.x, this.transform.forward.y, this.transform.position.z) * speed;
        Vector3 jumpSpeed = new Vector3(this.transform.up.x, this.transform.position.y, this.transform.position.z) * jump;
        this.transform.position += (vSpeed + jumpSpeed) * Time.deltaTime;
        
        //transform.Translate(0, 0, speed * Time.deltaTime);
        //if (Input.GetKeyDown("w"))
        //{
        //    rb.velocity = Vector3.up * jump;
        //}
    }
}
