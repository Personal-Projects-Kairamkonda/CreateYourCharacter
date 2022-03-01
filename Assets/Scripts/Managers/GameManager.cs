using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject meshGenerator;

    private void Start()
    {
        GameObject temp = Instantiate(meshGenerator, transform.position, Quaternion.identity, this.transform);
    }

    public void Regenerate()
    {
        GameObject previousObj = this.transform.GetChild(0).gameObject;
        Destroy(previousObj);

        GameObject temp = Instantiate(meshGenerator, transform.position, Quaternion.identity, this.transform);
    }
}
