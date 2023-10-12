using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour
{
    [Tooltip("The senitivity of the mouse input")]
    public Vector2 Sensitivity = new Vector2(1,1);
    [Header("Y Axis")]
    [Tooltip("The object to be affected by the vertical mouse input")]
    public Transform YToRotate;
    private float _Yvalue;
    [Tooltip("The name of the axis to derive the vertical mouse input from")]
    public string YInputAxisName;
    [Tooltip("The limits of the vertical axis movement")]
    public Vector2 YBounds;
    [Header("X Axis")]
    [Tooltip("The object to be affected by the horizontal mouse input")]
    public Transform XToRotate;
    [Tooltip("The name of the axis to derive the horizontal mouse input from")]
    public string XInputAxisName;

    private Vector2 _angles;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Gets the X and Y movements of the mouse and adds them to a value
        _Yvalue = Input.GetAxis(YInputAxisName) * Sensitivity.y;
        //This limits how far up and down the player can look
        _angles.y = Mathf.Clamp(_angles.y + _Yvalue, YBounds.x, YBounds.y);

        _angles.x += Input.GetAxis(XInputAxisName) * Sensitivity.x;
        //Loops the x axis back around
        if(_angles.x < 0) _angles.x = 360;
        if (_angles.x > 360) _angles.x = 0;

        YToRotate.rotation = Quaternion.Euler(-_angles.y, YToRotate.rotation.eulerAngles.y, YToRotate.rotation.eulerAngles.z);
        XToRotate.rotation = Quaternion.Euler(XToRotate.rotation.eulerAngles.x, _angles.x, XToRotate.rotation.eulerAngles.z);
    }
}
