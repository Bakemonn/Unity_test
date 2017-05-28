using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BottomWall : MonoBehaviour {

    public GameObject obj;
    public SceneScript script;
    public GameObject ball;

    void Start()
    {
        obj = GameObject.Find("SceneScript");
        script = obj.GetComponent<SceneScript>();
    }

    void OnCollisionEnter(Collision coll)
    {
        Destroy(coll.gameObject);

        if(script.life > 0)
        {

            GameObject Ball = (GameObject)Instantiate(ball);
            Ball.name = "Ball";
            script.life--;
        }
        else if(script.life == 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
