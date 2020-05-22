using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Media;
using UnityEngine;

public class Triggerz : MonoBehaviour
{

    private HashSet<Collider> m_colliders = new HashSet<Collider>();


    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            m_colliders.Add(other);
        }

       else
        {
            Debug.Log("NONO")
        }

    }


    void OnTriggerExit(Collider Dzone)
    {

        if (other.tag == "Player")
        {
            m_colliders.Remove(Dzone);
        }

       

    }

    void Update()
    {


        if (m_colliders.Count == 4)
        {
            Debug.Log("You Did It!! :D");
        }

        else
        {
            Debug.Log("Waiting or it...");
        }

        Debug.Log(m_colliders.Count);
    }
}
