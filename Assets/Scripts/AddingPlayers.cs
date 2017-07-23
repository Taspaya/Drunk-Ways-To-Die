using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class AddingPlayers : MonoBehaviour {

    List<string> borrachos = new List<string>();            // Declarem La List, contenedora de borrachos

    public Text PlayersNames;
    public Text PlayerName;

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void RealAddPlayer()
    {

        name = PlayerName.text.ToString();                  // guardamos el texto en la variable name

        if (name != "")
        {
            borrachos.Add(name);                                // insertamos el name en la List
            Debug.Log("Afegit: " + name);                       // comprovamos que se ha añadido
            PlayerName.text = " ";                              // intentamos resetear el cuadro de texto
            //InputFieldCanvas.SetActive(false);                  // desactivamos el cuadro de texto
        }
        namesWriter();
    }

    public void BorrarBorrachos()
    {
        //borrachos = null;
        borrachos = new List<string>();
        namesWriter();
    }

    public void namesWriter()
    {
      //  BorrachosNamesCanvas.SetActive(true);

        PlayersNames.text = null;                                     // reseteas el texto, para que no se acumule
        for (int i = 0; i < borrachos.Count; i++)                     // recorres el size de la list
        {
            name = PlayersNames.text.ToString();                     // acumulas lo que havia en el texto
            PlayersNames.text =  borrachos[i] + "\n"+ name;        // Añades el siguiente           
        }
    }
}
