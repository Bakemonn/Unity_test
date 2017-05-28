using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScript : MonoBehaviour {

    public GUIStyle style;

	void OnGUI()
    {
        GUI.Label(new Rect(50, 100, 300, 100), "Game Over !!", style);
    }
}
