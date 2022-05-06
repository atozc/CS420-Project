using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlanetTrigger : MonoBehaviour
{
    public GameObject Planet;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Planet.SetActive(true);
        }
    }


}
