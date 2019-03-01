using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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

    [SerializeField, Header("Panels")]
    GameObject _resultPanel;

    // placeholder
    [SerializeField]
    int _actualLevel;
    [SerializeField]
    int _nextScene;

    [SerializeField, Header("Art and Particles")]
    List<Image> _starsImages;

    [SerializeField]
    Sprite _collectedStarSprite;

    [SerializeField, Header("Collectibles")]
    List<bool> _collectedStars;

    private void Start()
    {
        for (int i = 0; i < _collectedStars.Count; i++)
        {
            _collectedStars[i] = false;
        }
    }

    // each time the player collect an star
    public void AddStar(int aStarNumber)
    {
        _starsImages[aStarNumber].sprite = _collectedStarSprite;
        _collectedStars[aStarNumber] = true;
    }

    // return stars result
    public List<bool> GetCollectedStars()
    {
        return _collectedStars;
    }

    // pause the game
    public void FinishGame()
    {
        Time.timeScale = 0;
        _resultPanel.SetActive(true);
    }

    // unpause the game
    public void GoNextScene()
    {
        Time.timeScale = 1;
        _resultPanel.SetActive(false);
        SceneManager.LoadScene(_nextScene);
    }

    // restart Level
    public void RestartScene()
    {
        Time.timeScale = 1;
        _resultPanel.SetActive(false);
        SceneManager.LoadScene(_actualLevel);
    }
}
