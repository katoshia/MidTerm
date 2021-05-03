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



    // Start Function by Katoshia Grubb

    // GameScene start for buttons shown. 1st runthough.
    private void Start()
    {
        PrintINtro();
        StartButtons();
    }
    
    // OnButtonClick by Katoshia Grubb (felt like this could've been done more smoothly.) Attempted Vectorcs but spaced on how to do it C#. Lists Possible?
    private void OnButtonClick(string theName, int optionCount)
    {
        DeleteDynamicButtons();

        if (theName == "Estate" || theName == "Go Outside")
        {
            EstateButton(optionCount);
            PrintGoOutside();
        }
        else if (theName == "Lake")
        {
            LakeButton(optionCount);
        }
        else if (theName == "Back Woods" || theName == "Forest") 
        {
            BackWoodsButton(optionCount);
        }
        else if(theName == "Crypt")
        {
            CryptButton(optionCount);
        }
        else if (theName == "Inner Crypt")
        {
            InnerCryptButton(optionCount);
        }
        else if (theName == "Search Coffins")
        {
            SearchCoffinsButton(optionCount);
        }
        else if (theName == "Gardens")
        {
            GardensButton(optionCount);
        }
        else if (theName == "Main Entry" || theName == "Go Inside" )
        {
            MainEntryHallButton(optionCount);
            PrintMainEntry();
        }
        //else if (theName == "Go Outside")
        //{
        //    EstateButton(optionCount);
        //    PrintGoOutside();
        //}
        else if (theName == "Explore Main Entry")
        {
            ExploreMainEntryButton(optionCount);
        }
        else if (theName == "Main Hall" || theName == "Main Hallway" || theName == "Upstairs" || theName == "Downstairs")
        {
            MainHallwayButton(optionCount);
            PrintMainEntry();
        }
        else if (theName == "TrophyButton Room")
        {
            TrophyButton(optionCount);
        }
        else if (theName == "Explore Trophy Room")
        {
            ExploreTrophyButton(optionCount);
        }
        else if (theName == "Library")
        {
            LibraryButton(optionCount);
        }
        else if (theName == "Explore Library")
        {
            ExploreLibraryButton(optionCount);
        }
        else if (theName == "Read a book.")
        {
            ReadLibraryBookButton(optionCount);
        }
        else if (theName == "Bathroom")
        {
            BathroomButton(optionCount);
        }
        else if (theName == "Secret Library Room")
        {
            SecretLibraryRoomButton(optionCount);
        }
        else if (theName == "Explore Secret Room")
        {
            ExploreSecrectLibraryButton(optionCount);
        }
        else if (theName == "Sitting Room")
        {
            SittingRoomButton(optionCount);
        }
        else if (theName == "Dining Room")
        {
            DiningRoomButton(optionCount);
        }
        else if (theName == "Explore Dining Room")
        {
            ExploreDiningRoomButton(optionCount);
        }
        else if (theName == "Kitchen")
        {
            KitchenButton(optionCount);
        }
        else if (theName == "Explore Kitchen")
        {
            ExploreKitchenButton(optionCount);
        }
        else if (theName == "Take a Brownie")
        {
            TakeBrownieButton(optionCount);
        }
        else if (theName == "Pantry")
        {
            PantryButton(optionCount);
        }
        else if (theName == "Explore Pantry")
        {
            ExplorePantryButton(optionCount);
        }
        else if (theName == "Pull Lever")
        {
            PullLeverButton(optionCount);
        }
        else if (theName == "Small Hallway")
        {
            SmallHallwayButton(optionCount);
        }
        else if (theName == "Pool Room")
        {
            PoolRoomButton(optionCount);
        }
        else if (theName == "Explore Pool Room")
        {
            ExplorePoolRoomButton(optionCount);
        }
        else if (theName == "Treasure Room")
        {
            TreasureRoomButton(optionCount);
        }
        else if (theName == "Explore Treasure Room")
        {
            ExploreTreasureRoomButton(optionCount);
        }
        else if (theName == "Second Floor" || theName == "Landing")
        {
            SecondFloorButton(optionCount);
        }
        else if (theName == "First Hallway")
        {
            FirstHallwayButton(optionCount);
        }
        else if (theName == "Second Hallway")
        {
            SecondHallwayButton(optionCount);
        }
        else if (theName == "Explore the Hallway")
        {
            ExploreSecondHallwayButton(optionCount);
        }
        else if (theName == "Push the button")
        {
            PushBtnButton(optionCount);
        }
        else if (theName == "Master Bedroom")
        {
            MasterBedroomButton(optionCount);
        }
        else if (theName == "Explore Master Bedroom")
        {
            ExploreMasterBedroomButton(optionCount);
        }
        else if (theName == "Read the Book")
        {
            ReadBedroomBookButton(optionCount);
        }
        else if (theName == "Large Walk-In Closet")
        {
            MasterClosetButton(optionCount);
        }
        else if (theName == "Statue Room")
        {
            StatueRoomButton(optionCount);
        }
        else if (theName == "Guest Room")
        {
            GuestRoomButton(optionCount);
        }
        else if (theName == "Explore Guest Room")
        {
            ExploreGuestRoomButton(optionCount);
        }
        else if (theName == "Small Walk-In Closet")
        {
            GuestClosetButton(optionCount);
        }
        else if (theName == "Explore the closet.")
        {
            ExploreGuestClosetButton(optionCount);
        }
        else if (theName == "Royal Room")
        {
            RoyalRoomButton(optionCount);
        }
        else if (theName == "Servant's Hall")
        {
            ServantsHallButton(optionCount);
        }
        else if (theName == "Servant's Quarters")
        {
            ServantsQuartersButton(optionCount);
        }
        else if (theName == "Servant's Bathroom")
        {
            ServantsBathroomButton(optionCount);
        }
        else if (theName == "Mirror Room")
        {
            MirrorRoomButton(optionCount);
        }
        else if (theName == "Attic")
        {
            AtticRoomButton(optionCount);
        }
        else if (theName == "Second Attic Room")
        {
            SecondAtticRoomButton(optionCount);
        }
        else if (theName == "Explore Second Room")
        {
            ExploreSecondAtticRoomButton(optionCount);
        }
        else if (theName == "Storage")
        {
            StorageButton(optionCount);
        }
    }

    // Dynamic Buttons by Katoshia Grubb

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
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 3));
                allButtons.Add(button);

            }
            else if (i == 3)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Back Woods");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 3));
                allButtons.Add(button);

            }
        }
    }
    // estate - 3 - Lake, Go Inside/Main Entry Hall, Gardens/ 
    private void EstateButton(int optionCount) 
    {
        for (int i = 1; i <= optionCount; i++)
        {
            GameObject button;
            if (i == 1)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Lake");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 3));
                allButtons.Add(button);
            }
            else if (i == 2)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Go Inside");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 3));
                allButtons.Add(button);
            }
            else if (i == 3)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Gardens");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 3));
                allButtons.Add(button);
            }
        }
    }
    // swim ??
    // back woods - 3 - lake, gardens, crypt
    private void BackWoodsButton(int optionCount) 
    {
        for (int i = 1; i <= optionCount; i++)
        {
            GameObject button;
            if (i == 1)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Lake");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 3));
                allButtons.Add(button);
            }
            else if (i == 2)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Gardens");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 3));
                allButtons.Add(button);
            }
            else if (i == 3)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Crypt");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 4));
                allButtons.Add(button);
            }
        }
    }
    // crypt - 4 - Go Inside Crypt, Forest, Gardens, Estate
    private void CryptButton(int optionCount) 
    {
        for (int i = 1; i <= optionCount; i++)
        {
            GameObject button;
            if (i == 1)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Inner Crypt");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 2));
                allButtons.Add(button);
            }
            else if (i == 2)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Forest");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 3));
                allButtons.Add(button);
            }
            else if (i == 3)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Gardens");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 3));
                allButtons.Add(button);
            }
            else if(i==4)
            {
                button = Instantiate(ButtonTemplate) as GameObject; 
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Estate");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 3));
                allButtons.Add(button);
            }
        }
    }
    // inner crypt - 2 - Search Coffins, Leave Crypt
    private void InnerCryptButton(int optionCount)
    {
        for (int i = 1; i <= optionCount; i++)
        {
            GameObject button;
            if (i == 1)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Search Coffins");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 2));
                allButtons.Add(button);
            }
            else if (i == 2)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Leave Crypt");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 4));
                allButtons.Add(button);
            }
        }
    }
    // Search Coffins - 2 - close lid, Leave crypt
    private void SearchCoffinsButton(int optionCount)
    {
        for (int i = 1; i <= optionCount; i++)
        {
            GameObject button;
            if (i == 1)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Close Lid");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 2));
                allButtons.Add(button);
            }
            else if (i == 2)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Leave Crypt");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 4));
                allButtons.Add(button);
            }
        }
    }
    // gardens - 3 - lake, crypt, estate
    private void GardensButton(int optionCount) 
    {
        for (int i = 1; i <= optionCount; i++)
        {
            GameObject button;
            if (i == 1)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Lake");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 3));
                allButtons.Add(button);
            }
            else if (i == 2)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Crypt");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 4));
                allButtons.Add(button);
            }
            else if(i==3)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Estate");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 3));
                allButtons.Add(button);
            }
        }
    }
    // main Entry Hall - Upstairs/Main Hall, Library, Explore Main Entry
    private void MainEntryHallButton(int optionCount) 
    {
        for (int i = 1; i <= optionCount; i++)
        {
            GameObject button;
            if (i == 1)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Go Outside");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 3));
                allButtons.Add(button);
            }
            else if (i == 2)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Main Hallway");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 2));
                allButtons.Add(button);
            }
            else if (i == 3)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Library");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 3));
                allButtons.Add(button);
            }
            else if (i == 4)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Explore Entry");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 2));
                allButtons.Add(button);
            }
        }
    }
    // Explore main entry - 2 - Upstairs/Main Hall, Library
    private void ExploreMainEntryButton(int optionCount)
    {
        for (int i = 1; i <= optionCount; i++)
        {
            GameObject button;
            if (i == 1)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Upstairs");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 4));
                allButtons.Add(button);
            }
            else if (i == 2)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Library");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 3));
                allButtons.Add(button);
            }
        }
    }
    // Upstairs/Main Hall - 4 - Second Floor, Sitting Room, Bathroom, Trophy Room
    private void MainHallwayButton(int optionCount) 
    {
        for (int i = 1; i <= optionCount; i++)
        {
            GameObject button;
            if (i == 1)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Second Floor");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 4));
                allButtons.Add(button);
            }
            else if (i == 2)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Sitting Room");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 2));
                allButtons.Add(button);
            }
            if (i == 3)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Bathroom");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 1));
                allButtons.Add(button);
            }
            else if (i == 4)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Trophy Room");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 3));
                allButtons.Add(button);
            }
        }
    }
    // Trophy Room - 3 - Main Hall, Library, Explore Trophy Room
    private void TrophyButton(int optionCount)
    {
        for (int i = 1; i <= optionCount; i++)
        {
            GameObject button;
            if (i == 1)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Main Hall");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 4));
                allButtons.Add(button);
            }
            else if (i == 2)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Library");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 3));
                allButtons.Add(button);
            }
            if (i == 3)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Explore Trophy Room");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 2));
                allButtons.Add(button);
            }
        }
    }
    // Explore Trophy Room - 2 - Main Hall, library
    private void ExploreTrophyButton(int optionCount)
    {
        for (int i = 1; i <= optionCount; i++)
        {
            GameObject button;
            if (i == 1)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Main Hall");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 4));
                allButtons.Add(button);
            }
            else if (i == 2)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Library");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 3));
                allButtons.Add(button);
            }
        }
    }
    // library - 3 - trophy room, main hall, explore library
    private void LibraryButton(int optionCount) 
    {
        for (int i = 1; i <= optionCount; i++)
        {
            GameObject button;
            if (i == 1)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Main Hall");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 4));
                allButtons.Add(button);
            }
            else if (i == 2)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Trophy Room");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 3));
                allButtons.Add(button);
            }
            else if (i == 3)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Explore Library");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 3));
                allButtons.Add(button);
            }
        }
    }
    // Explore Library - 3 - trophy room, main hall, read a book
    private void ExploreLibraryButton(int optionCount) 
    {
        for (int i = 1; i <= optionCount; i++)
        {
            GameObject button;
            if (i == 1)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Main Hall");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 4));
                allButtons.Add(button);
            }
            else if (i == 2)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Trophy Room");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 3));
                allButtons.Add(button);
            }
            else if (i == 3)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Read a Book");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 3));
                allButtons.Add(button);
            }
        }
    }
    // Read a Book - 3 - Trophy room, Main Hall, Secret Room(library)
    private void ReadLibraryBookButton(int optionCount) 
    {
        for (int i = 1; i <= optionCount; i++)
        {
            GameObject button;
            if (i == 1)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Main Hall");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 4));
                allButtons.Add(button);
            }
            else if (i == 2)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Trophy Room");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 3));
                allButtons.Add(button);
            }
            else if (i == 3)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Secret Library Room");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 2));
                allButtons.Add(button);
            }
        }
    }
    // Bathroom - 1 - Main Hall
    private void BathroomButton(int optionCount)
    {
        for (int i = 1; i <= optionCount; i++)
        {
            GameObject button;
            if (i == 1)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Main Hall");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 4));
                allButtons.Add(button);
            }
        }
    }
    // Secret Room - 2 - library, Explore Secret room
    private void SecretLibraryRoomButton(int optionCount)
    {
        for (int i = 1; i <= optionCount; i++)
        {
            GameObject button;
            if (i == 1)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Explore Secret Room");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 1));
                allButtons.Add(button);
            }
            else if (i == 2)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Library");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 3));
                allButtons.Add(button);
            }
        }
    }
    // explore secret room - 1 - library
    private void ExploreSecrectLibraryButton(int optionCount) 
    {
        for (int i = 1; i <= optionCount; i++)
        {
            GameObject button;
            if (i == 1)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Library");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 3));
                allButtons.Add(button);
            }
        }
    }
    // sitting room - 2 - main hall, dining room
    private void SittingRoomButton(int optionCount) 
    {
        for (int i = 1; i <= optionCount; i++)
        {
            GameObject button;
            if (i == 1)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Main Hall");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 4));
                allButtons.Add(button);
            }
            else if (i == 2)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Dining Room");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 4));
                allButtons.Add(button);
            }
        }
    }
    // dining room - 4 - sitting room, kitchen, pantry, Explore Dining Room
    private void DiningRoomButton(int optionCount) 
    {
        for (int i = 1; i <= optionCount; i++)
        {
            GameObject button;
            if (i == 1)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Sitting Room");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 2));
                allButtons.Add(button);
            }
            else if (i == 2)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Kitchen");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 3));
                allButtons.Add(button);
            }
            else if (i == 3)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Pantry");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 2));
                allButtons.Add(button);
            }
            else if (i == 4)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Explore Dining Room");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 3));
                allButtons.Add(button);
            }
        }
    }
    // Explore Dining room - 3 - sitting room, kitchen, pantry
    private void ExploreDiningRoomButton(int optionCount) 
    {
        for (int i = 1; i <= optionCount; i++)
        {
            GameObject button;
            if (i == 1)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Sitting Room");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 2));
                allButtons.Add(button);
            }
            else if (i == 2)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Kitchen");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 3));
                allButtons.Add(button);
            }
            else if (i == 3)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Pantry");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 2));
                allButtons.Add(button);
            }
        }
    }
    // kitchen - small hallway, dining room, explore kitchen
    private void KitchenButton(int optionCount) 
    {
        GameObject button;
        for (int i = 1; i <= optionCount; i++)
        {
            if (i == 1)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Small Hallway");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 2));
                allButtons.Add(button);
            }
            else if (i == 2)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Dining Room");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 4));
                allButtons.Add(button);
            }
            else if (i == 3)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Explore Kitchen");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 3));
                allButtons.Add(button);
            }
        }
    }
    // explore kitchen - 3 - small hallway, dining room, take a brownie
    private void ExploreKitchenButton(int optionCount) 
    {
        GameObject button;
        for (int i = 1; i <= optionCount; i++)
        {
            if (i == 1)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Small Hallway");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 2));
                allButtons.Add(button);
            }
            else if (i == 2)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Dining Room");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 4));
                allButtons.Add(button);
            }
            else if (i == 3)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Take a Brownie");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 2));
                allButtons.Add(button);
            }
        }
    }
    // take brownie - 2 - small hallway, dining room
    private void TakeBrownieButton(int optionCount)
    {
        GameObject button;
        for (int i = 1; i <= optionCount; i++)
        {
            if (i == 1)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Small Hallway");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 2));
                allButtons.Add(button);
            }
            else if (i == 2)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Dining Room");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 4));
                allButtons.Add(button);
            }
        }
    }
    // pantry - 2 - dining room, explore pantry
    private void PantryButton(int optionCount) 
    {
        GameObject button;
        for (int i = 1; i <= optionCount; i++)
        {
            if (i == 1)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Explore Pantry");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 2));
                allButtons.Add(button);
            }
            else if (i == 2)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Dining Room");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 4));
                allButtons.Add(button);
            }
        }
    }
    // explore pantry - dining room, pull lever
    private void ExplorePantryButton(int optionCount) 
    {
        GameObject button;
        for (int i = 1; i <= optionCount; i++)
        {
            if (i == 1)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Pull Lever");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 2));
                allButtons.Add(button);
            }
            else if (i == 2)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Dining Room");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 4));
                allButtons.Add(button);
            }
        }
    }
    // pull lever - 2 - dining room, pool room
    private void PullLeverButton(int optionCount) 
    {
        GameObject button;
        for (int i = 1; i <= optionCount; i++)
        {
            if (i == 1)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Pool Room");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 2));
                allButtons.Add(button);
            }
            else if (i == 2)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Dining Room");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 4));
                allButtons.Add(button);
            }
        }
    }
    // small hallway - 2 - servant's hall, kitchen
    private void SmallHallwayButton(int optionCount) 
    {
        GameObject button;
        for (int i = 1; i <= optionCount; i++)
        {
            if (i == 1)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Servant's Hall");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 3));
                allButtons.Add(button);
            }
            else if (i == 2)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Kitchen");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 3));
                allButtons.Add(button);
            }
        }
    }
    // pool room - 2 - pantry, explore pool room
    private void PoolRoomButton(int optionCount) 
    {
        GameObject button;
        for (int i = 1; i <= optionCount; i++)
        {
            if (i == 1)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Pantry");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 2));
                allButtons.Add(button);
            }
            else if (i == 2)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Explore Pool Room");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 1));
                allButtons.Add(button);
            }
        }
    }
    // explore pool room - 1 - pantry
    private void ExplorePoolRoomButton(int optionCount)
    {
        GameObject button;
        for (int i = 1; i <= optionCount; i++)
        {
            if (i == 1)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Pantry");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 2));
                allButtons.Add(button);
            }
        }
    }
    // treasure room - 2 - climb ladder(guest room), explore treasure room
    private void TreasureRoomButton(int optionCount) 
    {
        GameObject button;
        for (int i = 1; i <= optionCount; i++)
        {
            if (i == 1)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Climb Ladder");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 2));
                allButtons.Add(button);
            }
            if (i == 2)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Explore Treasure Room");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 1));
                allButtons.Add(button);
            }
        }
    }
    // explore treasure room - 1 -climb ladder(guest room)
    private void ExploreTreasureRoomButton(int optionCount)
    {
        GameObject button;
        for (int i = 1; i <= optionCount; i++)
        {
            if (i == 1)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Climb Ladder");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 2));
                allButtons.Add(button);
            }
        }
    }
    // 2nd floor - 4 - back downstairs, master bedroom, first hallway, 2nd hallway
    private void SecondFloorButton(int optionCount) 
    {
        GameObject button;
        for (int i = 1; i <= optionCount; i++)
        {
            if (i == 1)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Downstairs");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 3));
                allButtons.Add(button);
            }
            else if (i == 2)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Master Bedroom");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 3));
                allButtons.Add(button);
            }
            else if(i == 3)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("First Hallway");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 3));
                allButtons.Add(button);
            }
            else if (i == 4)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Second Hallway");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 3));
                allButtons.Add(button);
            }
        }

    }
    // 1st hallwall - 3 - guest room, 2nd floor hallway, 2nd hallway
    private void FirstHallwayButton(int optionCount)
    {
        GameObject button;
        for (int i = 1; i <= optionCount; i++)
        {
            if (i == 1)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Guest Room");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 3));
                allButtons.Add(button);
            }
            else if (i == 2)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Landing");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 4));
                allButtons.Add(button);
            }
            else if (i == 3)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Second Hallway");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 3));
                allButtons.Add(button);
            }
        }
    }
    // 2nd hallway - 3 - 1st hallway, upstairs(attic room), Explore hallway
    private void SecondHallwayButton(int optionCount) 
    {
        GameObject button;
        for (int i = 1; i <= optionCount; i++)
        {
            if (i == 1)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Explore the Hallway");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 3));
                allButtons.Add(button);
            }
            else if (i == 2)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Attic");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 2));
                allButtons.Add(button);
            }
            else if (i == 3)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("First Hallway");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 3));
                allButtons.Add(button);
            }
        }
    }
    // Explore 2nd hallway - 3 - 1st hall, upstairs(attic room), push button
    private void ExploreSecondHallwayButton(int optionCount) 
    {
        GameObject button;
        for (int i = 1; i <= optionCount; i++)
        {
            if (i == 1)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Push the Button");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 3));
                allButtons.Add(button);
            }
            else if (i == 2)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Attic");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 2));
                allButtons.Add(button);
            }
            else if (i == 3)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("First Hallway");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 3));
                allButtons.Add(button);
            }
        }
    }
    // push button - 3 - 1st hallway, upstairs(attic room), mirror room
    private void PushBtnButton(int optionCount) 
    {
        GameObject button;
        for (int i = 1; i <= optionCount; i++)
        {
            if (i == 1)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Mirror Room");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 1));
                allButtons.Add(button);
            }
            else if (i == 2)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Attic");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 2));
                allButtons.Add(button);
            }
            else if (i == 3)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("First Hallway");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 3));
                allButtons.Add(button);
            }
        }
    }
    // master bedroom - 3 - 2nd floor hallway, walk-in closet, Explore master bedroom
    private void MasterBedroomButton(int optionCount) 
    {
        GameObject button;
        for (int i = 1; i <= optionCount; i++)
        {
            if (i == 1)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Second Hallway");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 3));
                allButtons.Add(button);
            }
            else if (i == 2)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Large Walk-In Closet");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 1));
                allButtons.Add(button);
            }
            else if (i == 3)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Explore Master Bedroom");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 3));
                allButtons.Add(button);
            }
        }
    }
    // explore master bedroom - 3 - 2nd floor hallway, walk-in closet, read a book
    private void ExploreMasterBedroomButton(int optionCount) 
    {
        GameObject button;
        for (int i = 1; i <= optionCount; i++)
        {
            if (i == 1)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Second Hallway");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 3));
                allButtons.Add(button);
            }
            else if (i == 2)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Large Walk-In Closet");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 1));
                allButtons.Add(button);
            }
            else if (i == 3)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Read the Book");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 3));
                allButtons.Add(button);
            }
        }
    }
    // read a book(master Bedroom) - 3 - walk-in closet, 2nd floor hallway, statue room
    private void ReadBedroomBookButton(int optionCount) 
    {
        GameObject button;
        for (int i = 1; i <= optionCount; i++)
        {
            if (i == 1)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Landing");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 4));
                allButtons.Add(button);
            }
            else if (i == 2)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Large Walk-In Closet");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 1));
                allButtons.Add(button);
            }
            else if (i == 3)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Statue Room");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 1));
                allButtons.Add(button);
            }
        }
    }
    // walk-in closet - 1 - master bedroom
    private void MasterClosetButton (int optionCount) 
    {
        GameObject button;
        for (int i = 1; i <= optionCount; i++)
        {
            if (i == 1)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Master Bedroom");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 3));
                allButtons.Add(button);
            }
        }
    }
    // statue room - 1 - master bedroom
    private void StatueRoomButton(int optionCount) 
    {
        GameObject button;
        for (int i = 1; i <= optionCount; i++)
        {
            if (i == 1)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Master Bedroom");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 3));
                allButtons.Add(button);
            }
        }
    }
    // guest room - 3 - 1st hallway, walk-in closet(guest room), explore guest room
    private void GuestRoomButton(int optionCount) 
    {
        GameObject button;
        for (int i = 1; i <= optionCount; i++)
        {
            if (i == 1)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("First Hallway");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 3));
                allButtons.Add(button);
            }
            else if (i == 2)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Small Walk-In Closet");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 2));
                allButtons.Add(button);
            }
            else if (i == 3)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Explore Guest Room");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 3));
                allButtons.Add(button);
            }
        }
    }
    // explore guest room - 3 - 1st hallway, walk-in closet(guest room), climb down ladder(treasure room)
    private void ExploreGuestRoomButton(int optionCount) 
    {
        GameObject button;
        for (int i = 1; i <= optionCount; i++)
        {
            if (i == 1)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("First Hallway");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 3));
                allButtons.Add(button);
            }
            else if (i == 2)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Small Walk-In Closet");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 2));
                allButtons.Add(button);
            }
            else if (i == 3)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Climb Down Ladder");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 2));
                allButtons.Add(button);
            }
        }
    }
    // guest walk-in closet - 2 - guest bedroom, explore walk-in closet(guest room)
    private void GuestClosetButton(int optionCount) 
    {
        GameObject button;
        for (int i = 1; i <= optionCount; i++)
        {
            if (i == 1)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Guest Bedroom");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 3));
                allButtons.Add(button);
            }
            else if (i == 2)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Explore Small Walk-In Closet");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 2));
                allButtons.Add(button);
            }
        }
    }
    // explore guest walk-in closet - 2 - guest bedroom, royal room
    private void ExploreGuestClosetButton(int optionCount) 
    {
        GameObject button;
        for (int i = 1; i <= optionCount; i++)
        {
            if (i == 1)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Guest Bedroom");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 3));
                allButtons.Add(button);
            }
            else if (i == 2)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Royal Room");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 1));
                allButtons.Add(button);
            }
        }
    }
    // royal room - 1 -walk-in closet(guest room)
    private void RoyalRoomButton(int optionCount) 
    {
        GameObject button;
        for (int i = 1; i <= optionCount; i++)
        {
            if (i == 1)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Small Walk-In Closet");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 2));
                allButtons.Add(button);
            }
        }
    }
    // servant's hall (small hallway) - 3 - downstairs to small hallway, servant quarters, servants bathroom
    private void ServantsHallButton(int optionCount) 
    {
        GameObject button;
        for (int i = 1; i <= optionCount; i++)
        {
            if (i == 1)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Small Hallway");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 2));
                allButtons.Add(button);
            }
            else if (i == 2)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Servant's Quarters");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 1));
                allButtons.Add(button);
            }
            else if (i == 3)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Servant's Bathroom");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 1));
                allButtons.Add(button);
            }
        }
    }
    // servant quarters - 1 - return to servant's hall
    private void ServantsQuartersButton(int optionCount)
    {
        GameObject button;
        for (int i = 1; i <= optionCount; i++)
        {
            if (i == 1)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Servant's Hall");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 3));
                allButtons.Add(button);
            }
        }
    }
    // servant's bathroom - 1 - return to servant's hall
    private void ServantsBathroomButton(int optionCount) 
    {
        GameObject button;
        for (int i = 1; i <= optionCount; i++)
        {
            if (i == 1)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Servant's Hall");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 3));
                allButtons.Add(button);
            }
        }
    }
    // mirror room - 1 - 2nd hallway
    private void MirrorRoomButton(int optionCount) 
    {
        GameObject button;
        for (int i = 1; i <= optionCount; i++)
        {
            if (i == 1)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Second Hallway");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 3));
                allButtons.Add(button);
            }
        }
    }
    // attic room - 2 - 2nd hallway, secondary attic room
    private void AtticRoomButton(int optionCount) 
    {
        GameObject button;
        for (int i = 1; i <= optionCount; i++)
        {
            if (i == 1)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Second Hallway");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 3));
                allButtons.Add(button);
            }
            else if (i == 2)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Second Attic");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 3));
                allButtons.Add(button);
            }
        }
    }
    // secondary attic room - 3 - attic space, more storage, explore secondary attic room
    private void SecondAtticRoomButton(int optionCount) 
    {
        for (int i = 1; i <= optionCount; i++)
        {
            GameObject button;
            if (i == 1)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Storage");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 2));
                allButtons.Add(button);
            }
            else if (i == 2)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Attic");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 2));
                allButtons.Add(button);
            }       
            else if (i == 3)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Explore Second Attic Room");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 2));
                allButtons.Add(button);
            }
        }
    }
    // explore secondary attic room - 2 - attic space, more storage
    private void ExploreSecondAtticRoomButton(int optionCount) 
    {
        for (int i = 1; i <= optionCount; i++)
        {
            GameObject button;
            if (i == 1)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Storage");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 2));
                allButtons.Add(button);
            }
            else if (i == 2)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Attic");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 2));
                allButtons.Add(button);
            }
        }
    }
    // more storage 1 - return to secondary attic space
    private void StorageButton(int optionCount)
    {
        for (int i = 1; i <= optionCount; i++)
        {
            GameObject button;
            if (i == 1)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Second Attic Room");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 3));
                allButtons.Add(button);
            }
        }
    }

    // Start buttons for GameScene by Katoshia Grubb
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
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 3));
                allButtons.Add(button);
            }
            else if (i == 2)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Go Inside");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 3));
                allButtons.Add(button);
            }
            else if (i == 3)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Gardens");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 3));
                allButtons.Add(button);
            }
        }
    }

    // Delete Dynamic Elements by Katoshia Grubb
    private void DeleteDynamicButtons()
    {
        foreach (GameObject button in allButtons)
        {
            Destroy(button);
        }
        allButtons.Clear();
    }
    private void DeleteDynamicText()
    {
        Destroy(GameObject.Find("StoryText(Clone)"));
    }


    // Print Functions by Youlanda Daffron
    // renamed by Katoshia Grubb
    private void PrintINtro()
    {
        DeleteDynamicText();
        GameObject textStory = Instantiate(TextTemplate) as GameObject;
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
    private void PrintTheLake( )
    {
        DeleteDynamicText();
        GameObject textStory = Instantiate(TextTemplate) as GameObject;
        textStory.SetActive(true);
        textStory.GetComponent<ButtonListButton>().SetText("You walk through green grass that is so tall that it reaches your knees. It makes walking a little slow at first, but you soon find a worn path to follow. In the distance, you see a brown horse with white on its nose grazing. As you pass, it looks in your direction, then returns to grazing. It doesn't take long to get to the shore of the lake. The grass thins out and ends as you step onto the lake's sandy beach. The water's edge reaches towards your feet, then retreats in small waves. There is a row boat tied to a post, with two oars inside. Further down the beach, you see another trail that leads in the direction of the back woods.");
        textStory.transform.SetParent(TextTemplate.transform.parent, false);

    }

    private void PrintBackWoods( )
    {
        DeleteDynamicText();
        GameObject textStory = Instantiate(TextTemplate) as GameObject;
        textStory.SetActive(true);
        textStory.GetComponent<ButtonListButton>().SetText("The trail you are following is all dirt and rock. As you near the tree line, you see just how big and tall the trees are. Clearly, they are very old trees that have been there a long time. Despite the sunny weather, the forest seems dark and spooky. Eventually, the trail splits. One side of the split goes into the depths of the forest. The other way leads to an old stone structure, the Dunkeld family crypt. You see a pile of wood at the point the trail splits. Next to the wood pile is a stump with a chopping axe stuck in it.");
        textStory.transform.SetParent(TextTemplate.transform.parent, false);

    }

    private void PrintCrypt( )
    {
        DeleteDynamicText();
        GameObject textStory = Instantiate(TextTemplate) as GameObject;
        textStory.SetActive(true);
        textStory.GetComponent<ButtonListButton>().SetText("Your family is an old one, going back many generations. When a member of the family has passed on, their body is entered into the crypt with honor. The building is built of white and gray marble. Images of warrior guardians are carved into the stone doors. It seems quieter here than the rest of the grounds. It is as if even the insects know that spirits rest here.");
        textStory.transform.SetParent(TextTemplate.transform.parent, false);

    }

    private void PrintInsideCrypt( )
    {
        DeleteDynamicText();
        GameObject textStory = Instantiate(TextTemplate) as GameObject;
        textStory.SetActive(true);
        textStory.GetComponent<ButtonListButton>().SetText("As you open the doors, you hear the faint grind of stone on stone and then you step inside. Cool air blows out from the inside and swirls around you. As you enter the dimly lit chamber, you swear you hear a groan. There are stone coffins lining three of the walls and stairs going down into the catacombs.");
        textStory.transform.SetParent(TextTemplate.transform.parent, false);

    }

    private void PrintCoffins( )
    {
        DeleteDynamicText();
        GameObject textStory = Instantiate(TextTemplate) as GameObject;
        textStory.SetActive(true);
        textStory.GetComponent<ButtonListButton>().SetText("You search the main room and the stone coffins.The lids are very heavy and hard to move.You are only able to move one of them.With all your might, you push one to the side and peer in.Inside the coffin, you see a skeleton dressed in armor and with a sword laying at its side.");
        textStory.transform.SetParent(TextTemplate.transform.parent, false);

    }


    private void PrintTheGardens( )
    {
        DeleteDynamicText();
        GameObject textStory = Instantiate(TextTemplate) as GameObject;
        textStory.SetActive(true);
        textStory.GetComponent<ButtonListButton>().SetText("The path you are walking on turns from dirt and grass to fine colored gravel. The sweet smell of flowers tickles your nose and you can hear the sound of an insect moving from flower to flower. As you follow the path through the gardens, you see stone benches where people can sit and you even come across a fountain. In your exploring, you also see Yori the gardner.");
        textStory.transform.SetParent(TextTemplate.transform.parent, false);

    }

    private void PrintExploreEntry( )
    {
        DeleteDynamicText();
        GameObject textStory = Instantiate(TextTemplate) as GameObject;
        textStory.SetActive(true);
        textStory.GetComponent<ButtonListButton>().SetText("You explore the room, moving around the pillars and the suits of armor.There does not seem to be anything special about this room, though, you do find on one wall there is a round mirror with a thin silver frame that is between two of the pillars with two suits of armor seeming to stand guard.");
        textStory.transform.SetParent(TextTemplate.transform.parent, false);

    }

    private void PrintHallway( )
    {
        DeleteDynamicText();
        GameObject textStory = Instantiate(TextTemplate) as GameObject;
        textStory.SetActive(true);
        textStory.GetComponent<ButtonListButton>().SetText("You enter the quiet hallway, your footsteps echoing. The walls are decorated with paintings, suits of armor and potted plants as you walk along.There are doors to a sitting room, a door to the trophy room and a door to the bathroom.There are also stairs leading up to the second level.");
        textStory.transform.SetParent(TextTemplate.transform.parent, false);

    }

    private void PrintTrophyRoom( )
    {
        DeleteDynamicText();
        GameObject textStory = Instantiate(TextTemplate) as GameObject;
        textStory.SetActive(true);
        textStory.GetComponent<ButtonListButton>().SetText("You enter a room featuring a large soft bear rug in the center of the floor.Between cases of weapons and other trinkets, are a set of comfortable chairs. On the walls near the doors are mounted animal heads, such as a bear and moose. There is a door to the hallway and a door to the library in this room.");
        textStory.transform.SetParent(TextTemplate.transform.parent, false);

    }

    private void PrintExploreTrophyRoom( )
    {
        DeleteDynamicText();
        GameObject textStory = Instantiate(TextTemplate) as GameObject;
        textStory.SetActive(true);
        textStory.GetComponent<ButtonListButton>().SetText("There are many things to look at in this room. There are a variety of swords in the weapon cases.There is a shelf that hold skulls of creatures you can't identify. You find that the rug on the floor is quite soft to the touch.");
        textStory.transform.SetParent(TextTemplate.transform.parent, false);

    }

    private void PrintLibrary( )
    {
        DeleteDynamicText();
        GameObject textStory = Instantiate(TextTemplate) as GameObject;
        textStory.SetActive(true);
        textStory.GetComponent<ButtonListButton>().SetText("Entering the library, you see many bookshelves lining the walls that are full of books. You also see a table and chairs for reading, a desk and a lecturn with a book on it. There is a door to the trophy room and doors to the main entry hall here.");
        textStory.transform.SetParent(TextTemplate.transform.parent, false);

    }

    private void PrintExploreLibrary( )
    {
        DeleteDynamicText();
        GameObject textStory = Instantiate(TextTemplate) as GameObject;
        textStory.SetActive(true);
        textStory.GetComponent<ButtonListButton>().SetText("The room is kept very neat. There is a stack of blank writing paper on the desk with a pen sitting in an ink jar. There are a half dozen unused candles in one of the desk drawers. Most noteably, in this room, is the collection of books on the bookshelves. There are many titles of literature and stories that you recognize, but there are also many more titles that you don't. The titles speak of places you've never heard of, strange beasts, ghosts and magic.");
        textStory.transform.SetParent(TextTemplate.transform.parent, false);

    }

    private void PrintReadLibrary( )
    {
        DeleteDynamicText();
        GameObject textStory = Instantiate(TextTemplate) as GameObject;
        textStory.SetActive(true);
        textStory.GetComponent<ButtonListButton>().SetText("You begin to pull a thick book off of the shelf, but it stops as you hear a click. You are fast enough on your feet to get out of the way as the bookshelf swings slowly outward, revealing another room hidden behind it.");
        textStory.transform.SetParent(TextTemplate.transform.parent, false);

    }

    private void PrintBathroom( )
    {
        DeleteDynamicText();
        GameObject textStory = Instantiate(TextTemplate) as GameObject;
        textStory.SetActive(true);
        textStory.GetComponent<ButtonListButton>().SetText("You step into this small room and find little of interest. There is a sink with a mirror and a toilet.");
        textStory.transform.SetParent(TextTemplate.transform.parent, false);

    }

    private void PrintSecretLibraryRoom( )
    {
        DeleteDynamicText();
        GameObject textStory = Instantiate(TextTemplate) as GameObject;
        textStory.SetActive(true);
        textStory.GetComponent<ButtonListButton>().SetText("You step past the bookshelf that turned into a door and enter a dusty smelling room. Holding up your lantern, you see three chests and a full length mirror that is decorated with silver moons and gold suns around its edge.");
        textStory.transform.SetParent(TextTemplate.transform.parent, false);

    }

    private void PrintExploreSecretLibraryRoom( )
    {
        DeleteDynamicText();
        GameObject textStory = Instantiate(TextTemplate) as GameObject;
        textStory.SetActive(true);
        textStory.GetComponent<ButtonListButton>().SetText("You explore the room and see that the mirror is as tall and wide as a door as it sits against the wall. You then turn your attention to the chests, which you find are not locked and easy to open. You open the first chest and find inside a set of deep purple colored robes made of a fine fabric. There is also a box of six wands carved from different materials, including one that looks to be made from crystal. The second chest is full of thick dusty tomes. The tomes are full of symbols and strange writing. In the last chest, you find several trinkets such as a long carved staff and a crystal ball.");
        textStory.transform.SetParent(TextTemplate.transform.parent, false);

    }

    private void PrintSittingRoom( )
    {
        DeleteDynamicText();
        GameObject textStory = Instantiate(TextTemplate) as GameObject;
        textStory.SetActive(true);
        textStory.GetComponent<ButtonListButton>().SetText("You enter the sitting room which features several comfortable places to sit, a few potted plants to bring life to the room and paintings decorating the walls. There is a door to the hallway and a door to the dining room");
        textStory.transform.SetParent(TextTemplate.transform.parent, false);

    }

    private void PrintDiningRoom( )
    {
        DeleteDynamicText();
        GameObject textStory = Instantiate(TextTemplate) as GameObject;
        textStory.SetActive(true);
        textStory.GetComponent<ButtonListButton>().SetText("You enter the largest room so far, the dining room. A big table surrounded by ten chairs is at the center. At one end is a smaller, round table. Paintings and plotted plants decorate this room as well as display cases with precious china. There is a door to the sitting room, a door to the kitchen and a door to the pantry.");
        textStory.transform.SetParent(TextTemplate.transform.parent, false);

    }

    private void PrintExploreDiningRoom( )
    {
        DeleteDynamicText();
        GameObject textStory = Instantiate(TextTemplate) as GameObject;
        textStory.SetActive(true);
        textStory.GetComponent<ButtonListButton>().SetText("You explore the room and find the dining room to be quite spacious. In the display case is a collection of white plates and bowls that have been carefully decorated with purple flowers around their rims. The dining table is made of heavy polished wood. The chairs are made of the same wood and are comfortably cushioned.");
        textStory.transform.SetParent(TextTemplate.transform.parent, false);

    }

    private void PrintKitchen( )
    {
        DeleteDynamicText();
        GameObject textStory = Instantiate(TextTemplate) as GameObject;
        textStory.SetActive(true);
        textStory.GetComponent<ButtonListButton>().SetText("Entering the kitchen, you smell all kinds of good things. There is a large fireplace with a cooking pot hanging over flames and embers. There are several tables and counters where food is being prepped.");
        textStory.transform.SetParent(TextTemplate.transform.parent, false);

    }

    private void PrintExploreKitchen( )
    {
        DeleteDynamicText();
        GameObject textStory = Instantiate(TextTemplate) as GameObject;
        textStory.SetActive(true);
        textStory.GetComponent<ButtonListButton>().SetText("Moving around the kitchen, you are careful to not bump into any of the cooks currently preparing and making food. In all the activity, you do see a platter set off to the side on one table that is stacked with cut brownies. They look rather delicious.");
        textStory.transform.SetParent(TextTemplate.transform.parent, false);

    }

    private void PrintTakeBrownie( )
    {
        DeleteDynamicText();
        GameObject textStory = Instantiate(TextTemplate) as GameObject;
        textStory.SetActive(true);
        textStory.GetComponent<ButtonListButton>().SetText("While the cooks aren't looking, you reach over to the plate and you take a brownie off the top. As you eat it, it is warm still and very delicious. As you are taking the last bite of your brownie, one of the cooks scolds you.");
        textStory.transform.SetParent(TextTemplate.transform.parent, false);

    }

    private void PrintPantry( )
    {
        DeleteDynamicText();
        GameObject textStory = Instantiate(TextTemplate) as GameObject;
        textStory.SetActive(true);
        textStory.GetComponent<ButtonListButton>().SetText("You open the door and enter the pantry. Inside you see several bottles of wine, sacks of flour and crates of potatoes. There is a door to the dining room here.");
        textStory.transform.SetParent(TextTemplate.transform.parent, false);

    }

    private void PrintExplorePantry( )
    {
        DeleteDynamicText();
        GameObject textStory = Instantiate(TextTemplate) as GameObject;
        textStory.SetActive(true);
        textStory.GetComponent<ButtonListButton>().SetText("You look around the room stacked full of bags, crates and boxes of food items. The stone walls are decorated only with shelves storing more things. In one corner, you see a crack in the wall just big enough to fit your hand in. Reaching inside, you find a lever.");
        textStory.transform.SetParent(TextTemplate.transform.parent, false);

    }

    private void PrintPullPantryLever( )
    {
        DeleteDynamicText();
        GameObject textStory = Instantiate(TextTemplate) as GameObject;
        textStory.SetActive(true);
        textStory.GetComponent<ButtonListButton>().SetText("You pull the lever and you hear a click as it sets into place. Part of the wall slides away to reveal a hidden room.");
        textStory.transform.SetParent(TextTemplate.transform.parent, false);

    }

    private void PrintSmallHallway( )
    {
        DeleteDynamicText();
        GameObject textStory = Instantiate(TextTemplate) as GameObject;
        textStory.SetActive(true);
        textStory.GetComponent<ButtonListButton>().SetText("You find yourself in another hallway, though this one smaller than the one at the front door. There is a door to the kitchen and stairs leading up to the Servant's Hall.");
        textStory.transform.SetParent(TextTemplate.transform.parent, false);

    }

    private void PrintPoolRoom( )
    {
        DeleteDynamicText();
        GameObject textStory = Instantiate(TextTemplate) as GameObject;
        textStory.SetActive(true);
        textStory.GetComponent<ButtonListButton>().SetText("You enter a stone room. The light from the open door reveals a pool in the center of the room and nothing else to be seen.");
        textStory.transform.SetParent(TextTemplate.transform.parent, false);

    }

    private void PrintExplorePoolRoom( )
    {
        DeleteDynamicText();
        GameObject textStory = Instantiate(TextTemplate) as GameObject;
        textStory.SetActive(true);
        textStory.GetComponent<ButtonListButton>().SetText("You walk further into the room. Your footsteps echo a little off the walls. Taking a closer look at the pool, you can see your reflection in the clear water. The stone around the pool is carved with images of shells, mermaids and sea creatures.");
        textStory.transform.SetParent(TextTemplate.transform.parent, false);

    }

    private void PrintTreasureRoom( )
    {
        DeleteDynamicText();
        GameObject textStory = Instantiate(TextTemplate) as GameObject;
        textStory.SetActive(true);
        textStory.GetComponent<ButtonListButton>().SetText("You climb down through the hole in the floor, using the ladder that leads into the darkness. Once your feet are on the ground, you shine your lantern around to see the table and numerous cabinets and chests in the room.");
        textStory.transform.SetParent(TextTemplate.transform.parent, false);

    }

    private void PrintExploreTreasureRoom( )
    {
        DeleteDynamicText();
        GameObject textStory = Instantiate(TextTemplate) as GameObject;
        textStory.SetActive(true);
        textStory.GetComponent<ButtonListButton>().SetText("Moving away from the ladder, deeper into the room, you begin opening cabinet doors and drawers. You find many exotic artifacts such as jewelery, silks, figurines made of precious metals, collections of coins and even art. These are all things that your grandfather must have valued a lot and travelled to many exotic places to get.");
        textStory.transform.SetParent(TextTemplate.transform.parent, false);

    }

    private void PrintUpstairsHallway( )
    {
        DeleteDynamicText();
        GameObject textStory = Instantiate(TextTemplate) as GameObject;
        textStory.SetActive(true);
        textStory.GetComponent<ButtonListButton>().SetText("You enter a hallway on the second floor of the manor. Along the walls are more art displays. There are stairs that lead down to the first floor and a door that leads to the master bedroom. There are archways that lead to two other hallways.");
        textStory.transform.SetParent(TextTemplate.transform.parent, false);

    }

    private void PrintFirstHallway( )
    {
        DeleteDynamicText();
        GameObject textStory = Instantiate(TextTemplate) as GameObject;
        textStory.SetActive(true);
        textStory.GetComponent<ButtonListButton>().SetText("You enter another hallway from the main hall of the second floor. Here you see a door to the guest room, an open arch way to the main hall and another arch way into another hall.");
        textStory.transform.SetParent(TextTemplate.transform.parent, false);

    }

    private void PrintSecondHallway( )
    {
        DeleteDynamicText();
        GameObject textStory = Instantiate(TextTemplate) as GameObject;
        textStory.SetActive(true);
        textStory.GetComponent<ButtonListButton>().SetText("You walk down a new hallway lined with several paintings of landscapes. You see a few potted plants in this hall as well. There is a set of stairs leading up to the third floor attic room and an arch way going to the previous hall.");
        textStory.transform.SetParent(TextTemplate.transform.parent, false);

    }

    private void PrintExploreSecondHallway( )
    {
        DeleteDynamicText();
        GameObject textStory = Instantiate(TextTemplate) as GameObject;
        textStory.SetActive(true);
        textStory.GetComponent<ButtonListButton>().SetText("You move slowly along the hall, examining the paintings. There is one of a mountain landscape, one of a beach with a setting sun, one of horses running across rolling fields and a number of others. While doing so, you realize that the painting of the horses has something behind it. When you move the painting, you see a button behind the lower corner of the frame.");
        textStory.transform.SetParent(TextTemplate.transform.parent, false);

    }

    private void PrintPushButton( )
    {
        DeleteDynamicText();
        GameObject textStory = Instantiate(TextTemplate) as GameObject;
        textStory.SetActive(true);
        textStory.GetComponent<ButtonListButton>().SetText("The button presses in easily when you push it. There is a click just before a stone door opens.");
        textStory.transform.SetParent(TextTemplate.transform.parent, false);

    }

    private void PrintMasterBedroom( )
    {
        DeleteDynamicText();
        GameObject textStory = Instantiate(TextTemplate) as GameObject;
        textStory.SetActive(true);
        textStory.GetComponent<ButtonListButton>().SetText("You enter a spacious bedroom furnished with a large bed, a luxurious chair that sits near the fireplace, a side table and a bookshelf.");
        textStory.transform.SetParent(TextTemplate.transform.parent, false);

    }

    private void PrintExploreMasterBedroom( )
    {
        DeleteDynamicText();
        GameObject textStory = Instantiate(TextTemplate) as GameObject;
        textStory.SetActive(true);
        textStory.GetComponent<ButtonListButton>().SetText("You walk around the room, exploring it. The blankets that cover the bed are soft and there is a single candle that sits on the bedside table. The arm chair is well cushioned as it partially faces the fire. Several literature books fill the shelves of the bookshelf.");
        textStory.transform.SetParent(TextTemplate.transform.parent, false);

    }

    private void PrintReadMasterBedroom( )
    {
        DeleteDynamicText();
        GameObject textStory = Instantiate(TextTemplate) as GameObject;
        textStory.SetActive(true);
        textStory.GetComponent<ButtonListButton>().SetText("You select a book titled Poetry for the Ages. When you try to pull it off the shelf, however, it only partially moves. The bookshelf then moves, swinging inward revealing another room.");
        textStory.transform.SetParent(TextTemplate.transform.parent, false);

    }

    private void PrintWalkInCloset( )
    {
        DeleteDynamicText();
        GameObject textStory = Instantiate(TextTemplate) as GameObject;
        textStory.SetActive(true);
        textStory.GetComponent<ButtonListButton>().SetText("You enter the large walk in closet. There is a dresser against the wall on the left and the right. Many nice articles of clothing hang from rods.");
        textStory.transform.SetParent(TextTemplate.transform.parent, false);

    }

    private void PrintStatueRoom( )
    {
        DeleteDynamicText();
        GameObject textStory = Instantiate(TextTemplate) as GameObject;
        textStory.SetActive(true);
        textStory.GetComponent<ButtonListButton>().SetText("When you enter this room, your lantern illuminates the statues standing in each corner of the room. Each are differently dressed, but all of them look like warriors from different places. In the center of the room, there is a free standing mirror supported by a metal stand.");
        textStory.transform.SetParent(TextTemplate.transform.parent, false);

    }

    private void PrintGuestRoom( )
    {
        DeleteDynamicText();
        GameObject textStory = Instantiate(TextTemplate) as GameObject;
        textStory.SetActive(true);
        textStory.GetComponent<ButtonListButton>().SetText("This bedroom looks a lot like the master bedroom, except that it is smaller. There is no fireplace, but there are bookshelves and potted plants that decorate the room.");
        textStory.transform.SetParent(TextTemplate.transform.parent, false);

    }

    private void PrintExploreGuestRoom( )
    {
        DeleteDynamicText();
        GameObject textStory = Instantiate(TextTemplate) as GameObject;
        textStory.SetActive(true);
        textStory.GetComponent<ButtonListButton>().SetText("You examine the room, taking time to look at the small flowers growing off the plants. You browse over the titles of the books on the bookshelves. When you walk to the other side of the room to investigate the bedside table, you notice that there is a slight lump in the rug. You decide to pull the rug back to see what it is and see a handle to a trap door.");
        textStory.transform.SetParent(TextTemplate.transform.parent, false);

    }

    private void PrintGuestWalkInCloset( )
    {
        DeleteDynamicText();
        GameObject textStory = Instantiate(TextTemplate) as GameObject;
        textStory.SetActive(true);
        textStory.GetComponent<ButtonListButton>().SetText("You step into this walk in closet and find that it is not quite as big as the one in the master bedroom. It only has one dresser inside that is red in color. There are also fewer clothes hanging up.");
        textStory.transform.SetParent(TextTemplate.transform.parent, false);

    }

    private void PrintExploreGuestWalkInCloset( )
    {
        DeleteDynamicText();
        GameObject textStory = Instantiate(TextTemplate) as GameObject;
        textStory.SetActive(true);
        textStory.GetComponent<ButtonListButton>().SetText("You decide to look through the clothes hanging up, finding them to be what you would expect to see people wear. You look through the drawers of the dresser, finding more clothes that are neatly folded. The only difference is when you try to open the bottum drawer, it opens only part way. The dresser then slides into a new position to reveal a hidden door.");
        textStory.transform.SetParent(TextTemplate.transform.parent, false);

    }

    private void PrintRoyalRoom( )
    {
        DeleteDynamicText();
        GameObject textStory = Instantiate(TextTemplate) as GameObject;
        textStory.SetActive(true);
        textStory.GetComponent<ButtonListButton>().SetText("When you enter this room, it looks like another closet. The difference is, though, that the clothes here are much fancier. Not only are there clothes, but there are crowns and circlets, septors and staves. On one wall is a full length mirror.");
        textStory.transform.SetParent(TextTemplate.transform.parent, false);

    }

    private void PrintServantHall( )
    {
        DeleteDynamicText();
        GameObject textStory = Instantiate(TextTemplate) as GameObject;
        textStory.SetActive(true);
        textStory.GetComponent<ButtonListButton>().SetText("This is a mostly plain hall with a few places to sit and a couple side tables.There are stairs going down to a hallway, a door to servant quarters and a door to Servant Bathrooms.");
        textStory.transform.SetParent(TextTemplate.transform.parent, false);

    }

    private void PrintServantQuarters( )
    {
        DeleteDynamicText();
        GameObject textStory = Instantiate(TextTemplate) as GameObject;
        textStory.SetActive(true);
        textStory.GetComponent<ButtonListButton>().SetText("This is a simply decorated room. There are a handful of beds and a small dresser for each and a writing desk. There is a door to the servant hall.");
        textStory.transform.SetParent(TextTemplate.transform.parent, false);

    }

    private void PrintServantBathrooms( )
    {
        DeleteDynamicText();
        GameObject textStory = Instantiate(TextTemplate) as GameObject;
        textStory.SetActive(true);
        textStory.GetComponent<ButtonListButton>().SetText("This is a large bathroom with more than one toilet seperated by partial stone wall dividers. There are also a pair of bathing pools and a pair of sinks. There is a door to the servant hall.");
        textStory.transform.SetParent(TextTemplate.transform.parent, false);

    }

    private void PrintMirrorRoom( )
    {
        DeleteDynamicText();
        GameObject textStory = Instantiate(TextTemplate) as GameObject;
        textStory.SetActive(true);
        textStory.GetComponent<ButtonListButton>().SetText("This small room has nothing in it except a mirror that seems to be hovering in the air. You are able to walk around it and see your reflection on both sides.");
        textStory.transform.SetParent(TextTemplate.transform.parent, false);

    }

    private void PrintAtticRoom( )
    {
        DeleteDynamicText();
        GameObject textStory = Instantiate(TextTemplate) as GameObject;
        textStory.SetActive(true);
        textStory.GetComponent<ButtonListButton>().SetText("There is not much in this room aside from a few boxes stacked on each other. There is a fair amount of dust on everything. There is a set of stairs going down into a hallway and a door to additional attic space.");
        textStory.transform.SetParent(TextTemplate.transform.parent, false);

    }

    private void PrintSecondaryAtticSpace( )
    {
        DeleteDynamicText();
        GameObject textStory = Instantiate(TextTemplate) as GameObject;
        textStory.SetActive(true);
        textStory.GetComponent<ButtonListButton>().SetText("You see more boxes and chests in this room and more furniture covered by sheets. There is a door to the other attic space and a door to more storage");
        textStory.transform.SetParent(TextTemplate.transform.parent, false);

    }

    private void PrintExploreSecondaryAttic( )
    {
        DeleteDynamicText();
        GameObject textStory = Instantiate(TextTemplate) as GameObject;
        textStory.SetActive(true);
        textStory.GetComponent<ButtonListButton>().SetText("You start looking through boxes and chests of drawers. You find many things from old furniture to art pieces to old toys. In one of the boxes, you find a slender wooden box. When you open it, you find a necklace that is made of silver and gold.");
        textStory.transform.SetParent(TextTemplate.transform.parent, false);

    }

    private void PrintMoreStorage( )
    {
        DeleteDynamicText();
        GameObject textStory = Instantiate(TextTemplate) as GameObject;
        textStory.SetActive(true);
        textStory.GetComponent<ButtonListButton>().SetText("There are many more dressers and cabinets in this room as well as boxes and chests. There's a door to the secondary attick space here.");
        textStory.transform.SetParent(TextTemplate.transform.parent, false);

    }

}
