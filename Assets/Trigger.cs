using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triggerz : MonoBehaviour
{

    private HashSet<Collider> m_colliders = new HashSet<Collider>();


    void OnTriggerEnter(Collider DZone)
    {

        m_colliders.Add(DZone);

    }


    void OnTriggerExit(Collider Dzone)
    {

        m_colliders.Remove(Dzone);

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
