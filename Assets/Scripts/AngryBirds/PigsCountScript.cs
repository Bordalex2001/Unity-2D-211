using UnityEngine;
using UnityEngine.SceneManagement;

public class PigsCountScript : MonoBehaviour
{
    private TMPro.TextMeshProUGUI pigsCountTMP;

    void Start()
    {
        pigsCountTMP = GetComponent<TMPro.TextMeshProUGUI>();

        GameState.needRecalculatePigs = true;
    }

    void Update()
    {
        if (GameState.needRecalculatePigs)
        {
            int pigsCount = GameObject.FindGameObjectsWithTag("Pig").Length;
            pigsCountTMP.text = pigsCount.ToString();

            GameState.needRecalculatePigs = false;
            GameState.isLevelCompleted = pigsCount == 0;
            GameState.isLevelFailed = pigsCount > 0;

            if (pigsCount == 0)
            {
                if (GameState.levelIndex + 1 == SceneManager.sceneCountInBuildSettings)
                {
                    GameState.isGameCompleted = true;
                    ModalScript.ShowModal("Вітаємо", "Всі рівні пройдено, бажаєте почати гру спочатку?", "Нова гра");
                }
                else
                {
                    ModalScript.ShowModal("Вітаємо", "Рівень пройдено, знищено всіх ворогів");
                }
            }
        }
    }
}