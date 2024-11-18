using UnityEngine;

public class ArrowMonoBehaviourScript : MonoBehaviour
{
    [SerializeField]
    private Transform rotAnchor;

    void Start()
    {
        
    }

    void Update()
    {
        float dy = Input.GetAxis("Vertical");
        float angle = transform.eulerAngles.z;

        if (angle > 180)
        {
            angle -= 360;
        }
        if (-15 < angle + dy && angle + dy < 60)
        {
            transform.RotateAround(rotAnchor.position, Vector3.forward, dy);
        }
    }
}