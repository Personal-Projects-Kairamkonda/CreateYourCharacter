using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptimizeCharacterManager : MonoBehaviour
{
   public Transform characterParent;

    public Button createCharacterButton;

    public Button backButton;

    private void Start()
    {
        createCharacterButton.onClick.AddListener(CreateCharacter);
        backButton.onClick.AddListener(Back);
    }

    public void CreateCharacter()
    {
        characterParent.localScale = Vector3.one * 0.8f;
        characterParent.localPosition = Vector3.zero;
        characterParent.localPosition = new Vector3(-650f, 0, 0);
    }

    public void Back()
    {
        characterParent.localScale = Vector3.one*1.5f;
        characterParent.localPosition = new Vector3(-10, -102, 0);
    }
}
