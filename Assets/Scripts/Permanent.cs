﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Permanent : MonoBehaviour {

    public AddingPlayers Feels;

    public Permanent permanent;

    private List<Borracho> Jugadors = new List<Borracho>();
    // Use this for initialization
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        if (permanent == null)
        {
            permanent = this;
            DontDestroyOnLoad(gameObject);
            Debug.Log("vengo de antes");
        }
        else if (permanent != this)
        {
            Debug.Log("no se lo que passa pero te pinta de que funciona");
            Destroy(gameObject);
        }
    }

    void Start () {


    }
	
	// Update is called once per frame
	void Update () {
		
	}


    public void GOGOGO()
    {
       // Jugadors = Feels.borrachos;

        SceneManager.LoadScene("TableroPrincipal");
    }
}
