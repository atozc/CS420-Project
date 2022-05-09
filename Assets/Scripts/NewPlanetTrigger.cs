using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewPlanetTrigger : MonoBehaviour
{
    public GameObject MercuryUI;
    public GameObject VenusUI;
    public GameObject EarthUI;
    public GameObject MarsUI;
    public GameObject JupiterUI;
    public GameObject SaturnUI;
    public GameObject UranusUI;
    public GameObject NeptuneUI;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        if (Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            // Casts the ray and get the first game object hit
            Physics.Raycast(ray, out hit);
            //Debug.Log("This hit at " + hit.point);
            Debug.Log("This hit planet " + gameObject.name);

            if (gameObject.name == "Mercury")
            {
                MercuryUI.SetActive(true); //set associated planet's UI active

                VenusUI.SetActive(false);
                EarthUI.SetActive(false);
                MarsUI.SetActive(false);
                JupiterUI.SetActive(false);
                SaturnUI.SetActive(false);
                UranusUI.SetActive(false);
                NeptuneUI.SetActive(false);

                Time.timeScale = 0; //pause gameplay
            }
            if (gameObject.name == "Venus")
            {
                VenusUI.SetActive(true); //set associated planet's UI active

                MercuryUI.SetActive(false);
                EarthUI.SetActive(false);
                MarsUI.SetActive(false);
                JupiterUI.SetActive(false);
                SaturnUI.SetActive(false);
                UranusUI.SetActive(false);
                NeptuneUI.SetActive(false);

                Time.timeScale = 0; //pause gameplay
            }
            if (gameObject.name == "Earth")
            {
                EarthUI.SetActive(true); //set associated planet's UI active

                MercuryUI.SetActive(false);
                VenusUI.SetActive(false);
                MarsUI.SetActive(false);
                JupiterUI.SetActive(false);
                SaturnUI.SetActive(false);
                UranusUI.SetActive(false);
                NeptuneUI.SetActive(false);

                Time.timeScale = 0; //pause gameplay
            }
            if (gameObject.name == "Mars")
            {
                MarsUI.SetActive(true); //set associated planet's UI active

                MercuryUI.SetActive(false);
                VenusUI.SetActive(false);
                EarthUI.SetActive(false);
                JupiterUI.SetActive(false);
                SaturnUI.SetActive(false);
                UranusUI.SetActive(false);
                NeptuneUI.SetActive(false);

                Time.timeScale = 0; //pause gameplay
            }
            if (gameObject.name == "Jupiter")
            {
                JupiterUI.SetActive(true); //set associated planet's UI active

                MercuryUI.SetActive(false);
                VenusUI.SetActive(false);
                EarthUI.SetActive(false);
                MarsUI.SetActive(false);
                SaturnUI.SetActive(false);
                UranusUI.SetActive(false);
                NeptuneUI.SetActive(false);

                Time.timeScale = 0; //pause gameplay
            }
            if (gameObject.name == "Saturn")
            {
                SaturnUI.SetActive(true); //set associated planet's UI active

                MercuryUI.SetActive(false);
                VenusUI.SetActive(false);
                EarthUI.SetActive(false);
                MarsUI.SetActive(false);
                JupiterUI.SetActive(false);
                UranusUI.SetActive(false);
                NeptuneUI.SetActive(false);

                Time.timeScale = 0; //pause gameplay
            }
            if (gameObject.name == "Uranus")
            {
                UranusUI.SetActive(true); //set associated planet's UI active

                MercuryUI.SetActive(false);
                VenusUI.SetActive(false);
                EarthUI.SetActive(false);
                MarsUI.SetActive(false);
                JupiterUI.SetActive(false);
                SaturnUI.SetActive(false);
                NeptuneUI.SetActive(false);

                Time.timeScale = 0; //pause gameplay
            }
            if (gameObject.name == "Neptune")
            {
                NeptuneUI.SetActive(true); //set associated planet's UI active

                MercuryUI.SetActive(false);
                VenusUI.SetActive(false);
                EarthUI.SetActive(false);
                MarsUI.SetActive(false);
                JupiterUI.SetActive(false);
                SaturnUI.SetActive(false);
                UranusUI.SetActive(false);

                Time.timeScale = 0; //pause gameplay
            }
        }
    }

    public void GoBackToGame()
    {
        MercuryUI.SetActive(false);
        VenusUI.SetActive(false);
        EarthUI.SetActive(false);
        MarsUI.SetActive(false);
        JupiterUI.SetActive(false);
        SaturnUI.SetActive(false);
        UranusUI.SetActive(false);
        NeptuneUI.SetActive(false);
        Time.timeScale = 1;
    }
}
          