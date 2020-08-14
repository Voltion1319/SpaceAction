using System.Collections;
using System.Collections.Generic;
using UnityEngine;

sealed class HealthBar : MonoBehaviour {

    public void Changehp(float hp)
    {
        transform.localScale = new Vector3(hp,1,1);
    }
}
