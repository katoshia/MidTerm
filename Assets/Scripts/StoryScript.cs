using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryScript : MonoBehaviour
{

    // for Introduction when game starts.
    public text introText;
    public void PrintIntroText()
    {
        introText.text = "Lord Shuran Dunkeld, your grandfather, is known for being a warrior, a leader and sometimes an adventurer in the service of the king. Recently, you and your family have moved into the Dunkeld estate due to rumors about your grandfather disappearing, and even being dead. While your parents handle the responsibilities of the estate, you have been left to explore as you wish. You currently stand at the bottum of the stairs leading up to the front doors of the estate. You can smell the sweet scent of flowers from the nearby gardens and can see the waters of a rather large lake in the near distance, on the other side of some fields.";
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
