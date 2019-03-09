using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laser : MonoBehaviour
{

    Renderer m_laser;

    // Use this for initialization
    void Start()
    {
        m_laser = GetComponent<Renderer>();
        m_laser.enabled = false;
    }

    // Update is called once per frame
 
    public void makeAppear()
    {
        m_laser.enabled = true;
    }
    
}