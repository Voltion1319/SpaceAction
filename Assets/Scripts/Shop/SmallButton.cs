using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

sealed class SmallButton : MonoBehaviour
{
    [SerializeField]
    Image image;
    [SerializeField]
    GameObject bigShip;
    [SerializeField]
    GameObject midShip;
    [SerializeField]
    GameObject smallShip;

    private void OnMouseUpAsButton()
    {
        switch (gameObject.name)
        {
            case "BigButton":
                image.GetComponent<Image>().sprite = bigShip.GetComponent<SpriteRenderer>().sprite;
                PlayerPrefs.SetString("Ship", "Big");
                break;
            case "MiddleButton":
                image.GetComponent<Image>().sprite = midShip.GetComponent<SpriteRenderer>().sprite;
                PlayerPrefs.SetString("Ship", "Middle");
                break;
            case "SmallButton":
                image.GetComponent<Image>().sprite = smallShip.GetComponent<SpriteRenderer>().sprite;
                PlayerPrefs.SetString("Ship", "Small");
                break;
        }
        
    }

    private void ShowBig()
    {
        
    }
}
