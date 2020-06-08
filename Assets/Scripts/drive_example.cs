using UnityEngine;
using System.Collections.Generic;

public class drive_examples : MonoBehaviour
{
    private Rigidbody vehicleRigidbody;
    private Transform vehicleTransformer;
    public float momentum;
    private float turning;

    public Dictionary<string, float> CarFloats = new Dictionary<string, float>()
    {
    {"steeringWheel",0},
    {"turningSpeed",0},
    {"pedal",0},
    {"momentumMultiplier",1},
    {"moveSpeed",1.5f},
    {"startOffSpeed",0.05f},
    };


    public enum Modes { pedal, brake, hasBrakeReset, stillBacking };
    public Modes modes;


    void Update()
    {
        if (CarFloats["steeringWheel"] == 0)
        {
            print("hello");
        }

        switch (modes)
        {
            case Modes.pedal:
                print("pedal");
                break;
            case Modes.brake:
                print("brake");
                break;
            case Modes.hasBrakeReset:
                print("hasBrakeReset");
                break;
            case Modes.stillBacking:
                print("stillBacking");
                break;
            default:
                print("None");
                break;
        }
    }
}