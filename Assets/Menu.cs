using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void GoToMenu()
    {
        SceneManager.LoadScene("Scenes/Menu"); // Load the specified scene.
    }
}
