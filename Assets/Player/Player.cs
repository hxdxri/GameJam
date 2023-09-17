using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    public static bool isDone = false;
 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(Input.GetAxis("Horizontal") * 6, Input.GetAxis("Vertical") * 6);
    }


    private void OnCollisionEnter2D(Collision2D obj)
    {
        if (obj.gameObject.tag == "Level 1 Finish")
        {
            SceneManager.LoadScene("Scenes/Level 2");
        }

        if (obj.gameObject.tag == "Level 2 Finish")
        {
            SceneManager.LoadScene("Scenes/Level 3");
        }

        if (obj.gameObject.tag=="Level 3 Finish")
        {
            SceneManager.LoadScene("Scenes/Level 4");
        }

        if (obj.gameObject.tag == "Level 4 Finish")
        {
            SceneManager.LoadScene("Scenes/Level 5");
        }

        if (obj.gameObject.tag == "Level 5 Finish")
        {
            isDone = true;
            SceneManager.LoadScene("Scenes/YouWin");
        }


    }

}
