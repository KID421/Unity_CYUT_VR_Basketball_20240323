using UnityEngine;

namespace KID
{
    /// <summary>
    /// 籃球系統
    /// </summary>
    public class BasketballSystem : MonoBehaviour
    {
        [SerializeField, Header("籃球")]
        private GameObject basketball;

        // Unity 的按鈕跟程式溝通的方式
        // 需要一個公開的方法，或稱為函式、函數
        // 方法的語法：
        // 公開 void 方法名稱 () { 程式內容 }
        public void SpawnBasketball()
        {
            // 生成(物件，座標，角度)；
            // 此物件的座標 transform.posiotion
            // 零度角 Quaternion.identity
            Instantiate(basketball, transform.position, Quaternion.identity);
        }
    }
}
