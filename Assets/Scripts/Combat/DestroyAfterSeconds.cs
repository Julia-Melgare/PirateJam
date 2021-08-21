using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterSeconds : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 2f + UnityEngine.Random.Range(0, 1f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
