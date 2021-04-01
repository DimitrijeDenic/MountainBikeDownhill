
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform target;
    public Vector3 targetOff;
    private void Start()
    {
        targetOff = transform.position - target.position;
    }
    void Update()
    {
        if (target)
        {
            transform.position = Vector3.Lerp(transform.position, target.position + targetOff, 0.1f);
        }
    }
}
