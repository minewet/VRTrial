using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OVR;

public class GrabButtonInput : MonoBehaviour
{
    public OVRGrabbable ovrGrabbable;

    void Update()
	{
		if (ovrGrabbable.isGrabbed && OVRInput.Get(OVRInput.Button.One))
		{
			transform.GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value, 1.0f);
		}
	}
}
