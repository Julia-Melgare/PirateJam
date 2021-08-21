using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterSeconds : MonoBehaviour
{
    [SerializeField]
    private float delay;

    // Start is called before the first frame update
    private void Start()
    {
        Destroy(gameObject, delay + UnityEngine.Random.Range(0, delay/2f));
    }


}
