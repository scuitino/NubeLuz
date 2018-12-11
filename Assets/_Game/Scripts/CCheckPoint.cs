using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CCheckPoint : MonoBehaviour {

    bool _isActivated;

    // art and particles
    [SerializeField, Header("Art")]
    Sprite _activatedSprite;

    [SerializeField]
    SpriteRenderer _checkPointSpriteRenderer;

    [SerializeField, Header("Particles")]
    GameObject _checkPointReachedParticle;

    // when the player touch the checkpoint
    private void OnTriggerEnter2D(Collider2D collision) {
        if (!_isActivated)
        {
            _checkPointReachedParticle.SetActive(true);
            _checkPointSpriteRenderer.sprite = _activatedSprite;
            this.GetComponent<AudioSource>().Play();
            CPlayer._instance.UpdateCheckPoint(this.transform.position);
            CPlayer._instance.Die();
            _isActivated = true;
        }        
    }
}
