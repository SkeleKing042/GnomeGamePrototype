//Created by Jackson Lucas
//Last Edited by Jackson Lucas

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    Rigidbody _rb;
    Vector2 _movementInput;
    public float MoveSpeed;
    public float StrafeSpeed;
    public float MaxSpeed;
    private float _movementModifier = 1;
    private bool ADSing = false;
    public Animator CameraController;
    public float DodgeSpeed;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (_rb.velocity.x + _rb.velocity.z < MaxSpeed)
            _rb.AddForce((transform.forward * _movementInput.x * (MoveSpeed * _rb.mass) * _movementModifier + transform.right * _movementInput.y * (StrafeSpeed * _rb.mass) * _movementModifier) * Time.deltaTime);
    }

    public void UpdateXMovement(float v)
    {
        _movementInput.x = v;
    }
    public void UpdateYMovement(float v)
    {
        _movementInput.y = v;
    }
    public void ToggleADSing()
    {
        if (ADSing)
        {
            _movementModifier = 1f;
            ADSing = false;
        }
        else
        {
            _movementModifier = 0.5f;
            ADSing = true;
        }
        CameraController.SetBool("ADS", ADSing);
    }
    public void DodgeRoll()
    {
        if (!ADSing)
            _rb.AddForce(transform.forward * _movementInput.x * DodgeSpeed * _movementModifier + transform.right * _movementInput.y * DodgeSpeed * _movementModifier, ForceMode.Impulse);
    }
}
