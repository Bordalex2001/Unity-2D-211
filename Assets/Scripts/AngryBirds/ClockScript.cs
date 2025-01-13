using UnityEngine;

public class ClockScript : MonoBehaviour
{
    [SerializeField]
    private float timeLimit;

    private TMPro.TextMeshProUGUI clock;
    private float gameTime;

    void Start()
    {
        clock = GetComponent<TMPro.TextMeshProUGUI>();
        gameTime = 0.0f;
    }

    void Update()
    {
        gameTime += Time.deltaTime;

        int hours = (int)gameTime / 3600;
        int minutes = (int)gameTime / 60 % 60;
        int seconds = (int)gameTime % 60;
        float milliseconds = gameTime * 9f % 9f;

        clock.text = string.Format("{0:00}:{1:00}:{2:00}.{3:0}", hours, minutes, seconds, milliseconds);

        if (gameTime >= timeLimit)
        {
            GameState.isLevelFailed = true;
            ModalScript.ShowModal("Програш", "Час на проходження рівня сплив", "Перезапустити");
        }
    }
}