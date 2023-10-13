//Created by Jackson Lucas
//Last Edited by Jackson Lucass

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformTracker : MonoBehaviour
{
    public Transform Target;
    public bool LockRotation;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Target.position;
        if (LockRotation) transform.rotation = Quaternion.identity;
    }
}
