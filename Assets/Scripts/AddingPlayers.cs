using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class AddingPlayers : MonoBehaviour {

    List<Borracho> borrachos = new List<Borracho>();            // Declarem La List, contenedora de borrachos

    public Borracho borrachin;
    public Image imagen;
    public Color colorin;

    public GameObject ColorPickerCanvas;
    public Text PlayersNames;
    public Text PlayerName;

    // Use this for initialization
    void Start () {
        ColorPickerCanvas.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void RealAddPlayer()
    {



       borrachin.nombreBorracho = PlayerName.text.ToString();                  // guardamos el texto en la variable name

        if (borrachin.nombreBorracho != "")
        {
            borrachos.Add(borrachin);                                // insertamos el name en la List
            Debug.Log("Afegit: " + name);                       // comprovamos que se ha añadido
           
        }
        namesWriter();
    }

    public void BorrarBorrachos()
    {
        //borrachos = null;
        borrachos = new List<Borracho>();
        namesWriter();
    }

    public void namesWriter()
    {
      //  BorrachosNamesCanvas.SetActive(true);

        PlayersNames.text = null;                                     // reseteas el texto, para que no se acumule
        for (int i = 0; i < borrachos.Count; i++)                     // recorres el size de la list
        {
            name = PlayersNames.text.ToString();                      // acumulas lo que havia en el texto
            PlayersNames.text =  borrachos[i] + "\n"+ name;           // Añades el siguiente           
        }
    }

    public void choseColorBTN()
    {
        ColorPickerCanvas.SetActive(true);
    }

    public void chooseColor()
    {
        
        // colorin = imagen.GetPixelAdjustedRect(); ARREGLAR AIXO 
        ColorPickerCanvas.SetActive(false);
    }

}
