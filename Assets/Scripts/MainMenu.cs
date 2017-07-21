using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {

    List<string> borrachos = new List<string> ();

    public GameObject InputField;
    public Text PlayerName;
    public string name;



   
    void Start () {
        InputField.SetActive(false);                         // El cuadro de texto empieza en falso
    }
	

	void Update () {
	}

    public void addPlayer() {
        InputField.SetActive(true);                         // quando pulsamos el boton, se activa el cuadro de texto
        PlayerName.text = " ";                               // intentamos resetear el cuadro de texto
    }
    public void RealAddPlayer() {

        name = PlayerName.text.ToString();                  // guardamos el texto en la variable name
        borrachos.Add(name);                                // insertamos el name en la List
       // Debug.Log(borrachos[0]);
        Debug.Log("Afegit: " + name);                       // comprovamos que se ha añadido
        PlayerName.text = " ";                               // intentamos resetear el cuadro de texto
        InputField.SetActive(false);                        // desactivamos el cuadro de texto
        
    }
}
