using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float _speedScale;

    private void Update()
    {
        transform.localScale += Vector3.one * _speedScale;
    }
}