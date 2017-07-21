using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{

    List<string> borrachos = new List<string>();

    public GameObject InputField;
    public Text PlayerName;
    public Text PlayersNames;
    public string name;




    void Start()
    {
        InputField.SetActive(false);                         // El cuadro de texto empieza en falso

       /* borrachos.Add("Gerard");
        borrachos.Add("Javi");
        borrachos.Add("Oscar");
        borrachos.Add("Radev");
        borrachos.Add("Tona");
        borrachos.Add("El Jaume");*/
    }


    void Update()
    {
    }

    public void addPlayer()
    {
        InputField.SetActive(true);                         // quando pulsamos el boton, se activa el cuadro de texto
        PlayerName.text = null;                               // intentamos resetear el cuadro de texto
    }
    public void RealAddPlayer()
    {

        name = PlayerName.text.ToString();                  // guardamos el texto en la variable name
        borrachos.Add(name);                                // insertamos el name en la List
                                                            // Debug.Log(borrachos[0]);
        Debug.Log("Afegit: " + name);                       // comprovamos que se ha añadido
        PlayerName.text = " ";                              // intentamos resetear el cuadro de texto
        InputField.SetActive(false);                        // desactivamos el cuadro de texto

    }

    public void namesWriter()
    {

        PlayersNames.text = null;                           // reseteas el texto, para que no se acumule
        for (int i = 0; i < borrachos.Count; i++)           // recorres el size de la list
        {
            name = PlayersNames.text.ToString();            // acumulas lo que havia en el texto
            PlayersNames.text = name + "\n\n" + borrachos[i];// Añades el siguiente
            
            
        }
    }
}
