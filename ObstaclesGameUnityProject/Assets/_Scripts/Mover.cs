using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _movingSpeed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * _movingSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * _movingSpeed;

        transform.Translate(new Vector3(xValue, 0, zValue));
    }
}