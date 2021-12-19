using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    public Transform Snake;
    private Vector3 offset;

    private void Start()
    {
        offset = transform.position - Snake.transform.position;
    }

    private void Update()
    {
        Vector3 transformPosition = new Vector3(0, Snake.position.y + offset.y, Snake.position.z + offset.z);
        transform.position = transformPosition;
    }
}
