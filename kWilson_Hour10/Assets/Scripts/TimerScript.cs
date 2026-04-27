using UnityEngine;

public class TimerScript : MonoBehaviour
{
    public GameManager gameManager;

    private float timer = 0f;

    void Update()
    {
        if (gameManager != null && !gameManager.isGameOver)
        {
            timer += Time.deltaTime;
        }
    }

    
    public float GetTime()
    {
        return timer;
    }

    void OnGUI()
    {
        int minutes = Mathf.FloorToInt(timer / 60f);
        int seconds = Mathf.FloorToInt(timer % 60f);

        string timeText = string.Format("{0:00}:{1:00}", minutes, seconds);

        GUI.Box(new Rect(10, 10, 100, 40), timeText);
    }
}