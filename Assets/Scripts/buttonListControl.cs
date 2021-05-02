// created by Katoshia Grubb 4-28-21

// script used to store names of places and the number of options(buttons) that are needed as well as populate them into the game menu.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonListControl : MonoBehaviour
{
    public GameObject myButtonList;
    public string storyText;
    public List<GameObject> allButtons = new List<GameObject>();

    [SerializeField]
    public GameObject ButtonTemplate;

    [SerializeField]
    private GameObject TextTemplate;

    [SerializeField]
    private int[] intArray;

    [SerializeField]
    private string inGameText;



    // GameScene start for buttons shown. 1st runthough.
    private void Start()
    {
        PrintIntro();
        StartButtons();
        //GameObject textStory;
        
        //GameObject textStory = Instantiate(TextTemplate) as GameObject ;
        //textStory.SetActive(true);
        //textStory.GetComponent<ButtonListButton>().SetText("let's try this out.");
        //textStory.transform.SetParent(TextTemplate.transform.parent, false);

        //for (int i = 0; i <= 2; i++)
        //{
            //GameObject textStory = Instantiate(TextTemplate) as GameObject;
            //ChangeText(textStory);
            //textStory = Instantiate(TextTemplate) as GameObject;
            //textStory.SetActive(true);
            //textStory.GetComponent<ButtonListButton>().SetText("let's try this out.");
            //textStory.transform.SetParent(TextTemplate.transform.parent, false);

            //GameObject button;
            //GameObject textStory;
            //if (i == 0)
            //{
            //   // DeleteDynamicText(textStory);
            //    textStory = Instantiate(TextTemplate) as GameObject;
            //    textStory.SetActive(true);
            //    textStory.GetComponent<ButtonListButton>().SetText("let's try this out.");
            //    textStory.transform.SetParent(TextTemplate.transform.parent, false);

            //    button = Instantiate(ButtonTemplate) as GameObject;
            //    button.SetActive(true);

            //    button.GetComponent<ButtonListButton>().SetText("Lake");
            //    button.transform.SetParent(ButtonTemplate.transform.parent, false);

            //    string tempName = button.GetComponentInChildren<Text>().text;
            //    button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 2));
            //    allButtons.Add(button);

            //}
            //else if (i == 1)
            //{
            //    button = Instantiate(ButtonTemplate) as GameObject;
            //    button.SetActive(true);
            //    button.GetComponent<ButtonListButton>().SetText("Main Hall");
            //    button.transform.SetParent(ButtonTemplate.transform.parent, false);
            //    string tempName = button.GetComponentInChildren<Text>().text;
            //    button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 2));
            //    allButtons.Add(button);

            //}
            //else if (i == 2)
            //{
            //    button = Instantiate(ButtonTemplate) as GameObject;
            //    button.SetActive(true);
            //    button.GetComponent<ButtonListButton>().SetText("Gardens");
            //    button.transform.SetParent(ButtonTemplate.transform.parent, false);
            //    string tempName = button.GetComponentInChildren<Text>().text;
            //    button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 5));
            //    allButtons.Add(button);

            //}
        //}
    }
    public void DeleteDynamicText()
    {
        //GameObject textStory = GameObject.Find("StoryText(Clone)");
        Destroy(GameObject.Find("StoryText(Clone)"));
        //GameObject.Destroy(textStory);
    }
    public void DeleteDynamicText(GameObject textStory)
    {
        string tempName = textStory.GetComponent<Text>().name;
        if(tempName == "StoryText(Clone)")
        {
            Destroy(textStory);
        }
    }
    public void ChangeText(string myText)
    {
        GameObject textStory;

        textStory = Instantiate(TextTemplate) as GameObject;
        DeleteDynamicText(textStory);
        textStory.SetActive(true);
        textStory.GetComponent<ButtonListButton>().SetText(myText);

       // textStory.GetComponent<ButtonListButton>().SetText("Hello World,,,,dkdfhpaidhfaskdjfoipahpahfgahfafhio");
        textStory.transform.SetParent(TextTemplate.transform.parent, false);
    }
    public void OnButtonClick(string theName, int optionCount)
    {
        DeleteDynamicButtons();
        
        if (theName == "Estate")
        {
            EstateButton(optionCount);
        }
        else if (theName == "Lake")
        {
            LakeButton(optionCount);
        }
        else if(theName=="Back Woods"|| theName=="Forest")
        {
            BackWoods(optionCount);
        }
        else if(theName == "Crypt")
        {
            Crypt(optionCount);
        }
        else if (theName == "Inner Crypt")
        {
            InnerCrypt(optionCount);
        }
        else if (theName == "Search Coffins")
        {
            SearchCoffins(optionCount);
        }
        else if (theName == "Gardens")
        {
            Gardens(optionCount);
        }
        else if (theName == "Main Entry")
        {
            MainEntryHall(optionCount);
            PrintMainEntry();
        }
        else if(theName == "Go Outside")
        {
            PrintGoOutside();
        }
        else if (theName == "Explore Main Entry")
        {
            ExploreMainEntry(optionCount);
        }
        else if (theName == "Main Hall")
        {
            MainEntryHall(optionCount);
            //MainHallway(optionCount);
            PrintMainEntry();
        }
        else if (theName == "Trophy Room")
        {
            Trophy(optionCount);
        }
        else if (theName == "Explore Trophy Room")
        {
            ExploreTrophy(optionCount);
        }
        else if (theName == "Library")
        {
            Library(optionCount);
        }
        else if (theName == "Explore Library")
        {
            ExploreLibrary(optionCount);
        }
        else if (theName == "Read a book.")
        {
            ReadLibraryBook(optionCount);
        }
        else if (theName == "Bathroom")
        {
            Bathroom(optionCount);
        }
        else if (theName == "Secret Library Room")
        {
            SecretLibraryRoom(optionCount);
        }
        else if (theName == "Explore Secret Room")
        {
            ExploreSecrectLibrary(optionCount);
        }
        else if (theName == "Sitting Room")
        {
            SittingRoom(optionCount);
        }
        else if (theName == "Dining Room")
        {
            DiningRoom(optionCount);
        }
        else if (theName == "Explore Dining Room")
        {
            ExploreDiningRoom(optionCount);
        }
        else if (theName == "Kitchen")
        {
            Kitchen(optionCount);
        }
        else if (theName == "Explore Kitchen")
        {
            ExploreKitchen(optionCount);
        }
        else if (theName == "Take brownie")
        {
            TakeBrownie(optionCount);
        }
        else if (theName == "Pantry")
        {
            Pantry(optionCount);
        }
        else if (theName == "Explore Pantry")
        {
            ExplorePantry(optionCount);
        }
        else if (theName == "Pull Lever")
        {
            PullLever(optionCount);
        }
        else if (theName == "Small hallway")
        {
            SmallHallway(optionCount);
        }
        else if (theName == "Pool Room")
        {
            PoolRoom(optionCount);
        }
        else if (theName == "Explore Pool Room")
        {
            ExplorePoolRoom(optionCount);
        }
        else if (theName == "Treasure Room")
        {
            TreasureRoom(optionCount);
        }
        else if (theName == "Explore Treasure Room")
        {
            ExploreTreasureRoom(optionCount);
        }
        else if (theName == "Second Floor")
        {
            SecondFloor(optionCount);
        }
        else if (theName == "First Hallway")
        {
            FirstHallway(optionCount);
        }
        else if (theName == "Second Hallway")
        {
            SecondHallway(optionCount);
        }
        else if (theName == "Explore the Hallway")
        {
            ExploreSecondHallway(optionCount);
        }
        else if (theName == "Push the button")
        {
            PushButton(optionCount);
        }
        else if (theName == "Master Bedroom")
        {
            MasterBedroom(optionCount);
        }
        else if (theName == "Explore Master Bedroom")
        {
            ExploreMasterBedroom(optionCount);
        }
        else if (theName == "Read the Book")
        {
            ReadBedroomBook(optionCount);
        }
        else if (theName == "Large closet")
        {
            MasterCloset(optionCount);
        }
        else if (theName == "Statue Room")
        {
            StatueRoom(optionCount);
        }
        else if (theName == "Guest Room")
        {
            GuestRoom(optionCount);
        }
        else if (theName == "Explore Guest Room")
        {
            ExploreGuestRoom(optionCount);
        }
        else if (theName == "Small Closet")
        {
            GuestCloset(optionCount);
        }
        else if (theName == "Explore the closet.")
        {
            ExploreGuestCloset(optionCount);
        }
        else if (theName == "Roayl Room")
        {
            RoyalRoom(optionCount);
        }
        else if (theName == "Servant's Hall")
        {
            ServantsHall(optionCount);
        }
        else if (theName == "Servant's Quarters")
        {
            ServantsQuarters(optionCount);
        }
        else if (theName == "Servant's Bathroom")
        {
            ServantsBathroom(optionCount);
        }
        else if (theName == "Mirror Room")
        {
            MirrorRoom(optionCount);
        }
        else if (theName == "Attic ")
        {
            AtticRoom(optionCount);
        }
        else if (theName == "Second Attic Room")
        {
            SecondAtticRoom(optionCount);
        }
        else if (theName == "Explore Second Room")
        {
            ExploreSecondAtticRoom(optionCount);
        }
        else if (theName == "Storage")
        {
            Storage(optionCount);
        }
    }

    public void DeleteDynamicButtons()
    {
        foreach (GameObject button in allButtons)
        {
            Destroy(button);
        }
        allButtons.Clear();
    }
    // lake - 3 - swim, estate, back woods
    private void LakeButton(int optionCount) 
    {
        for (int i = 1; i <= optionCount; i++)
        {
            GameObject button;
            if (i == 1)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);

                button.GetComponent<ButtonListButton>().SetText("Swim");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 2));
                allButtons.Add(button);
            }
            else if (i == 2)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Estate");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 2));
                allButtons.Add(button);

            }
            else if (i == 3)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Back Woods");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 2));
                allButtons.Add(button);

            }
        }
    }
    // estate - 3 - Lake, Go Inside/Main Entry Hall, Gardens/ 
    private void EstateButton(int optionCount) 
    {
        for (int i = 0; i <= optionCount; i++)
        {
            GameObject button;
            if (i == 0)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Lake");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 2));
                allButtons.Add(button);
            }
            else if (i == 1)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Main Hall");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 2));
                allButtons.Add(button);
            }
            else if (i == 2)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Gardens");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 2));
                allButtons.Add(button);
            }
        }
    }
    // swim ??
    // back woods - 3 - lake, gardens, crypt
    private void BackWoods(int optionCount) 
    {
        for (int i = 0; i <= optionCount; i++)
        {
            GameObject button;
            if (i == 0)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Lake");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 2));
                allButtons.Add(button);
            }
            else if (i == 1)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Gardens");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 2));
                allButtons.Add(button);
            }
            else if (i == 2)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Crypt");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 3));
                allButtons.Add(button);
            }
        }
    }
    // crypt - 4 - Go Inside Crypt, Forest, Gardens, Estate
    private void Crypt(int optionCount) 
    {
        for (int i = 0; i <= optionCount; i++)
        {
            GameObject button;
            if (i == 0)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Inner Crypt");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 2));
                allButtons.Add(button);
            }
            else if (i == 1)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Forest");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 2));
                allButtons.Add(button);
            }
            else if (i == 2)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Gardens");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 2));
                allButtons.Add(button);
            }
            else if(i==3)
            {
                button = Instantiate(ButtonTemplate) as GameObject; 
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Estate");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 2));
                allButtons.Add(button);
            }
        }
    }
    // inner crypt - 2 - Search Coffins, Leave Crypt
    private void InnerCrypt(int optionCount)
    {
        for (int i = 0; i <= optionCount; i++)
        {
            GameObject button;
            if (i == 0)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Search Coffins");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 1));
                allButtons.Add(button);
            }
            else if (i == 1)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Leave Crypt");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 3));
                allButtons.Add(button);
            }
        }
    }
    // Search Coffins - 2 - close lid, Leave crypt
    private void SearchCoffins(int optionCount)
    {
        for (int i = 0; i <= optionCount; i++)
        {
            GameObject button;
            if (i == 0)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Close Lid");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 2));
                allButtons.Add(button);
            }
            else if (i == 1)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Leave Crypt");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 2));
                allButtons.Add(button);
            }
        }
    }
    // gardens - 3 - lake, crypt, estate
    private void Gardens(int optionCount) 
    {

    }
    // main Entry Hall - Upstairs/Main Hall, Library, Explore Main Entry
    private void MainEntryHall(int optionCount) 
    {
        for (int i = 0; i <= optionCount; i++)
        {
            GameObject button;
            if (i == 0)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Go Outside");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 2));
                allButtons.Add(button);
            }
            else if (i == 1)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Leave Crypt");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 2));
                allButtons.Add(button);
            }
        }
    }
    // Explore main entry - 2 - Upstairs/Main Hall, Library
    private void ExploreMainEntry(int optioinCount) { }
    // Upstairs/Main Hall - 4 - Second Floor, Sitting Room, Bathroom, Trophy Room
    private void MainHallway(int optionCount) { }
    // Trophy Room - 3 - Main Hall, Library, Explore Trophy Room
    private void Trophy(int optionCount) { }
    // Explore Trophy Room - 2 - Main Hall, library
    private void ExploreTrophy(int optionCount){}
    // library - 3 - trophy room, main hall, explore library
    private void Library(int optionCount) { }
    // Explore Library - 3 - trophy room, main hall, read a book
    private void ExploreLibrary(int optionCount) { }
    // Read a Book - 3 - Trophy room, Main Hall, Secret Room(library)
    private void ReadLibraryBook(int optionCount) { }
    // Bathroom - 1 - Main Hall
    private void Bathroom(int optionCount) { }
    // Secret Room - 2 - library, Explore Secret room
    private void SecretLibraryRoom(int optionCount) { }
    // explore secret room - 1 - library
    private void ExploreSecrectLibrary(int optionCount) { }
    // sitting room - 2 - main hall, dining room
    private void SittingRoom(int optionCount) { }
    // dining room - 4 - sitting room, kitchen, pantry, Explore Dining Room
    private void DiningRoom(int optionCount) { }
    // Explore Dining room - 3 - sitting room, kitchen, pantry
    private void ExploreDiningRoom(int optionCount) { }
    // kitchen - small hallway, dining room, explore kitchen
    private void Kitchen(int optionCount) { }
    // explore kitchen - 3 - small hallway, dining room, take a brownie
    private void ExploreKitchen(int optionCount) { }
    // take brownie - 2 - small hallway, dining room
    private void TakeBrownie(int optionCount) { }
    // pantry - 2 - dining room, explore pantry
    private void Pantry(int optionCount) { }
    // explore pantry - dining room, pull lever
    private void ExplorePantry(int optionCount) { }
    // pubb lever - 2 - dining room, pool room
    private void PullLever(int optionCount) { }
    // small hallway - 2 - servant's hall, kitchen
    private void SmallHallway(int optionCount) { }
    // pool room - 2 - pantry, explore pool room
    private void PoolRoom(int optionCount) { }
    // explore pool room - 1 - pantry
    private void ExplorePoolRoom(int optionCount) { }
    // treasure room - 2 - climb ladder(guest room), explore treasure room
    private void TreasureRoom(int optionCount) { }
    // explore treasure room - 1 -climb ladder(guest room)
    private void ExploreTreasureRoom(int optionCount) { }
    // 2nd floor - 4 - back downstairs, master bedroom, first hallway, 2nd hallway
    private void SecondFloor(int optionCount) { }
    // 1st hallwall - 3 - guest room, 2nd floor hallway, 2nd hallway
    private void FirstHallway(int optionCount) { }
    // 2nd hallway - 3 - 1st hallway, upstairs(attic room), Explore hallway
    private void SecondHallway(int optionCount) { }
    // Explore 2nd hallway - 3 - 1st hall, upstairs(attic room), push button
    private void ExploreSecondHallway(int optionCount) { }
    // push button - 3 - 1st hallway, upstairs(attic room), mirror room
    private void PushButton(int optionCount) { }
    // master bedroom - 3 - 2nd floor hallway, walk-in closet, Explore master bedroom
    private void MasterBedroom(int optionCount) { }
    // explore master bedroom - 3 - 2nd floor hallway, walk-in closet, read a book
    private void ExploreMasterBedroom(int optionCount) { }
    // read a book(master Bedroom) - 3 - walk-in closet, 2nd floor hallway, statue room
    private void ReadBedroomBook(int optionCount) { }
    // walk-in closet - 1 - master bedroom
    private void MasterCloset (int optionCount) { }
    // statue room - 1 - master bedroom
    private void StatueRoom(int optionCount) { }
    // guest room - 3 - 1st hallway, walk-in closet(guest room), explore guest room
    private void GuestRoom(int optionCount) { }
    // explore guest room - 3 - 1st hallway, walk-in closet(guest room), climb down ladder(treasure room)
    private void ExploreGuestRoom(int optionCount) { }
    // guest walk-in closet - 2 - guest bedroom, explore walk-in closet(guest room)
    private void GuestCloset(int optionCount) { }
    // explore guest walk-in closet - 2 - guest bedroom, royal room
    private void ExploreGuestCloset(int optionCount) { }
    // royal room - 1 -walk-in closet(guest room)
    private void RoyalRoom(int optionCount) { }
    // servant's hall (small hallway) - 3 - downstairs to small hallway, servant quarters, servants bathroom
    private void ServantsHall(int optionCount) { }
    // servant quarters - 1 - return to servant's hall
    private void ServantsQuarters(int optionCount) { }
    // servant's bathroom - 1 - return to servant's hall
    private void ServantsBathroom(int optionCount) { }
    // mirror room - 1 - 2nd hallway
    private void MirrorRoom(int optionCount) { }
    // attic room - 2 - 2nd hallway, secondary attic room
    private void AtticRoom(int optionCount) { }
    // secondary attic room - 3 - attic space, more storage, explore secondary attic room
    private void SecondAtticRoom(int optionCount) { }
    // explore secondary attic room - 2 - attic space, more storage
    private void ExploreSecondAtticRoom(int optionCount) { }
    // more storage 1 - return to secondary attic space
    private void Storage(int optionCount) { }

    private void PrintIntro()
    {
        GameObject textStory;
        textStory = Instantiate(TextTemplate) as GameObject;
        textStory.SetActive(true);
        textStory.GetComponent<ButtonListButton>().SetText("Lord Shuran Dunkeld, your grandfather, is known for being a warrior, a leader and sometimes an adventurer in the service of the king. Recently, you and your family have moved into the Dunkeld estate due to rumors about your grandfather disappearing, and even being dead. While your parents handle the responsibilities of the estate, you have been left to explore as you wish. You currently stand at the bottum of the stairs leading up to the front doors of the estate. You can smell the sweet scent of flowers from the nearby gardens and can see the waters of a rather large lake in the near distance, on the other side of some fields.");
        textStory.transform.SetParent(TextTemplate.transform.parent, false);
    }

    private void PrintMainEntry()
    {
        DeleteDynamicText();
        GameObject textStory = Instantiate(TextTemplate) as GameObject;
        textStory.SetActive(true);
        textStory.GetComponent<ButtonListButton>().SetText("You enter the main entry hall. Pillars, suits of armor and benches line the walls of this room.There is also a large chandelier that hangs from the ceiling and a decorative red and gold rug that covers most of the polished stone floor.There are stairs that lead up to a hallway and a door that goes to the library.");
        textStory.transform.SetParent(TextTemplate.transform.parent, false);

    }
    private void PrintGoOutside()
    {
        DeleteDynamicText();

        GameObject textStory = Instantiate(TextTemplate) as GameObject;
        textStory.SetActive(true);
        textStory.GetComponent<ButtonListButton>().SetText("You currently stand at the bottum of the stairs leading up to the front doors of the estate. You can smell the sweet scent of flowers from the nearby gardens and can see the waters of a rather large lake in the near distance, on the other side of some fields.");
        textStory.transform.SetParent(TextTemplate.transform.parent, false);
    }
    private void StartButtons()
    {
        for (int i = 1; i <= 3; i++)
        {
            GameObject button;
            if (i == 1)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Lake");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 2));
                allButtons.Add(button);
            }
            else if (i == 2)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Main Hall");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 2));
                allButtons.Add(button);
            }
            else if (i == 3)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Gardens");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 2));
                allButtons.Add(button);
            }
        }
    }

}
