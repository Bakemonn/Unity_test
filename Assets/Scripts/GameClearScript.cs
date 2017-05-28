using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameClearScript : MonoBehaviour {

    public GUIStyle style;
    public GameObject obj;
    public SceneScript script;

	// Use this for initialization
	void Start () {
        obj = GameObject.Find("SceneScript");
        script = obj.GetComponent<SceneScript>();
	}
	
    void OnGUI()
    {
        GUI.Label(new Rect(50, 100, 300, 100), "Game Clear !!", style);
        GUI.Label(new Rect(50, 200, 300, 100), "スコア :" + (script.score + script.life * 100), style);
    }
}
