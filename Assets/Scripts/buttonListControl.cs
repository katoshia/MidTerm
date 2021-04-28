// created by Katoshia Grubb 4-28-21

// script used to store names of places and the number of options(buttons) that are needed as well as populate them into the game menu.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonListControl : MonoBehaviour
{
    [SerializeField]
    private GameObject ButtonTemplate;

    [SerializeField]
    private int[] intArray;

    private List<GameObject> buttons;



    private void Start()
    {
        //for(int i =1;i<=20;i++)
        foreach (int i in intArray)
        {
            GameObject button = Instantiate(ButtonTemplate) as GameObject;
            button.SetActive(true);

            button.GetComponent<ButtonListButton>().SetText("button #" + i);

            button.transform.SetParent(ButtonTemplate.transform.parent, false);
        }
    }
    public void UpdateGameScene()
    {
        if
    }

    public void ButtoClicked(string myTextString)
    {
        Debug.Log(myTextString);
    }

    //public void GenerateList()
    //{
    //    if (buttons.Count > 0)
    //    {
    //        foreach (GameObject button in buttons)
    //        {
    //            Destroy(button.gameObject);
    //        }
    //        buttons.Clear();
    //    }
    //}
}
