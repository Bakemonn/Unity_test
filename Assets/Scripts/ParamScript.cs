using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParamScript : MonoBehaviour {

    public GUIStyle style;
    GameObject obj;
    SceneScript script;
    
    void OnGUI()
    {
        obj = GameObject.Find("SceneScript");
        script = obj.GetComponent<SceneScript>();
        
        GUI.Label(new Rect(10, 10, 200, 40), "点数", style);
        GUI.Label(new Rect(10, 50, 200, 40), "" + script.score, style);
        GUI.Label(new Rect(10, 120, 200, 40), "残機数", style);
        GUI.Label(new Rect(10, 160, 200, 40), "" + script.life, style);
        GUI.Label(new Rect(10, 230, 200, 40), "残りブロック", style);
        GUI.Label(new Rect(10, 270, 200, 40), "" + script.blockCt, style);

    }
}
