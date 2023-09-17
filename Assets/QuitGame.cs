using UnityEngine;

public class GameManager : MonoBehaviour
{
    // This method quits the game when called.
    public void QuitGame()
    {
        Debug.Log("Blue Lives Matter");
        Application.Quit();
    }
}
