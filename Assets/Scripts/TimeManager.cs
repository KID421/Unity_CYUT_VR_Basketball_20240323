using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace KID
{
    /// <summary>
    /// 時間管理器
    /// </summary>
    public class TimeManager : MonoBehaviour
    {
        [SerializeField, Header("時間文字")]
        private TMP_Text textTime;
        [SerializeField, Header("倒數時間"), Range(1, 100)]
        private float timeTotal = 60;
        [SerializeField, Header("畫布遊戲結束")]
        private GameObject canvasFinalObject;
        [SerializeField, Header("檢查區域分數管理器")]
        private GameObject scoreManagerObject;
        [SerializeField, Header("按鈕生成籃球")]
        private Button btnSpawn;

        // 更新事件：一秒執行約 60 次
        private void Update()
        {
            CountDown();
        }

        private void CountDown()
        {
            // 時間 扣除 每幀的時間 (約為 1/60 秒)
            timeTotal -= Time.deltaTime;
            // 夾住數字 (數字，最小，最大)
            timeTotal = Mathf.Clamp(timeTotal, 0, 100);
            // 更新 時間文字
            textTime.text = $"TIME - {timeTotal.ToString("F0")}";

            // 如果 時間 等於 0 就 呼叫遊戲結束方法
            if (timeTotal == 0) GameOver();
        }

        private void GameOver()
        {
            canvasFinalObject.SetActive(true);      // 顯示 遊戲結束畫布
            scoreManagerObject.SetActive(false);    // 隱藏 分數管理器
            btnSpawn.interactable = false;          // 關閉 生成籃球按鈕 互動
        }
    }
}
