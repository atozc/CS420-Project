using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackToGame : MonoBehaviour
{
    public GameObject FactsUI; 
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GoBackToGame()
    {
        FactsUI.SetActive(false);
        Time.timeScale = 1;
    }
}
