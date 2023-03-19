using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] private float _timeToWait = 5f;

    private MeshRenderer _mr;
    private Rigidbody _rb;

    private void Awake()
    {
        _mr = GetComponent<MeshRenderer>();
        _rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Time.time > _timeToWait)
        {
            _mr.enabled = true;
            _rb.useGravity = true;
        }
    }
}
