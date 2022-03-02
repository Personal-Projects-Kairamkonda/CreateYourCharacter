using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject meshGenerator;

    public void Regenerate()
    {
        GameObject previousObj = this.transform.GetChild(0).gameObject;
        Destroy(previousObj);

        GameObject temp = Instantiate(meshGenerator, transform.position, Quaternion.identity, this.transform);
    }


    public void Isometric()
    {
        Camera.main.transform.position = new Vector3(-50, 40, -50);
        Camera.main.transform.localEulerAngles = new Vector3(30, 45, 0);
        Camera.main.orthographicSize = 10f;
    }

    public void TopView()
    {
        Camera.main.transform.position = new Vector3(0, 10, 0);
        Camera.main.transform.localEulerAngles = new Vector3(90, 0, 0);
        Camera.main.orthographicSize = 25f;
    }
}
