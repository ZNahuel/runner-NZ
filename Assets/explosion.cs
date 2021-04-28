using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosion : MonoBehaviour
{
    public GameObject pickupEffect;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            StartCoroutine(timer());
            Debug.Log("funca collision");
        }
    }
    private IEnumerator timer()
    {
        yield return new WaitForSeconds(2f);
        Destroy(pickupEffect);
        Debug.Log("funca pikup");
    }
}
