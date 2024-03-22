using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private Vector3 _movementDirection;

    void Update()
    {
        transform.Translate(_movementDirection);
    }
}