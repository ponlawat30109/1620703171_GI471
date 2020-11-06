using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopManager : MonoBehaviour
{
    public Text coinText;
    public Text[] ItemName;
    public Text[] priceText;
    public Image[] ItemImage;
    public Text[] itemStock;
    public Button[] btn;

    public GameObject[] panel;

    //public Text ItemName1, ItemName2, ItemName3, ItemName4, ItemName5, ItemName6, ItemName7, ItemName8, ItemName9, ItemName10;
    //public Text priceText1, priceText2, priceText3, priceText4, priceText5, priceText6, priceText7, priceText8, priceText9, priceText10;
    public int money;

    [System.Serializable]
    public class Item
    {
        public string itemName;
        public Sprite itemImg;
        public int itemPrice;
        public int stock;

        private static Item instance;
        public Item(string itemName, Sprite itemImg, int itemPrice, int stock)
        {
            this.itemName = itemName;
            this.itemImg = itemImg;
            this.itemPrice = itemPrice;
            this.stock = stock;
        }
    }
    public List<Item> itemData = new List<Item>();


    void Start()
    {
        for (var i = 0; i<10;i++)
        {
            ItemName[i].text = "" + itemData[i].itemName;
            priceText[i].text = "" + itemData[i].itemPrice;
            ItemImage[i].sprite = itemData[i].itemImg;
            itemStock[i].text = "" + itemData[i].stock;
        }

        OnButtonClick();
    }

    void Update()
    {
        coinUpdate();
        StockCheck();
    }

    void OnButtonClick()
    {
        btn[0].GetComponent<Button>().onClick.AddListener(BuyMethod0);
        btn[1].GetComponent<Button>().onClick.AddListener(BuyMethod1);
        btn[2].GetComponent<Button>().onClick.AddListener(BuyMethod2);
        btn[3].GetComponent<Button>().onClick.AddListener(BuyMethod3);
        btn[4].GetComponent<Button>().onClick.AddListener(BuyMethod4);
        btn[5].GetComponent<Button>().onClick.AddListener(BuyMethod5);
        btn[6].GetComponent<Button>().onClick.AddListener(BuyMethod6);
        btn[7].GetComponent<Button>().onClick.AddListener(BuyMethod7);
        btn[8].GetComponent<Button>().onClick.AddListener(BuyMethod8);
        btn[9].GetComponent<Button>().onClick.AddListener(BuyMethod9);
        btn[10].GetComponent<Button>().onClick.AddListener(Panel1);
        btn[11].GetComponent<Button>().onClick.AddListener(Panel2);
        btn[12].GetComponent<Button>().onClick.AddListener(Panel3);
    }

    void BuyMethod0()
    {
        if (money >= itemData[0].itemPrice)
        {
            if (itemData[0].stock >= 1)
            {
                money -= itemData[0].itemPrice;
                itemData[0].stock -= 1;
                print(money);
                panel[0].SetActive(true);
            }
            else
            {
                print("error");
                panel[1].SetActive(true);
            }
        }
        else
        {
            print("error");
            panel[2].SetActive(true);
        }
    }

    void BuyMethod1()
    {
        if (money >= itemData[1].itemPrice)
        {
            if (itemData[1].stock >= 1)
            {
                money -= itemData[1].itemPrice;
                itemData[1].stock -= 1;
                print(money);
                panel[0].SetActive(true);
            }
            else
            {
                print("error");
                panel[1].SetActive(true);
            }
        }
        else
        {
            print("error");
            panel[2].SetActive(true);
        }
    }

    void BuyMethod2()
    {
        if (money >= itemData[2].itemPrice)
        {
            if (itemData[2].stock >= 1)
            {
                money -= itemData[2].itemPrice;
                itemData[2].stock -= 1;
                print(money);
                panel[0].SetActive(true);
            }
            else
            {
                print("error");
                panel[1].SetActive(true);
            }
        }
        else
        {
            print("error");
            panel[2].SetActive(true);
        }
    }

    void BuyMethod3()
    {
        if (money >= itemData[3].itemPrice)
        {
            if (itemData[3].stock >= 1)
            {
                money -= itemData[3].itemPrice;
                itemData[3].stock -= 1;
                print(money);
                panel[0].SetActive(true);
            }
            else
            {
                print("error");
                panel[1].SetActive(true);
            }
        }
        else
        {
            print("error");
            panel[2].SetActive(true);
        }
    }

    void BuyMethod4()
    {
        if (money >= itemData[4].itemPrice)
        {
            if (itemData[4].stock >= 1)
            {
                money -= itemData[4].itemPrice;
                itemData[4].stock -= 1;
                print(money);
                panel[0].SetActive(true);
            }
            else
            {
                print("error");
                panel[1].SetActive(true);
            }
        }
        else
        {
            print("error");
            panel[2].SetActive(true);
        }
    }

    void BuyMethod5()
    {
        if (money >= itemData[5].itemPrice)
        {
            if (itemData[5].stock >= 1)
            {
                money -= itemData[5].itemPrice;
                itemData[5].stock -= 1;
                print(money);
                panel[0].SetActive(true);
            }
            else
            {
                print("error");
                panel[1].SetActive(true);
            }
        }
        else
        {
            print("error");
            panel[2].SetActive(true);
        }
    }

    void BuyMethod6()
    {
        if (money >= itemData[6].itemPrice)
        {
            if (itemData[6].stock >= 1)
            {
                money -= itemData[6].itemPrice;
                itemData[6].stock -= 1;
                print(money);
                panel[0].SetActive(true);
            }
            else
            {
                print("error");
                panel[1].SetActive(true);
            }
        }
        else
        {
            print("error");
            panel[2].SetActive(true);
        }
    }

    void BuyMethod7()
    {
        if (money >= itemData[7].itemPrice)
        {
            if (itemData[7].stock >= 1)
            {
                money -= itemData[7].itemPrice;
                itemData[7].stock -= 1;
                print(money);
                panel[0].SetActive(true);
            }
            else
            {
                print("error");
                panel[1].SetActive(true);
            }
        }
        else
        {
            print("error");
            panel[2].SetActive(true);
        }
    }

    void BuyMethod8()
    {
        if (money >= itemData[8].itemPrice)
        {
            if (itemData[8].stock >= 1)
            {
                money -= itemData[8].itemPrice;
                itemData[8].stock -= 1;
                print(money);
                panel[0].SetActive(true);
            }
            else
            {
                print("error");
                panel[1].SetActive(true);
            }
        }
        else
        {
            print("error");
            panel[2].SetActive(true);
        }
    }

    void BuyMethod9()
    {
        if (money >= itemData[9].itemPrice)
        {
            if (itemData[9].stock >= 1)
            {
                money -= itemData[9].itemPrice;
                itemData[9].stock -= 1;
                print(money);
                panel[0].SetActive(true);
            }
            else
            {
                print("error");
                panel[1].SetActive(true);
            }
        }
        else
        {
            print("error");
            panel[2].SetActive(true);
        }
    }

    void Panel1()
    {
        panel[0].SetActive(false);
    }

    void Panel2()
    {
        panel[1].SetActive(false);
    }

    void Panel3()
    {
        panel[2].SetActive(false);
    }

    void coinUpdate()
    {
        coinText.text = "" + money;
    }

    void StockCheck()
    {
        for (var i = 0; i < 10; i++) { 
            itemStock[i].text = "" + itemData[i].stock; 
        }
    }
}