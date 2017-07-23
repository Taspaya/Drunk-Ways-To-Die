﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{

   

    public GameObject InputFieldCanvas;
    public GameObject BorrachosNamesCanvas;
    public GameObject SettingsCanvas;
    public Text PlayerName;
   
    public string name;




    void Start()
    {
        InputFieldCanvas.SetActive(false);                         // El cuadro de texto empieza en falso
        BorrachosNamesCanvas.SetActive(false);
        SettingsCanvas.SetActive(false);

    }


    void Update()
    {
    }

  
    public void BorrachosBack() {
        BorrachosNamesCanvas.SetActive(false);
    }           // PENDIENTE DE QUITAR XXXXXXXXXXXX


    public void OptionsBTN() 
    {
        SettingsCanvas.SetActive(true);
    }       // SE QUEDA 
    public void OptionsBackBTN() {
        SettingsCanvas.SetActive(false);
    }   // SE QUEDA
    
    public void SalirDelJuego()
    {
        Application.Quit();
    }
    
}
