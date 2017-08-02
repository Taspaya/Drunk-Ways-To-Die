using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TableroGame : MonoBehaviour {


    [SerializeField]
    public List<Borracho> borrachos;

    public AddingPlayers Scriptpjs;
    // Use this for initialization
	void Start () {


        Scriptpjs = GetComponent<AddingPlayers>();
        //borrachos = Scriptpjs.borrachos;

    }
	
	// Update is called once per frame 
	void Update () {

        Scriptpjs = GetComponent<AddingPlayers>();
       // borrachos = Scriptpjs.borrachos;
    }


}
