using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TableroGame : MonoBehaviour {

    private int nDado;

    [SerializeField]
    public AddingPlayers ScriptVell;
    public Text TurnoPlayerText;

    private int turno;
    private int AlreadyPlayers;
    // Use this for initialization
    public static List<Borracho> jugadores = new List<Borracho>();
    private List<string> PlayerNames = new List<string>();
    
    void Start () {

        
        turno = 0;

        

    }
	
	
	void Update () {

       // Debug.Log("Comprovant Turno");
        if(turno == 0)
        {
            TurnoPlayerText.text = PlayerPrefs.GetString("Player1");
            turno = turno % PlayerPrefs.GetInt("nPlayers");
        }
        else if(turno == 1)
        {
            TurnoPlayerText.text = PlayerPrefs.GetString("Player2");
            turno = turno % PlayerPrefs.GetInt("nPlayers");
        }
        else if (turno == 2)
        {
            TurnoPlayerText.text =  PlayerPrefs.GetString("Player3");
            turno = turno % PlayerPrefs.GetInt("nPlayers");
        }
        else if (turno == 3)
        {
            TurnoPlayerText.text =  PlayerPrefs.GetString("Player4");
            turno = turno % PlayerPrefs.GetInt("nPlayers");
        }
        else if (turno == 4)
        {
            TurnoPlayerText.text = PlayerPrefs.GetString("Player5");
            turno = turno % PlayerPrefs.GetInt("nPlayers");
        }
        else if (turno == 5)
        {
            TurnoPlayerText.text = PlayerPrefs.GetString("Player6");
            turno = turno % PlayerPrefs.GetInt("nPlayers");
        }

       

    }
        
    public void dado()
    {











    }

}
