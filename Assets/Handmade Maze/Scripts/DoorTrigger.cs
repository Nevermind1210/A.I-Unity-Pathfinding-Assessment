using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    [SerializeField] GameObject door;

    [SerializeField] bool isOpened = false;

    private void OnTriggerEnter(Collider other)
    {
        if(!isOpened)
        {
            door.transform.position += new Vector3(0, 4, 0);
        }
    }
}
