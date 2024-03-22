using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinCube : MonoBehaviour
{
    [SerializeField] private float _xAngle;
    [SerializeField] private float _yAngle;
    [SerializeField] private float _zAngle;

    void Update()
    {
        transform.Rotate(_xAngle, _yAngle, _zAngle);
    }
}
