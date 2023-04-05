using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG5_FishMoveControl : MonoBehaviour
{
    float timer;

    void FixedUpdate()
    {
        timer += Time.deltaTime;

        if (timer < 4f)
        {
            transform.position = new Vector3(transform.position.x + 1f * Time.deltaTime, transform.position.y, transform.position.z);

            Quaternion targetR = Quaternion.Euler(0, 180, 0);
            transform.rotation = Quaternion.Lerp(transform.rotation, targetR, 0.3f);
        }
        if (timer > 4f && timer < 8f)
        {
            transform.position = new Vector3(transform.position.x - 1f * Time.deltaTime, transform.position.y, transform.position.z);

            Quaternion targetR = Quaternion.Euler(0, 0, 0);
            transform.rotation = Quaternion.Lerp(transform.rotation, targetR, 0.3f);
        }
        if (timer > 8f)
        {
            timer = 0;
        }
    }
}
