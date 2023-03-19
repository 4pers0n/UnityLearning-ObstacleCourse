using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] private float _xSpinningSpeed = 50f;
    [SerializeField] private float _ySpinningSpeed = 50f;
    [SerializeField] private float _zSpinningSpeed = 50f;

    private void Update()
    {
        transform.Rotate(_xSpinningSpeed * Time.deltaTime, _ySpinningSpeed * Time.deltaTime, _zSpinningSpeed * Time.deltaTime);
    }
}
