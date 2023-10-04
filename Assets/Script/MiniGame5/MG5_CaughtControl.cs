using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG5_CaughtControl : MonoBehaviour
{
    Collider col;

    public AudioSource BGM;
    public AudioClip caught;
    public Transform receiveFish;

    bool isCaught;
    float speed = 35;

    void Start()
    {
        col = GetComponent<Collider>();
    }
    void Update()
    {
        if (isCaught == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, receiveFish.position, 30f * Time.deltaTime);
            //Destroy(gameObject, 3f);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Hook")
        {
            isCaught = true;
            //col.enabled = false;
            BGM.PlayOneShot(caught);
        }
    }
}
