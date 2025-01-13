using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class ModalScript : MonoBehaviour
{
    [SerializeField]
    private GameObject content;
    [SerializeField]
    private TMPro.TextMeshProUGUI titleTMP;
    [SerializeField]
    private TMPro.TextMeshProUGUI messageTMP;
    [SerializeField]
    private TMPro.TextMeshProUGUI rightButtonTMP;

    private static ModalScript instance;
    private string titleDefault;
    private string messageDefault;
    private string rightButtonDefault;

    void Start()
    {
        instance = this;
        titleDefault = titleTMP.text;
        messageDefault = messageTMP.text;
        rightButtonDefault = rightButtonTMP.text;
        if (content.activeInHierarchy)
        {
            Time.timeScale = 0.0f;
        }
        else
        {
            Time.timeScale = 1.0f;
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) 
        {
            Time.timeScale = content.activeInHierarchy ? 1.0f : 0.0f;
            content.SetActive(!content.activeInHierarchy);
        }
    }

    public void OnResumeButtonClick()
    {
        Time.timeScale = 1.0f;
        content.SetActive(false);
        if (GameState.isLevelFailed)
        {
            SceneManager.LoadScene(GameState.levelIndex);
        }
        else if (GameState.isLevelCompleted)
        {
            GameState.levelIndex++;
            if (GameState.levelIndex >= SceneManager.sceneCountInBuildSettings)
            {
                GameState.levelIndex = 0;
            }

            SceneManager.LoadScene(GameState.levelIndex);
        }
    }

    public void OnExitButtonClick()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
        Application.Quit();
    }

    private void _Show(string title = null, string message = null, string rightButton = null)
    {
        content.SetActive(true);
        Time.timeScale = 0.0f;
        if (title != null)
        {
            titleTMP.text = title;
        }
        else
        {
            titleTMP.text = titleDefault;
        }

        if (message != null)
        {
            messageTMP.text = message;
        }
        else
        {
            messageTMP.text = messageDefault;
        }

        if (rightButton != null)
        {
            rightButtonTMP.text = rightButton;
        }
        else
        {
            rightButtonTMP.text = rightButtonDefault;
        }
    }

    public static void ShowModal(string title = null, string message = null, string rightButton = null)
    {
        instance._Show(title, message, rightButton);
    }
}