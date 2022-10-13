using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OVR;

public class Turn : MonoBehaviour
{
    public Rigidbody player;
    public Transform rotator;
    public float speed;

    private void Start()
    {
    }

    void Update()
    {
        var RjoystickAxis = OVRInput.Get(OVRInput.RawAxis2D.RThumbstick, OVRInput.Controller.RTouch);
        if (RjoystickAxis.x >= .8f)
        {
            player.transform.RotateAround(rotator.position, transform.up, speed * .1f);
        }
        if (RjoystickAxis.x <= -.8f)
        {
            player.transform.RotateAround(rotator.position, transform.up, speed * .1f);
        }
    }
}