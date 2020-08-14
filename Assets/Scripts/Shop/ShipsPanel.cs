using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

sealed class ShipsPanel : MonoBehaviour
{
    [SerializeField]
    Image image;
    [SerializeField]
    GameObject bigShip;
    [SerializeField]
    GameObject midShip;
    [SerializeField]
    GameObject smallShip;
    [SerializeField]
    Sprite sprite;


    void Start ()
    {
        image.sprite = GetSprite(PlayerPrefs.GetString("Ship")) ?? sprite;
    }

    private Sprite GetSprite(string ship)
    {
        switch (ship)
        {
            case "Big":
                return bigShip.GetComponent<SpriteRenderer>().sprite;
            case "Middle":
                return midShip.GetComponent<SpriteRenderer>().sprite;
            case "Small":
                return smallShip.GetComponent<SpriteRenderer>().sprite;
            default:
                return null;
        }
    }
}
