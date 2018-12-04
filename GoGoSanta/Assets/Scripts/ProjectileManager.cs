using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileManager : MonoBehaviour {

    // Destroy projectile object after 5 seconds
    void Awake()
    {
        Destroy(this.gameObject, 5f);
    }
}
