using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathManager : MonoBehaviour
{
    [SerializeField]
    RandomPosition randomPosition;


    /// <summary>
    /// x-axis freeze
    /// </summary>
    private bool freezeX;

    /// <summary>
    /// z-axis freeze
    /// </summary>
    private bool freezeZ;

    void Start()
    { 
        StartCoroutine(CreateShape());
    }

    /// <summary>
    /// Instantaite the shape and its position
    /// </summary>
    /// <returns></returns>
    IEnumerator CreateShape()
    {
        while (true)
        {
            GameObject temp = GameObject.CreatePrimitive(PrimitiveType.Cube);

            temp.transform.position = new Vector3(randomPosition.newX,
                                                  randomPosition.newY,
                                                  randomPosition.newZ);

            temp.transform.eulerAngles = new Vector3(0, 0, 0);

            temp.transform.SetParent(this.transform);

            temp.gameObject.name = temp.transform.position.ToString();

            freezeX = freeposition(freezeX);
            freezeZ = !freezeX;

            if (freezeX)
            {
                bool direction = ChangeDirection();

                Debug.Log("Direction: " + direction);

                if (direction)
                {
                    randomPosition.newZ++;
                    randomPosition.newZ += 0.2f;
                }
                else
                {
                    randomPosition.newZ--;
                    randomPosition.newZ -= 0.2f;
                }
            }

            if (freezeZ)
            {
                bool direction = ChangeDirection();

                Debug.Log("Direction: " + direction);

                if (direction)
                {
                    randomPosition.newX++;
                    randomPosition.newX += 0.2f;
                }
                else
                {
                    randomPosition.newX--;
                    randomPosition.newX -= 0.2f;
                }
            }

            yield return new WaitForSeconds(1.2f);
        }
    }

    /// <summary>
    /// Random freeze the position
    /// </summary>
    /// <param name="x">bool value of axis</param>
    /// <returns>random boolean </returns>
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

    /// <summary>
    /// Random boolean generator
    /// </summary>
    /// <returns> a boolean value</returns>
    bool ChangeDirection()
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

/// <summary>
/// Store random position of each axis
/// </summary>
[System.Serializable]
public class RandomPosition
{
    public float newX=0,
                 newY=0,
                 newZ=0;
}