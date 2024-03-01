using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGen : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        StartCoroutine("Transfer");
    }

    IEnumerator Transfer()
    {
        Debug.Log("hit the trigger zone");
        yield return new WaitForSeconds(1);
        Debug.Log("hit the trigger zone after one second");
        gameObject.transform.parent.position = new Vector3(0,0, gameObject.transform.position.z + 200);

    }
}
