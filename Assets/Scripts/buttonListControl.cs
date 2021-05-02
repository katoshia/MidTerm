// created by Katoshia Grubb 4-28-21

// script used to store names of places and the number of options(buttons) that are needed as well as populate them into the game menu.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonListControl : MonoBehaviour
{
    public Image img;
    public GameObject myButtonList;
    public Transform buttonContainer;
    public string storyText;
    public List<GameObject> allButtons = new List<GameObject>();

    [SerializeField]
    private GameObject ButtonTemplate;

    [SerializeField]
    private int[] intArray;

    [SerializeField]
    private string inGameText;



    // GameScene start for buttons shown.
    private void Start()
    {
        for(int i =0;i<=2;i++)
        {
            GameObject button;
            if (i == 0)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);

                button.GetComponent<ButtonListButton>().SetText("The Lake");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);

                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(()=> OnButtonClick(tempName));
                allButtons.Add(button);

            }
            else if (i == 1)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("The Main Hall");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                allButtons.Add(button);

            }
            else if (i == 2)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("The Gardens");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                allButtons.Add(button);

            }
        }
    }

    public void OnButtonClick(string theName)
    {
        //DeleteDynamicButtons();
        if (theName == "The Lake")
        {
            DeleteDynamicButtons();

            for (int i = 0; i <= 3; i++)
            {
                GameObject button;
                if (i == 0)
                {
                    button = Instantiate(ButtonTemplate) as GameObject;
                    button.SetActive(true);

                    button.GetComponent<ButtonListButton>().SetText("Mardi Gras");
                    button.transform.SetParent(ButtonTemplate.transform.parent, false);

                }
                else if (i == 1)
                {
                    button = Instantiate(ButtonTemplate) as GameObject;
                    button.SetActive(true);
                    button.GetComponent<ButtonListButton>().SetText("Laundry");
                    button.transform.SetParent(ButtonTemplate.transform.parent, false);

                }
                else if (i == 2)
                {
                    button = Instantiate(ButtonTemplate) as GameObject;
                    button.SetActive(true);
                    button.GetComponent<ButtonListButton>().SetText("Hello");
                    button.transform.SetParent(ButtonTemplate.transform.parent, false);

                }
                else if (i == 3)
                {
                    button = Instantiate(ButtonTemplate) as GameObject;
                    button.SetActive(true);
                    button.GetComponent<ButtonListButton>().SetText("Hello");
                    button.transform.SetParent(ButtonTemplate.transform.parent, false);
                }
            }
            Debug.Log(theName);
        }
    }

    public void DeleteDynamicButtons()
    {
        foreach(GameObject button in allButtons)
        {
            Destroy(button);
        }
        allButtons.Clear();

    }
    public void ButtoClicked(string myTextString)
    {
        Debug.Log(myTextString);
    }


}
