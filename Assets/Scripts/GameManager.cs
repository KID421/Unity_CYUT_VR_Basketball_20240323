using UnityEngine;
using UnityEngine.SceneManagement;

namespace KID
{
    /// <summary>
    /// 遊戲管理器
    /// </summary>
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
}
