using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject meshGenerator;

    private void Start()
    {
        CreateMesh();
    }

    public void Regenerate()
    {
        CreateMesh();
        DestroyMesh();
    }

    public void CreateMesh()
    {
        GameObject temp = Instantiate(meshGenerator, transform.position, Quaternion.identity, this.transform);
    }

    private void DestroyMesh()
    {
        GameObject previousObj = this.transform.GetChild(0).gameObject;
        Destroy(previousObj);
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
