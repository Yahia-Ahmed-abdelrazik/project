// using UnityEngine;

// public class GameManager : MonoBehaviour
// {
	
// }
////////////////////////////////
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverPanel; // لوحة Game Over

    private bool isGameOver = false;

    // استدعاء عند انتهاء اللعبة
    public void GameOver()
    {
        isGameOver = true;
        if (gameOverPanel != null)
        {
            gameOverPanel.SetActive(true); // إظهار لوحة Game Over
        }
    }

    void Update()
    {
        // إذا انتهت اللعبة واللاعب ضغط على الشاشة
        if (isGameOver && Input.GetMouseButtonDown(0))
        {
            RestartGame(); // إعادة تشغيل اللعبة
        }
    }

    // وظيفة إعادة تشغيل اللعبة
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // إعادة تحميل المشهد الحالي
    }
}
