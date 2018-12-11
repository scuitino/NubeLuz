using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CStar : MonoBehaviour {

    [SerializeField]
    int _starNumber;

    [SerializeField, Header("Particles")]
    GameObject _collectParticlePrefab;

    // when the player touch the star
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Instantiate(_collectParticlePrefab, transform.position, Quaternion.identity);
        CLevelManager._instance.AddStar(_starNumber);
        Destroy(this.gameObject);
    }
}
