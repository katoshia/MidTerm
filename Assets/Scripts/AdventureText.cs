using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    class AdventureText
    {

        public void PrintIntroduction(GameObject textStory)
        {
            textStory = Instantiate(TextTemplate) as GameObject;
            textStory.SetActive(true);
            textStory.GetComponent<ButtonListButton>().SetText("Lord Shuran Dunkeld, your grandfather, is known for being a warrior, a leader and sometimes an adventurer in the service of the king. Recently, you and your family have moved into the Dunkeld estate due to rumors about your grandfather disappearing, and even being dead. While your parents handle the responsibilities of the estate, you have been left to explore as you wish. You currently stand at the bottum of the stairs leading up to the front doors of the estate. You can smell the sweet scent of flowers from the nearby gardens and can see the waters of a rather large lake in the near distance, on the other side of some fields.");
            textStory.transform.SetParent(TextTemplate.transform.parent, false);

        }

        public void PrintMainEntry(GameObject textStory)
        {
            textStory = Instantiate(TextTemplate) as GameObject;
            textStory.SetActive(true);
            textStory.GetComponent<ButtonListButton>().SetText("You enter the main entry hall. Pillars, suits of armor and benches line the walls of this room.There is also a large chandelier that hangs from the ceiling and a decorative red and gold rug that covers most of the polished stone floor.There are stairs that lead up to a hallway and a door that goes to the library.");
            textStory.transform.SetParent(TextTemplate.transform.parent, false);

        }

        public void PrintGoOutside(GameObject textStory)
        {
            textStory = Instantiate(TextTemplate) as GameObject;
            textStory.SetActive(true);
            textStory.GetComponent<ButtonListButton>().SetText("You currently stand at the bottum of the stairs leading up to the front doors of the estate. You can smell the sweet scent of flowers from the nearby gardens and can see the waters of a rather large lake in the near distance, on the other side of some fields.");
            textStory.transform.SetParent(TextTemplate.transform.parent, false);

        }

    }
}
