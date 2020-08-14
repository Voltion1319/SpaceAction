using System.Collections;
using System.Collections.Generic;
using UnityEngine;

sealed class SpawnStars : MonoBehaviour {

    [SerializeField]
    private GameObject star;
    [SerializeField]
    private float z;  //axe z

    void Start () {

        StartCoroutine(Spawn());
	}

    IEnumerator Spawn()
    {
        while (true)
        {
            Vector3 pos = Camera.main.ScreenToWorldPoint(new Vector3(Random.Range(0,Screen.width),Random.Range(0,Screen.height), z));
            Instantiate(star, pos, Quaternion.identity);
            yield return new WaitForSeconds(1f);
        }
    }

}
