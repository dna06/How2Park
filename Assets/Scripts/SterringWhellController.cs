using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SteeringWheelController : MonoBehaviour
{
    private static SteeringWheelController instance = null;

    public static SteeringWheelController GetInstance()
    {
        if (instance == null)
        {
            instance = new GameObject("SteeringWheelCtrl").AddComponent<SteeringWheelController>();
            //1, two kinds of initialization, see the requirements can be used.
            Debug.Log("SteeringInit:" + LogitechGSDK.LogiLedInit());
            Debug.Log("SteeringInit2:" + LogitechGSDK.LogiSteeringInitialize(false));
        }
        return instance;
    }
    //2 before exiting
    void OnApplicationQuit()
    {
        Debug.Log("SteeringShutdown:" + LogitechGSDK.LogiSteeringShutdown());
    }
}

