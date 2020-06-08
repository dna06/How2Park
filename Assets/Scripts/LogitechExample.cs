using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogitechExample : MonoBehaviour {

    LogitechGSDK.LogiControllerPropertiesData properties;

    public float xAxes, GasInput, BreakInput, ClutchInput;

    public bool HShift= true;
    
        public int CurrentGear;

        // Start is called before the first frame update
    void Start()
    {
        print(LogitechGSDK.LogiSteeringInitialize(true)); 
    }

    // Update is called once per frame
    void Update()
    {
        if (LogitechGSDK.LogiUpdate() && LogitechGSDK.LogiIsConnected(0))
        {
            LogitechGSDK.DIJOYSTATE2ENGINES rec;
            rec = LogitechGSDK.LogiGetStateUnity(0);
           // HShifter(rec);
     
            xAxes = rec.lX / 32760f;
            if (rec.lY > 0)
            {
                GasInput = 0;
            }
            else if (rec.lY < 0)
            {
                GasInput = rec.lY / -32760f;
            }
            if (rec.lRz > 0)
            {
                BreakInput = 0;
            }
            else if (rec.lRz < 0)
            {
                BreakInput = rec.lRz / -32760f;
            }

           /* if (rec.rgbButtons[0] == 0)
            {
                ClutchInput = 0;
            }
            else if (rec.rgbButtons[0] != 0)
            {
                ClutchInput = rec.rgbButtons[0] / -32760f;
            }*/

            // Paddle shifter



            // GearUp = LogitechGSDK.LogiButtonIsPressed(0, 4);

            //GearDown = LogitechGSDK.LogiButtonIsPressed(0, 5);



            //HShifter

            if (LogitechGSDK.LogiButtonIsPressed(0, 8))

            {
                CurrentGear = 1;

            }

            else if (LogitechGSDK.LogiButtonIsPressed(0, 9))

            {
                CurrentGear = 2;

            }

            else if (LogitechGSDK.LogiButtonIsPressed(0, 10))

            {
                CurrentGear = 3;

            }

            else if (LogitechGSDK.LogiButtonIsPressed(0, 11))

            {
                CurrentGear = 4;

            }

            else if (LogitechGSDK.LogiButtonIsPressed(0, 12))

            {
                CurrentGear = 5;

            }

            else if (LogitechGSDK.LogiButtonIsPressed(0, 13))

            {
                CurrentGear = -1;

            }


            else

            {
                CurrentGear = 0;

            }
            /*  if (rec.rglSlider[0] > 0)
              {
                  ClutchInput = 0;
              }
              else if (rec.rglSlider[0] < 0)
              {
                  ClutchInput = rec.rglSlider[0] / -32760f;
              }*/

        }
        else {
            print("no steeringWheel");
            }
        }
    /*void HShifter(LogitechGSDK.DIJOYSTATE2ENGINES shifter)
    {
        for (int i = 0; i < 128; i++)
        {
            if (shifter.rgbButtons[i] == 128)
            {
                if (ClutchInput > 0.5f)
                {
                    if (i == 12)
                    {
                        CurrentGear = 1;

                    }
                    else if (i == 13)
                    {
                        CurrentGear = 2;
                    }
                    else if (i == 14)
                    {
                        CurrentGear = 3;
                    }
                    else if (i == 15)
                    {
                        CurrentGear = 4;
                    }
                    else if (i == 16)
                    {
                        CurrentGear = 5;
                    }
                    else if (i == 17)
                    {
                        CurrentGear = 6;
                    }
                    else if (i == 18)
                    {
                        CurrentGear = -1;
                    }
                    else if (i == 12)
                    {

                    }
                }

            }
        }
    
    }*/
    public float SteerContol()
    {
        return BreakInput;
    }

}
