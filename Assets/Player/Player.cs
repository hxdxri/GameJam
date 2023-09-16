using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
 
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
        if (obj.gameObject.tag=="Level 3 Finish")
        {
            SceneManager.LoadScene("Scenes/Level 1");
        }

    }

}
