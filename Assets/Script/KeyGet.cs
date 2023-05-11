using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyGet : MonoBehaviour
{
    bool _keyGet;
   public bool keyGet {
    get {
        return _keyGet;
    }
    set {
        _keyGet = false;
    }
   }
    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag =="Player" &&!_keyGet) {
            _keyGet = true;
            Destroy(gameObject);
        }
    }
}
