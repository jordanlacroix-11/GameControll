using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouselock : MonoBehaviour
{
    public float mousesens = 100f;
    public Transform palyerbody;
    float xRotation = 0f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called on  ce per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mousesens * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mousesens * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation,-90f,90f);
        transform.localRotation = Quaternion.Euler(xRotation,0f,0f);
        palyerbody.Rotate(Vector3.up * mouseX);
    }
}
