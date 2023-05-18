using UnityEngine;

public class PlayerCollions : MonoBehaviour
{
    public PlayerCollions movement;
    void OnCollisionEnter2D() {
        movement.enabled = false;
    }
}
