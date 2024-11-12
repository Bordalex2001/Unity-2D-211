using UnityEngine;

public class HexagonScript : MonoBehaviour
{
    private Rigidbody2D rb2d;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            rb2d.AddForce(Vector2.up * 300);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            rb2d.AddForce(Vector2.left * 300);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            rb2d.AddForce(Vector2.right * 300);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            rb2d.AddTorque(10f, ForceMode2D.Force);
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            rb2d.angularVelocity = 0f;
            rb2d.linearVelocity = new Vector2(0, 0);
        }
    }
}