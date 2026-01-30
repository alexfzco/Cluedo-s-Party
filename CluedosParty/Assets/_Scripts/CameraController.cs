using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Camera))]
public class CameraController : MonoBehaviour
{
    

    [Header("Controls")]
    [SerializeField, Range(0.5f,5)] private float _xSensibility;
    [SerializeField, Range(0.5f, 5)] private float _ySensibility;
    [SerializeField] private float _stringArm;
    private float _mouseX;
    private float _mouseY;
    private Camera _camera;
    private float _XRotation =0f;

    private void Start()
    {
        _camera = GetComponent<Camera>();
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        _mouseX = Input.GetAxis("Mouse X");
        _mouseY = Input.GetAxis("Mouse Y");

        _XRotation += _mouseY;
        _XRotation = Mathf.Clamp(_XRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(-_XRotation, 0, 0);

        if (transform.parent != null)
        {
            transform.parent.Rotate(0, _mouseX, 0);
        }

        
        
    }
}
