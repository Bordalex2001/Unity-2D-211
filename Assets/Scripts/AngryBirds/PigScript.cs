using UnityEngine;

public class PigScript : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("PigDestroy"))
        {
            Destroy(gameObject);
            GameState.needRecalculatePigs = true;
        }
    }
}