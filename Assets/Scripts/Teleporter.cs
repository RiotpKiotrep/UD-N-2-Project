using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour {
    public GameObject destination;
    public string transportingTag = "Player";


    void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag(transportingTag) || collider.gameObject.layer == 1)
        {
            Vector3 targetPosition = destination.transform.position;
            targetPosition += destination.transform.forward * 2;
            collider.transform.position = targetPosition;

            if (destination.GetComponent<AudioSource>())
            {
                destination.GetComponent<AudioSource>().Play();
            }
        }
    }
}