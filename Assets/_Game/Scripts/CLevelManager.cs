using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CLevelManager : MonoBehaviour {

    #region SINGLETON PATTERN
    public static CLevelManager _instance = null;
    #endregion

    private void Awake()
    {
        //singleton check
        if (_instance == null)
            _instance = this;
        else if (_instance != this)
            Destroy(gameObject);
    }

    [SerializeField, Header("Art and Particles")]
    List<Image> _starsImages;

    [SerializeField]
    Sprite _collectedStarSprite;

    [SerializeField]
    List<GameObject> _collectStarParticle;

    int _collectedStarsCount;

    // each time the player collect an star
    public void AddStar(int aStarNumber)
    {
        //_collectStarParticle[aStarNumber].SetActive(true);
        _starsImages[aStarNumber].sprite = _collectedStarSprite;
        _collectedStarsCount++;
    }
}
