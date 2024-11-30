using UnityEngine;

public class ClockScript : MonoBehaviour
{
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
        clock.text = gameTime.ToString("F2");
    }
}