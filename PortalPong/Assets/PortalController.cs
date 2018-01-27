using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalController : MonoBehaviour
{
    public PortalConnection Portal;
    public float HorizontalSpeed;
    public float VerticalSpeed;

    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Portal.transform.Translate(transform.up * VerticalSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            Portal.transform.Translate(transform.up * -VerticalSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            Portal.transform.Translate(transform.right * -HorizontalSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            Portal.transform.Translate(transform.right * HorizontalSpeed * Time.deltaTime);
        }
    }
}
