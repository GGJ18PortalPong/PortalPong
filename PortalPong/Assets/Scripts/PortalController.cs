using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalController : MonoBehaviour
{
    public PortalConnection Portal;
    public float HorizontalSpeed;
    public float VerticalSpeed;
    public float MaxY;
    public float MinY;
    public float MaxX;
    public float MinX;

    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            if (Portal.transform.position.y < MaxY)
            {
                Portal.transform.Translate(transform.up * VerticalSpeed * Time.deltaTime);
            }
        }
        if (Input.GetKey(KeyCode.S))
        {
            if (Portal.transform.position.y > MinY)
            {
                Portal.transform.Translate(transform.up * -VerticalSpeed * Time.deltaTime);
            }
        }
        if (Input.GetKey(KeyCode.A))
        {
            if (Portal.transform.position.x > MinX)
            {
                Portal.transform.Translate(transform.right * -HorizontalSpeed * Time.deltaTime);
            }
        }
        if (Input.GetKey(KeyCode.D))
        {
            if (Portal.transform.position.x < MaxX)
            {
                Portal.transform.Translate(transform.right * HorizontalSpeed * Time.deltaTime);
            }
        }
    }
}
