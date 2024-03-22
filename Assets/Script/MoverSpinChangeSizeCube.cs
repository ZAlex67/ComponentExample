using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverSpinChangeSizeCube : MonoBehaviour
{
    [SerializeField] private Vector3 _movementDirection;

    [SerializeField] private float _xAngle;
    [SerializeField] private float _yAngle;
    [SerializeField] private float _zAngle;

    [SerializeField] private float _speedScale;

    void Update()
    {
        transform.Translate(_movementDirection);

        transform.Rotate(_xAngle, _yAngle, _zAngle);

        transform.localScale += new Vector3(_speedScale, _speedScale, _speedScale);
    }
}
