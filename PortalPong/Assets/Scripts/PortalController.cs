using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalController : MonoBehaviour
{
    public PortalConnection MainPortal;
    public PortalConnection MirrorPortal;
    public float speed;

    private void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            MainPortal.transform.Translate(MainPortal.transform.up * speed * Time.deltaTime);
            MirrorPortal.transform.Translate(MirrorPortal.transform.up * -speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            MainPortal.transform.Translate(MainPortal.transform.up * -speed * Time.deltaTime);
            MirrorPortal.transform.Translate(MirrorPortal.transform.up * speed * Time.deltaTime);
        }
    }
}
