using UnityEngine;

public class playerCollisions : MonoBehaviour
{
    public playerCollisions movement;
    void OnCollisionEnter()
    {
        movement.enabled = false;
    }
}
