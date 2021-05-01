using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTextManager : MonoBehaviour
{
    [SerializeField]
    private Text buttonText;
    [SerializeField]
    private Text storyText;

    //public Text gameText;
    //public Button estateButton;
    //public Button lakeButton;
    //public Button mainEntryButton;
    //public Button gardensButton;

    public void SetButtonText(string butText, string theStoryString)
    {
        buttonText.text = butText;
        storyText.text = theStoryString;
    }

    public void ChangeGameScene(string butText, string theStoryString)
    {
      //  buttonText.text = butText;
        if(buttonText.text =="lake")
        {
            buttonText.text = "estate";
            //storyText.text = theStoryString;
            storyText.text = "You walk through green grass that is so tall that it reaches your knees.It makes walking a little slow at first, but you soon find a worn path to follow. In the distance, you see a brown horse with white on its nose grazing.As you pass, it looks in your direction, then returns to grazing.";
            //for(int i =0;i<3;i++)
            //{
            //    GameObject button = Instantiate(ButtonTemplate) as GameObject;
            //    button.SetActive(true);

            //    button.GetComponent<buttonlistb>
            //}
        }
    }
    public void MySceneChange()
    {

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
