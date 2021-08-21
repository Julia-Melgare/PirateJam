using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonController : MonoBehaviour
{
    [SerializeField] private Transform cannon;
    [SerializeField] private GameObject shotPrefab;

    [SerializeField]
    private float reloadTimer;

    [SerializeField]
    private float rotateSpeed;

    private float mouseWheel;
 
    

    public void Update()
    {
        mouseWheel = Input.GetAxis("Mouse ScrollWheel");

        if (mouseWheel != 0)
        {
            Quaternion newRotation = cannon.localRotation;
            newRotation.x += mouseWheel;

            cannon.localRotation = Quaternion.Slerp(cannon.localRotation, newRotation, Time.deltaTime * rotateSpeed);
            cannon.localRotation = new Quaternion(Mathf.Clamp(cannon.localRotation.x, -0.45f, 0), cannon.localRotation.y, cannon.localRotation.z, cannon.localRotation.w);

        }

        bool fire = Input.GetMouseButtonDown(0);

        if (fire)
        {
            GameObject cannonBall = Instantiate(shotPrefab, cannon.transform.position + (cannon.transform.forward / 2.5f), Quaternion.identity);
            cannonBall.GetComponent<Rigidbody>().AddForce(cannon.transform.forward * 1000f, ForceMode.Acceleration);
        }




    }

}
