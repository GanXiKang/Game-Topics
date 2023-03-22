using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventControl : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            StartCoroutine(EventHappened());
        }
    }
    IEnumerator EventHappened()
    {
        print("ÍËºóƒÉ‚€£¡");
        yield return new WaitForSeconds(2f);
        Dice.totalNum -= 2;
    }
}
