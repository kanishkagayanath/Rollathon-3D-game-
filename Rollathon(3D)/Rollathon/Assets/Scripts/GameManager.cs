using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    bool gamehasended = false;
    public float restartDelay = 1f;
    public GameObject completeLevelUI;

    public void completelevel()
    {
        completeLevelUI.SetActive(true);
    }

    public void gameover()
    {
        if (gamehasended == false)
        {
            gamehasended = true;
            Debug.Log("Game Over");
            Invoke ("Restart", restartDelay);
        }
    }



    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
