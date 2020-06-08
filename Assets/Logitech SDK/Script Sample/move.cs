using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{

    float mov;
    float rot;
    float brake;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        mov = Input.GetAxis("Vertical") * Time.deltaTime * 100.0f;
        rot = Input.GetAxis("Horizontal") * Time.deltaTime * 100.0f;
        brake = Input.GetAxis("Brake") * Time.deltaTime * 100.0f;
        transform.localPosition = new Vector3(rot, brake, mov);

    }
}
