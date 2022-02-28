using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace CYC
{
    public class OptimizeCharacterManager : MonoBehaviour
    {
        /// <summary>
        /// The whole character data which has sprites of each body part
        /// </summary>
        public CharacterData data;

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

        /// <summary>
        /// Character Sprite Data
        /// </summary>
        public Character character = new Character();

        #region Unity Methods

        private void Start()
        {
            createCharacterButton.onClick.AddListener(CreateCharacter);
            backButton.onClick.AddListener(Back);
            SetDataIntoCharacter();
        }

        #endregion Unity Methods

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
            characterParent.localScale = Vector3.one * 1.5f;
            characterParent.localPosition = new Vector3(-10, -102, 0);
            layout.SetActive(false);
        }

        public void SetDataIntoCharacter()
        {
            character.Chest.sprite = data.bodyData[0].sprites[0];
            character.ChestButton.onClick.AddListener(NextItem);

        }

        void NextItem()
        {
            int count= data.bodyData[0].count;
            count++;
            character.Chest.sprite = data.bodyData[0].sprites[count];
        }
    }

    [System.Serializable]
    public class Character
    {
        public Image Chest;
        public Button ChestButton;
    
    }
}