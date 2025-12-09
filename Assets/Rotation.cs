using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float speed = 20f; // velocidad en grados por segundo
    public Vector3 axis = new Vector3(0, 1, 0); // eje de rotación

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(axis, speed * Time.deltaTime);

    }
}
