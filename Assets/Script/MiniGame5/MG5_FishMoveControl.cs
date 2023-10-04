using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG5_FishMoveControl : MonoBehaviour
{
    float timer;
    int r;

    void Start()
    {
        r = Random.Range(1, 4);
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
        if (timer < 8f)
        {
            transform.Translate(0, 0, 2f * Time.deltaTime);

            Quaternion targetR = Quaternion.Euler(0, 90, transform.position.z);
            transform.rotation = Quaternion.Lerp(transform.rotation, targetR, 10f);
        }
        if (timer > 8f && timer < 16f)
        {
            transform.Translate(0, 0, 2f * Time.deltaTime);

            Quaternion targetR = Quaternion.Euler(0, -90, transform.position.z);
            transform.rotation = Quaternion.Lerp(transform.rotation, targetR, 10f);
        }
        if (timer > 16f)
        {
            timer = 0;
        }
    }
    void MoveModel2()
    {
        if (timer < 7f)
        {
            transform.Translate(0, 0, 1.5f * Time.deltaTime);

            Quaternion targetR = Quaternion.Euler(0, -90, transform.position.z);
            transform.rotation = Quaternion.Lerp(transform.rotation, targetR, 10f);
        }
        if (timer > 7f && timer < 14f)
        {
            transform.Translate(0, 0, 1.5f * Time.deltaTime);

            Quaternion targetR = Quaternion.Euler(0, 90, transform.position.z);
            transform.rotation = Quaternion.Lerp(transform.rotation, targetR, 10f);
        }
        if (timer > 14f)
        {
            timer = 0;
        }
    }
    void MoveModel3()
    {
        if (timer < 5f)
        {
            transform.Translate(0, 0, 1 * Time.deltaTime);

            Quaternion targetR = Quaternion.Euler(0, -90, transform.position.z);
            transform.rotation = Quaternion.Lerp(transform.rotation, targetR, 10f);
        }
        if (timer > 5f && timer < 10f)
        {
            transform.Translate(0, 0, 1f * Time.deltaTime);

            Quaternion targetR = Quaternion.Euler(0, 90, transform.position.z);
            transform.rotation = Quaternion.Lerp(transform.rotation, targetR, 10f);
        }
        if (timer > 10f)
        {
            timer = 0;
        }
    }
}
