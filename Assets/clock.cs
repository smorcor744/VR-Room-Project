using System;
using UnityEngine;

public class clock : MonoBehaviour
{
    public GameObject secHand;
    public GameObject minHand;
    public GameObject hourHand;

    void Update()
    {
        System.DateTime time = System.DateTime.Now;
        float seconds = time.Second;
        float minutes = time.Minute + seconds / 60f;
        float hours = time.Hour % 12 + minutes / 60f;

        secHand.transform.localRotation = Quaternion.Euler(0, 0f, -seconds * 6f);
        minHand.transform.localRotation = Quaternion.Euler(0, 0f, -minutes * 6f);
        hourHand.transform.localRotation = Quaternion.Euler(0, 0f, -hours * 30f);

    }
}
