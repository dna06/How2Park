using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigga : MonoBehaviour
{

    private HashSet<Collider> m_colliders = new HashSet<Collider>();


    void OnTriggerEnter(Collider other)
    {
       
            m_colliders.Add(other);
        

        

    }


    void OnTriggerExit(Collider other)
    {

        if (other.tag == "Player")
        {
            m_colliders.Remove(other);
        }

        else
        {
            Debug.Log("tjaja");
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

