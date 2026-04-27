using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartScript : MonoBehaviour
{
    public GameManager gameManager;
    public TimerScript timerScript;

    void OnGUI()
    {
        if (gameManager != null && gameManager.isGameOver)
        {
            float centerX = Screen.width / 2;
            float centerY = Screen.height / 2;

            // Get time
            float finalTime = timerScript != null ? timerScript.GetTime() : 0f;

            int minutes = Mathf.FloorToInt(finalTime / 60f);
            int seconds = Mathf.FloorToInt(finalTime % 60f);
            string timeText = string.Format("Time: {0:00}:{1:00}", minutes, seconds);

            // ⏱ Time (top)
            GUI.Label(new Rect(centerX - 75, centerY - 120, 150, 30), timeText);

            // 🎉 You Win (clearly ABOVE button)
            GUI.Label(new Rect(centerX - 75, centerY - 80, 150, 40), "You Win!");

            // 🔄 Button (lower, not overlapping)
            if (GUI.Button(new Rect(centerX - 60, centerY, 120, 40), "Restart"))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
}