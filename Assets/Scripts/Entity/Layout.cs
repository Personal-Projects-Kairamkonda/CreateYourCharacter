using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Layout : MonoBehaviour
{

    private void OnMouseDrag()
    {
        float rot = Input.GetAxis("Mouse X") * 360 * Mathf.Deg2Rad;

        transform.Rotate(Vector3.up,-rot);
    }
}
