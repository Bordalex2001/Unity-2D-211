using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class ForceScript : MonoBehaviour
{
    private Image indicator;
    private InputAction moveAction;
    
    void Start()
    {
        indicator = GetComponent<Image>();
        moveAction = InputSystem.actions.FindAction("Move");
    }

    void Update()
    {
        Vector2 moveValue = moveAction.ReadValue<Vector2>();
        float delta = moveValue.x * Time.deltaTime;
        indicator.fillAmount = Mathf.Clamp(indicator.fillAmount + delta, 0, 1);
    }
}
