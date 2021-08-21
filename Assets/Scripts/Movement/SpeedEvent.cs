using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class SpeedEvent : MonoBehaviour
{

    public Vector3 force { get; private set;}
    [SerializeField]
    private float speed;

    public void Awake()
    {
        force = transform.forward * speed;
    }



}
