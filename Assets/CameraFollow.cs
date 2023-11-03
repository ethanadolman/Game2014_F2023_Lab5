using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] GameObject Target;
    [SerializeField] private Vector3 Offset;

    // Update is called once per frame
    void Update()
    {

        transform.position = Target.transform.position + Offset;
    }
}
