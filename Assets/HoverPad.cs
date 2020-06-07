
using System.Collections;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;
using System.Globalization;

public class HoverPad : MonoBehaviour
{
 
    private HashSet<Collider> m_colliders = new HashSet<Collider>();


    public GameObject jubi;

    public float timeStart;
    public Text textBox;

    bool timerActive = true;

   

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

        if (timerActive)
        {
            timeStart += Time.deltaTime;
            textBox.text = timeStart.ToString("F2");
        }

        if (m_colliders.Count == 4)
        {
            Debug.Log("yeah");

            jubi.SetActive(true);

            timerActive=false;


        }

        else
        {
            Debug.Log("Waiting or it...");
            jubi.SetActive(false);
        }

        Debug.Log(m_colliders.Count);
    }



}



