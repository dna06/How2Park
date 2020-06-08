using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class SimpleCarController : MonoBehaviour
{
    
     static public LogitechGSDK logitechGSDK;  

    private float m_horizontalInput;
    private float m_verticalInput;
    private float m_steeringAngle;
    private bool m_brakeInput;

    public WheelCollider frontDriverW, frontPassengerW;
    public WheelCollider rearDriverW, rearPassengerW;
    public Transform frontDriverT, frontPassengerT;
    public Transform rearDriverT, rearPassengerT;
    public float maxSteerAngle = 30;

     public float motorForce = 50;

    public float brakeStrength;


    private void FixedUpdate()
    {
        GetInput();
        Steer();
        Accelerate();
        UpdateWheelPoses();
        HandBrake();

    }



    public void GetInput()
    {
        m_horizontalInput = Input.GetAxis("Horizontal"); 
        m_verticalInput = Input.GetAxis("Vertical");
        m_brakeInput = Input.GetKey(KeyCode.Space);
        // motorForce = Input.GetKey()
    }

    private void Steer()
    {
        m_steeringAngle = maxSteerAngle * m_horizontalInput;
        frontDriverW.steerAngle = m_steeringAngle;
        frontPassengerW.steerAngle = m_steeringAngle; 
    }

    private void Accelerate()
    {
        frontDriverW.motorTorque = m_verticalInput * motorForce;
        frontPassengerW.motorTorque = m_verticalInput * motorForce;
    }

    private void UpdateWheelPoses()
    {
        UpdateWheelPose(frontDriverW, frontDriverT);
        UpdateWheelPose(frontPassengerW, frontPassengerT);
        UpdateWheelPose(rearDriverW, rearDriverT);
        UpdateWheelPose(frontPassengerW, frontPassengerT);
    }

    private void UpdateWheelPose(WheelCollider _collider, Transform _transform)
    {
        Vector3 _pos = _transform.position;
        Quaternion 
            _quat = _transform.rotation;

        _collider.GetWorldPose(out _pos, out _quat);

        _transform.position = _pos;
        _transform.rotation = _quat;

    }

    private void HandBrake()
    {
        if (m_brakeInput)
        {
            frontDriverW.brakeTorque = brakeStrength; frontPassengerW.brakeTorque = brakeStrength;
        }
        else
        {
            frontDriverW.brakeTorque = 0f; frontPassengerW.brakeTorque = 0f;
        }








    }
}
