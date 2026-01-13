using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float speed = 100f; // velocidad en grados por segundo
    public Vector3 axis = new Vector3(0, 0, 1); // eje de rotación

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, speed * Time.deltaTime, 0f, Space.World);
    }
}

