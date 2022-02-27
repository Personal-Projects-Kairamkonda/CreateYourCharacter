using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptimizeCharacterManager : MonoBehaviour
{
    /// <summary>
    /// Character parent
    /// </summary>
    public Transform characterParent;

    /// <summary>
    /// Character button
    /// </summary>
    public Button createCharacterButton;

    /// <summary>
    /// Back button
    /// </summary>
    public Button backButton;

    /// <summary>
    /// Layout parent
    /// </summary>
    public GameObject layout;

    private void Start()
    {
        createCharacterButton.onClick.AddListener(CreateCharacter);
        backButton.onClick.AddListener(Back);
    }

    /// <summary>
    /// This function creates character 
    public void CreateCharacter()
    {
        characterParent.localScale = Vector3.one * 0.8f;
        characterParent.localPosition = Vector3.zero;
        characterParent.localPosition = new Vector3(-650f, 0, 0);
        layout.SetActive(true);
    }

    /// <summary>
    /// This function gives ability to edit the character
    /// </summary>
    public void Back()
    {
        characterParent.localScale = Vector3.one*1.5f;
        characterParent.localPosition = new Vector3(-10, -102, 0);
        layout.SetActive(false);
    }
}
