using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeButton : MonoBehaviour
{
    public void GoToLevel()
    {
        SceneManager.LoadScene("Scenes/Level 1"); // Load the specified scene.
    }
}
