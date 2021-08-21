using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public delegate void DamagedEvent(int currentHealth);
    public static DamagedEvent damagedEvent;

    [SerializeField] public int healthPoints { get; private set; } = 5;

    public void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            healthPoints--;
        }
    }

}
