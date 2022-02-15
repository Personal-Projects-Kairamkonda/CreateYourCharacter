using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathManager : MonoBehaviour
{
    [SerializeField]
    RandomPosition randomPosition;

    private bool freezeX;
    private bool freezeZ;

    void Start()
    { 
        StartCoroutine(CreateShape());
    }

    IEnumerator CreateShape()
    {
        while (true)
        {
            GameObject temp = GameObject.CreatePrimitive(PrimitiveType.Cube);

            //if(randomPosition.newX)

            temp.transform.position = new Vector3(randomPosition.newX,
                                                  randomPosition.newY,
                                                  randomPosition.newZ);

            temp.transform.eulerAngles = new Vector3(0, 0, 0);
            temp.transform.SetParent(this.transform);

            freezeX = freeposition(freezeX);
            freezeZ = !freezeX;

            if (freezeX)
            {
                randomPosition.newZ++;
                randomPosition.newZ += 0.2f;
            }

            if (freezeZ)
            {
                randomPosition.newX++;
                randomPosition.newX += 0.2f;
            }

            

            yield return new WaitForSeconds(2f);
        }
    }

    bool freeposition(bool x)
    {
        int value = Random.Range(0, 2);

        if (value == 0)
        {
            return true;
        }
        else
        {
            return false;
        }

    }
}

[System.Serializable]
public class RandomPosition
{
    public float newX=0,
                 newY=0,
                 newZ=0;
}