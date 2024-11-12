using UnityEngine;

public class ArrowMonoBehaviourScript : MonoBehaviour
{
    private object rotAnchor;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float InputY = Input.GetAxis("Vertical");
        float Angle = transform.eulerAngles.z;

        if (Angle > 180)
        {
            Angle -= 360;
        }

        Debug.Log(Angle + InputY);

        /*if (Angle + InputY > -15 && Angle + InputY < 60)
        {
            transform.RotateAround(rotAnchor.position, Vector3.forward, InputY);
        }*/

    }
}
