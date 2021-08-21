using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SteeringController : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    private List<GameObject> sails;

    // Update is called once per frame
    void Update()
    {
        var horizontal = Input.GetAxis("Horizontal");
        transform.GetComponent<Rigidbody>().AddRelativeTorque(0, horizontal, 0, ForceMode.Acceleration);

        foreach (var item in sails)
        {



            item.transform.Rotate(0,horizontal,0);

            Vector3 myRotation = item.transform.localRotation.eulerAngles;

            if (myRotation.y > 180) myRotation.y -= 360f;

            myRotation.y = Mathf.Clamp(myRotation.y, -45f, 45f);

            Debug.Log(myRotation.y);

            item.transform.localRotation = Quaternion.Euler(myRotation);
        }

    }
}
