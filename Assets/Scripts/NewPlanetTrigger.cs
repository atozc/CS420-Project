using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewPlanetTrigger : MonoBehaviour
{
    public GameObject PlanetUI;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            PlanetUI.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
