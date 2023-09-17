using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimeHolder : MonoBehaviour
{ 
    public float timer = 0;
    bool switchedScene = false;

    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    void Update()
    {
        timer += Time.deltaTime;
        if(timer > 60 && !switchedScene && !Player.isDone)
        {
            switchedScene = true;
            SceneManager.LoadScene("Scenes/YouLose");
        }
    }
}
