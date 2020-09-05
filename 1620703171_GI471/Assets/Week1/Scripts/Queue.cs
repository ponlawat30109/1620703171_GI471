using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Queue : MonoBehaviour
{
    public Text itemlistText;
    public List<string> item = new List<string>();
    public Sprite[] img_sprite;
    public GameObject fruitImage;

    void Start()
    {
        item.Add("Apple");
        item.Add("Orange");
        item.Add("Carrot");
        item.Add("Strawberry");
        item.Add("Banana");
    }

    void Update()
    {
        itemPrint();
        //for (int i = 0; i < item.Count; i++)
        //{
        //    fruitImage.GetComponent<Image>().sprite = img_sprite[i];
        //}
        //fruitImage.GetComponent<Image>().sprite = img_sprite[0];
    }

    void itemCheck()
    {
        itemlistText.text = "";
        for (int i = 0; i < item.Count; i++)
        {
            itemlistText.GetComponent<Text>().text += item[i] + "\n";
        }
        if (item.Count == 0)
        {
            itemlistText.text = "Item is Empty";
        }
    }
    void itemPrint()
    {
        
        itemCheck();
        if (Input.GetKeyDown(KeyCode.Return))
        {
            print(item[0]);

            for (int i = 0; i < item.Count; i++)
            {
                fruitImage.GetComponent<Image>().sprite = img_sprite[i];
            }

            if (item.Count > 0)
            {
                item.RemoveAt(0);
            }
        }

    }
}
