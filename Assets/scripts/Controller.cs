using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {

    public Controller controller;
    GameObject hacka;
    bool start;

	// Use this for initialization
	void Start () {
        controller = this;
        GameObject hacka = GameObject.Find("GameObject");
        hacka.GetComponent<Animator>().SetBool("start", false);
    }
	
	// Update is called once per frame
	void Update () {
        hacka.GetComponent<Animator>().SetBool("start", true);
        hacka.GetComponent<Animator>().SetTrigger("spin");
	}
}
