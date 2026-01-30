using UnityEngine;

/// <summary>
/// OnComingCar class control the behavior of the oncoming car
/// </summary>
public class OnComingCar : MonoBehaviour
{
    public float speed = 10.0f;

    void Update() => transform.Translate(Vector3.forward * speed * Time.deltaTime);
}
