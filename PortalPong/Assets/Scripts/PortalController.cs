using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PortalController : MonoBehaviour
{
    public PortalConnection Portal;
    public float HorizontalSpeed;
    public float VerticalSpeed;
    public float MaxY;
    public float MinY;
    public float MaxX;
    public float MinX;
    public float verticalWallSpaceThreshold = 1.12f;
    public float horizontalWallSpaceThreshold = 0.6f;

    private void Update()
    {
        


        if (Input.GetKey(KeyCode.W)  && ClearUp())
        {
            //if (Portal.transform.position.y < MaxY)
            {
                Portal.transform.Translate(transform.up * VerticalSpeed * Time.deltaTime);
            }
        }
        if (Input.GetKey(KeyCode.S)  && ClearDown())
        {
            //if (Portal.transform.position.y > MinY)
            {
                Portal.transform.Translate(transform.up * -VerticalSpeed * Time.deltaTime);
            }
        }
        if (Input.GetKey(KeyCode.A)  && ClearLeft())
        {
            //if (Portal.transform.position.x > MinX)
            {
                Portal.transform.Translate(transform.right * -HorizontalSpeed * Time.deltaTime);
            }
        }
        if (Input.GetKey(KeyCode.D) && ClearRight())
        {
            //if (Portal.transform.position.x < MaxX)
            {
                Portal.transform.Translate(transform.right * HorizontalSpeed * Time.deltaTime);
            }
        }
		if (Input.GetKeyDown(KeyCode.R))
		{
			Scene loadedLevel = SceneManager.GetActiveScene();
			SceneManager.LoadScene(loadedLevel.buildIndex);
		}
    }

    bool ClearUp()
    {
        RaycastHit hit;
        Ray ray = new Ray(Portal.transform.position, transform.up);
        Physics.Raycast(ray,out hit, verticalWallSpaceThreshold);

        if (hit.collider != null)
        {
            if (hit.collider.gameObject.tag.Equals("Wall"))
            {
                return false;
            }
        }
        
        return true;
    }

    bool ClearDown()
    {
        RaycastHit hit;
        Ray ray = new Ray(Portal.transform.position, transform.up * -1);
        Physics.Raycast(ray, out hit, verticalWallSpaceThreshold);

        if (hit.collider != null)
        {
            if (hit.collider.gameObject.tag.Equals("Wall"))
            {
                return false;
            }
        }
        return true;
    }

    bool ClearLeft()
    {
        RaycastHit hit;
        Ray ray = new Ray(Portal.transform.position, transform.right * -1);
        Physics.Raycast(ray, out hit, horizontalWallSpaceThreshold);

        if (hit.collider != null)
        {
            if (hit.collider.gameObject.tag.Equals("Wall"))
            {
                return false;
            }
        }
        return true;
    }

    bool ClearRight()
    {
        RaycastHit hit;
        Ray ray = new Ray(Portal.transform.position, transform.right);
        Physics.Raycast(ray, out hit, horizontalWallSpaceThreshold);

        if (hit.collider != null)
        {
            if (hit.collider.gameObject.tag.Equals("Wall"))
            {
                return false;
            }
        }
        return true;
    }


}
