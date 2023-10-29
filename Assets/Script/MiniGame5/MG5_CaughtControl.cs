using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG5_CaughtControl : MonoBehaviour
{
    public AudioSource BGM;
    public AudioClip caught;
    public Transform receiveFish;

    bool isCaught;
    float speed = 30f;

    void Update()
    {
        if (isCaught == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, receiveFish.position, speed * Time.deltaTime);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Hook")
        {
            isCaught = true;
            BGM.PlayOneShot(caught);
        }
    }
}
