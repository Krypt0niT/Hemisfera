using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed = 0.125f;
    public Vector3 offset;
    public float CameraZoomSpeed = 10;

    private void LateUpdate()
    {
        if (target.gameObject.GetComponent<Player>().usingWeapons)
        {
            if (this.gameObject.GetComponent<Camera>().orthographicSize < 10)
            {
                this.gameObject.GetComponent<Camera>().orthographicSize += Time.deltaTime * CameraZoomSpeed;
            }
  
        }
        else
        {
            if (this.gameObject.GetComponent<Camera>().orthographicSize > 5)
            {
                this.gameObject.GetComponent<Camera>().orthographicSize -= Time.deltaTime * CameraZoomSpeed;
            }
        }

        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
        transform.position = smoothPosition;   
    }
}
