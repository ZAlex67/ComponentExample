using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class ChangeCapsuleSize : MonoBehaviour
{
    [SerializeField] private float _speedScale;

    void Update()
    {
        transform.localScale += new Vector3(_speedScale, _speedScale, _speedScale);
    }
}