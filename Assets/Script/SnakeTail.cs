using System.Collections.Generic;
using UnityEngine;

public class SnakeTail : MonoBehaviour
{
    public Transform SnakeHead;
    public float SphereDiameter;

    private List<Transform> snakeSpheres = new List<Transform>();
    private List<Vector3> positions = new List<Vector3>();

    private void Awake()
    {
        positions.Add(SnakeHead.position);
    }

    private void Update()
    {
        float distance = ((Vector3) SnakeHead.position - positions[0]).magnitude;

        if (distance > SphereDiameter)
        {
            Vector3 direction = ((Vector3) SnakeHead.position - positions[0]).normalized;

            positions.Insert(0, positions[0] + direction * SphereDiameter);
            positions.RemoveAt(positions.Count - 1);

            distance -= SphereDiameter;
        }

        for (int i = 0; i < snakeSpheres.Count; i++)
        {
            snakeSpheres[i].position = Vector3.Lerp(positions[i + 1], positions[i], distance / SphereDiameter);
        }
    }

    public void AddSphere()
    {
        Transform sphere = Instantiate(SnakeHead, positions[positions.Count - 1], Quaternion.identity, transform);
        snakeSpheres.Add(sphere);
        positions.Add(sphere.position);
    }

    public void RemoveSphere()
    {
        Destroy(snakeSpheres[0].gameObject);
        snakeSpheres.RemoveAt(0);
        positions.RemoveAt(1);
    }
}
