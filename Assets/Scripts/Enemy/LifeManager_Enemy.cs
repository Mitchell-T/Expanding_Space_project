using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeManager_Enemy : MonoBehaviour
{

    public float lives = 1;

    public void FixedUpdate()
    {
        if (lives <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
