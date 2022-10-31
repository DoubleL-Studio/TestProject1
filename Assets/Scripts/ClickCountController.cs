using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickCountController : MonoBehaviour
{
    [SerializeField] Text countText;
    private int countClick = 0;

    public void AddClick()
    {
        countClick++;
        countText.text = "-- " + countClick.ToString() + " --";
    }
}
