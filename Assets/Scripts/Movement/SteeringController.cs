using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SteeringController : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    private List<GameObject> sails;

    [SerializeField]
    private float rotationSpeed;

    private float input;
    private float inputSpeed = 2f;
    private float sailRotation;

    private void FixedUpdate()
    {



        transform.GetComponent<Rigidbody>().AddRelativeTorque(0, sailRotation / rotationSpeed, 0, ForceMode.Acceleration);

    }

    // Update is called once per frame
    void Update()
    {

        input = Input.GetAxis("Horizontal") / inputSpeed;

        Vector3 myRotation = Vector3.zero;

        foreach (var item in sails)
        {
            item.transform.Rotate(0, input, 0);

            myRotation = item.transform.localRotation.eulerAngles;

            if (myRotation.y > 180) myRotation.y -= 360f;

            myRotation.y = Mathf.Clamp(myRotation.y, -45f, 45f);


            item.transform.localRotation = Quaternion.Euler(myRotation);
        }

        sailRotation = myRotation.y;

    }
}
