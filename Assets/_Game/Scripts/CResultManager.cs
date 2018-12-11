using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CResultManager : MonoBehaviour {

    [SerializeField, Header("Art and Particles")]
    List<Image> _starsImages;

    [SerializeField]
    Sprite _collectedStarSprite;

    private void OnEnable()
    {
        List<bool> tCollectedStars = CLevelManager._instance.GetCollectedStars();

        for (int i = 0; i < tCollectedStars.Count; i++)
        {
            if (tCollectedStars[i] == true)
            {
                _starsImages[i].sprite = _collectedStarSprite;
            }
        }
    }
}
