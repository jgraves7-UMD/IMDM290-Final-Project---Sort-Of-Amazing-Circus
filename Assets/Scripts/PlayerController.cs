using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;
public class PlayerController : MonoBehaviour
{

    public int tickets;         // amount of tickets player can earn
    public XRNode inputSource;  // input for VR controller
    private Vector2 inputAxis;  // whether x or y in terms of control
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        InputDevice device = InputDevices.GetDeviceAtXRNode(inputSource);   // get vr headset 
        
    }
}
