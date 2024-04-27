using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void Replay()
    {
        SceneManager.LoadScene("籃球場");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
