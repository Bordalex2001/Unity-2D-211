using UnityEngine;

public class CloudScript : MonoBehaviour
{
    void Update()
    {
        this.transform.Translate(Vector2.left * 0.01f);
        if(this.transform.position.x < -18f)
        {
            this.transform.position = new Vector3(18f, this.transform.position.y);
        }
    }
}
