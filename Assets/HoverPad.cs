﻿
using System.Collections;
using UnityEngine;
using System.Collections.Generic;

public class HoverPad : MonoBehaviour
{
    public GameManager gameManager; 
    private HashSet<Collider> m_colliders = new HashSet<Collider>();

    public GameObject uiObject;

    void Start()
    {
        uiObject.SetActive(false);
    }

    void OnTriggerEnter(Collider DZone)
    {

        m_colliders.Add(DZone);

    }


    void OnTriggerExit(Collider Dzone)
    {

        m_colliders.Remove(Dzone);

    }

    void Update ()
    {


        if (m_colliders.Count == 4)
        {
            uiObject.SetActive(true);
        }

        else
        {
            Debug.Log("Waiting or it...");
        }

        Debug.Log(m_colliders.Count);
    }



}



