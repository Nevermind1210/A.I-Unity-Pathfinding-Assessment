using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    enum Doors
    {
        Empty,
        Door,
        Door2,
        Door3
    }

    [SerializeField] GameObject door;
    [SerializeField] bool isOpened = false;

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(!isOpened)
        {
            isOpened = true;
        }
    }
}
