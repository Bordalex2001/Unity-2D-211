using UnityEngine;

public class CloudScript : MonoBehaviour
{
    void Update()
    {
        transform.Translate(Vector2.left * 0.01f);
        if(transform.position.x < -18f)
        {
            transform.position = new Vector3(18f, transform.position.y);
        }
    }
}