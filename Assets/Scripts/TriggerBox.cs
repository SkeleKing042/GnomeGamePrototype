//Created by Jackson Lucas
//Last Edited by Jackson Lucass

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerBox : MonoBehaviour
{
    public UnityEvent TriggerEnterEvent = new UnityEvent();
    public UnityEvent TriggerStayEvent = new UnityEvent();
    public UnityEvent TriggerLeaveEvent = new UnityEvent();

    private void OnTriggerEnter(Collider other)
    {
        TriggerEnterEvent.Invoke();
    }
    private void OnTriggerStay(Collider other)
    {
        TriggerStayEvent.Invoke();
    }
    private void OnTriggerExit(Collider other)
    {
        TriggerLeaveEvent.Invoke();
    }
}
