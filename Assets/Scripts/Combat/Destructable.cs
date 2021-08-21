using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class Destructable : MonoBehaviour
{

    [SerializeField] private GameObject destructablePrefab;

    private bool hit = false;

    private void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (hit) return;

        if (collision.gameObject.CompareTag("Player") || collision.gameObject.CompareTag("CannonBall"))
        {
            hit = true;
            var d = Instantiate(destructablePrefab, transform.position, transform.rotation * destructablePrefab.transform.rotation);
            d.transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y + 1, transform.localScale.z);
            Destroy(gameObject);
        }

      
    }


}
