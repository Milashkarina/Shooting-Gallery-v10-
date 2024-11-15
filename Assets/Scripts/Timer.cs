using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float startTime = 120f; // Время начала таймера
    public Text txtTimer;

    void Update()
    {
        if (startTime > 0)
        {
            startTime -= Time.deltaTime;
            txtTimer.text = Mathf.Round(startTime).ToString("F0");
        }
        else
        {
            Debug.Log("Время вышло! Игра окончена.");
            // Здесь можно добавить любые дополнительные действия перед завершением игры, например, показ сообщения или экрана Game Over
            #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false; // Завершение игры в редакторе
            #else
                Application.Quit(); // Завершение игры в сборке
            #endif
        }
    }
}