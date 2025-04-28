using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageScript : MonoBehaviour
{
    public GameObject bean;
    public GameObject teddy;
    public GameObject car;
    public GameObject lady;

    public GameObject left;
    public GameObject right;

    public void toggleBean(bool value)
    {
        bean.SetActive(value);
        left.GetComponent<Toggle>().interactable = value;
        right.GetComponent<Toggle>().interactable = value;
    }

    public void toggleTeddy(bool value)
    {
        teddy.SetActive(value);
    }

    public void toggleCar(bool value)
    {
        car.SetActive(value);
    }

    public void toggleLady(bool value)
    {
        lady.SetActive(value);
    }

    public void ToLeft()
    {
        bean.transform.localScale = new Vector2(1, 1);
    }

    public void ToRight()
    {
        bean.transform.localScale = new Vector2(-1, 1);
    }
}
