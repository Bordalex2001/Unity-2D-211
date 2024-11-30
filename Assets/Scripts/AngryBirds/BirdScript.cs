using UnityEngine;

public class BirdScript : MonoBehaviour
{
    [SerializeField]
    private Transform arrow;
    private Rigidbody2D rb2d;
    //private ForceScript forceScript;
    //private Vector3 startPosition;
    //private Quaternion startRotation;
    //private float shotTimeout = 7.0f;
    //private float shotTime;
    //private bool isShot;

    void Start()
    {
        //shotTime = 0.0f;
        //isShot = false;
        //startPosition = transform.position;
        //startRotation = transform.rotation;
        rb2d = GetComponent<Rigidbody2D>();
        //forceScript = GameObject.Find("ForceCanvasIndicator").GetComponent<ForceScript>();
    }

    void Update()
    {
        //if (Time.timeScale == 0.0f) return;
        if (Input.GetKeyDown(KeyCode.Space) //&& !isShot
            )
        {
            //float forceFactor = 1000.0f;
            //if (forceScript != null)
            //{
            //    //forceFactor *= (forceScript.forceFactor + 0.5f);
            //}
            //else
            //{
            //    Debug.LogError("forceScript NULL, used default");
            //}
            rb2d.AddForce(1000 * arrow.right);
            //isShot = true;
            //shotTime = shotTimeout;
        }
        //if (isShot)
        //{
        //    shotTime -= Time.deltaTime;
        //    if (shotTime <= 0.0f)
        //    {
                
        //    }
        //}
    }
}
