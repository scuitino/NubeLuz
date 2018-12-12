using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CEnemy : MonoBehaviour {

    [SerializeField, Header("Art")]
    Transform _artObjects;

    // flip the enemy art
    public void FlipEnemy()
    {
        if (_artObjects.transform.localScale.x == 1)
        {
            _artObjects.transform.localScale = new Vector3(-1, 1, 1);
        }
        else
        {
            _artObjects.transform.localScale = new Vector3(1, 1, 1);
        }
    }
}
