//Created by Jackson Lucas
//Last Edited by Jackson Lucas

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class runInCircle : MonoBehaviour
{
    public Transform ObjectTransform;
    private float _angle;
    public Vector2 Sizes;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        _angle += Time.deltaTime;
        ObjectTransform.position = new Vector3(Sizes.x * Mathf.Cos(_angle), ObjectTransform.position.y, Sizes.y * Mathf.Sin(_angle));
    }
}
