using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryScript : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Each function is for a button.
        //For scene after mouse clicking on New game
        void PrintIntroduction()
        {
                print("Lord Shuran Dunkeld, your grandfather, is known for being a warrior, a leader and sometimes an adventurer in the service of the king. Recently, you and your family have moved into the Dunkeld estate due to rumors about your grandfather disappearing, and even being dead. While your parents handle the responsibilities of the estate, you have been left to explore as you wish. You currently stand at the bottum of the stairs leading up to the front doors of the estate. You can smell the sweet scent of flowers from the nearby gardens and can see the waters of a rather large lake in the near distance, on the other side of some fields.");
            
        }

        //When Go Outside is selected

        void PrintOutsideEstate()
        {
                print("You currently stand at the bottum of the stairs leading up to the front doors of the estate. You can smell the sweet scent of flowers from the nearby gardens and can see the waters of a rather large lake in the near distance, on the other side of some fields.");

            }
        

        //For when Go inside the Estate is chosen. There should be a Go Outside, Go into the library and Go into the hall options. This hall will be FirstFloorHallway.

        void PrintMainEntry()
        {
                print("You enter the main entry hall. Pillars, suits of armor and benches line the walls of this room.There is also a large chandelier that hangs from the ceiling and a decorative red and gold rug that covers most of the polished stone floor.There are stairs that lead up to a hallway and a door that goes to the library.");
            }
        
    }



}
