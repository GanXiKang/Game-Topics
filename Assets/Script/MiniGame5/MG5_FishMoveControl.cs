using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG5_FishMoveControl : MonoBehaviour
{
    float timer;
    int r;

     void Start()
    {
        r = Random.Range(1, 2);
    }
    void FixedUpdate()
    {
        timer += Time.deltaTime;

        switch (r)
        {
            case 1:
                MoveModel1();
                break;
            case 2:
                MoveModel2();
                break;
            case 3:
                MoveModel3();
                break;
        }
    }
    void MoveModel1()
    {
        if (timer < 4f)
        {
            transform.position = new Vector3(transform.position.x + 1.2f * Time.deltaTime, transform.position.y, transform.position.z);

            Quaternion targetR = Quaternion.Euler(0, 0, 0);
            transform.rotation = Quaternion.Lerp(transform.rotation, targetR, 0.8f);
        }
        if (timer > 4f && timer < 8f)
        {
            transform.position = new Vector3(transform.position.x - 1.2f * Time.deltaTime, transform.position.y, transform.position.z);

            Quaternion targetR = Quaternion.Euler(0, 180, 0);
            transform.rotation = Quaternion.Lerp(transform.rotation, targetR, 0.8f);
        }
        if (timer > 8f)
        {
            timer = 0;
        }
    }
    void MoveModel2()
    {
        if (timer < 6f)
        {
            transform.position = new Vector3(transform.position.x - 0.8f * Time.deltaTime, transform.position.y, transform.position.z);

            Quaternion targetR = Quaternion.Euler(0, 180, 0);
            transform.rotation = Quaternion.Lerp(transform.rotation, targetR, 0.9f);
        }
        if (timer > 6f && timer < 12f)
        {
            transform.position = new Vector3(transform.position.x + 0.8f * Time.deltaTime, transform.position.y, transform.position.z);

            Quaternion targetR = Quaternion.Euler(0, 0, 0);
            transform.rotation = Quaternion.Lerp(transform.rotation, targetR, 0.9f);
        }
        if (timer > 12f)
        {
            timer = 0;
        }
    }
    void MoveModel3()
    {
        if (timer < 5f)
        {
            transform.position = new Vector3(transform.position.x + 1f * Time.deltaTime, transform.position.y, transform.position.z);

            Quaternion targetR = Quaternion.Euler(0, 0, 0);
            transform.rotation = Quaternion.Lerp(transform.rotation, targetR, 0.8f);
        }
        if (timer > 5f && timer < 10f)
        {
            transform.position = new Vector3(transform.position.x - 1f * Time.deltaTime, transform.position.y, transform.position.z);

            Quaternion targetR = Quaternion.Euler(0, 180, 0);
            transform.rotation = Quaternion.Lerp(transform.rotation, targetR, 0.8f);
        }
        if (timer > 5f)
        {
            timer = 0;
        }
    }
}
