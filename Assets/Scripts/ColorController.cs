using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorController : MonoBehaviour
{
    [SerializeField] Image bColor;

    private void Start()
    {
        bColor = bColor.GetComponent<Image>();
    }
    public void changeColor()
    {
        bColor.color = new Color(Random.RandomRange(0f,1f), Random.RandomRange(0f, 1f), Random.RandomRange(0f, 1f), 1f);
    }
}
