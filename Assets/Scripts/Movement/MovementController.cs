using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class MovementController : MonoBehaviour
{
    // Start is called before the first frame update
    private new Rigidbody rigidbody;

    public Vector3 movementForce;

    public float buoyancy;
    public float windSpeed;


    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        
    }

    private void Update()
    {
        Debug.DrawLine(transform.position, transform.position + movementForce);
    }


    // Update is called once per frame
    void FixedUpdate()
    {

        if(transform.position.y < 0f)
        {
            float displacementMult = Mathf.Clamp01(-transform.position.y) * (buoyancy + UnityEngine.Random.Range(0,0.25f));
            rigidbody.AddForce(Vector3.up * Mathf.Abs(Physics.gravity.y) * displacementMult, ForceMode.Acceleration);
        }


        //Vector3 buoyancyForce = Vector3.up * buoyancy;

        //Vector3 boyTorque = transform.right * buoyancy * Mathf.Sin(Time.time);
        movementForce = transform.forward * 100f;

        rigidbody.AddForce(Vector3.ProjectOnPlane(movementForce, Vector3.up));
        ///rigidbody.AddTorque(boyTorque);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "SpeedUp")
            movementForce = other.GetComponent<SpeedEvent>().force;
    }
}
