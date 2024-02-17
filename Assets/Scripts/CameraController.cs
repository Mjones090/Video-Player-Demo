using UnityEngine;

public class CameraController : MonoBehaviour
{

    public float speed;
    public Transform target;

    void Update()
    {
        transform.LookAt(target);

        if (Input.GetAxis("Vertical") != 0)
        {
            transform.RotateAround(target.position, target.right, Time.deltaTime * speed); //.up = positive y
        }

        if (Input.GetAxis("Horizontal") != 0)
        {
            transform.RotateAround(target.position, target.forward, Time.deltaTime * speed); //.right = positive x
        }
    }
}