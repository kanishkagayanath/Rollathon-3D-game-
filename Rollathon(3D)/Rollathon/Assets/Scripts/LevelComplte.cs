using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplte : MonoBehaviour
{
  public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
