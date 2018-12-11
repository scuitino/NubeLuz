using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DigitalRubyShared;

public class CFinishHole : MonoBehaviour {

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(FingersScript.Instance.gameObject);
        CLevelManager._instance.FinishGame();
    }
}
