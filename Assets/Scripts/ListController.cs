using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ListController : MonoBehaviour
{
    [SerializeField] private List<Sprite> AllImage = new List<Sprite>();
    [SerializeField] private Transform Content;
    [SerializeField] private GameObject PrefubItem;
    private GameObject Item;

    private void Start()
    {
        CreateList();
    }

    private void CreateList()
    {
        foreach (Sprite image in AllImage)
        {
            Item = Instantiate(PrefubItem, Content);
            Item.GetComponent<Image>().sprite = image;
        }
    }
}
