using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public delegate void DamagedEvent(float currentHealth);
    public static DamagedEvent damagedEvent;
    public delegate void OnEndLevel(bool win);
    public static event OnEndLevel onEndLevel;

    [SerializeField] public float healthPoints { get; private set; } = 5;
    public static float maxHealth = 5;

    public void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            collision.gameObject.GetComponent<AudioSource>().Play();
            healthPoints--;
            damagedEvent?.Invoke(healthPoints);
            if (healthPoints <= 0)
            {
                onEndLevel?.Invoke(false);
            }

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Finish"))
        {
            onEndLevel?.Invoke(true);
        }
            

    }

}
