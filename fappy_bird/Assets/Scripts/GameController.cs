using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
    public bool gameOver = false;
    public int score = 0;
    public static GameController instancia;
	// Use this for initialization
	void Start () {
        instancia = this;
	}
}
