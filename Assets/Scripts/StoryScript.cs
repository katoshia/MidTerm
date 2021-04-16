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
        
    }

    //Options for The Estate
    //Go Inside the estate, Main Entry Hall
    //Vist the gardens
    //Cross the fields to the lake.

    void PrintTheEstate()
    {
        Console.WriteLine("Lord Shuran Dunkeld, your grandfather, is known for being a warrior, a leader and sometimes an adventurer in the service of the king. Recently, you and your family have moved into the Dunkeld estate due to rumors about your grandfather disappearing, and even being dead. While your parents handle the responsibilities of the estate, you have been left to explore as you wish.");
        Console.WriteLine("");
        Console.WriteLine("You currently stand at the bottum of the stairs leading up to the front doors of the estate. You can smell the sweet scent of flowers from the nearby gardens and can see the waters of a rather large lake in the near distance, on the other side of some fields.");
    }

    //Options for The lake
    //Go for a swim
    //Go to the estate
    //Follow the trail to the backwoods

    void PrintTheLake()
    {
        Console.WriteLine("You walk through green grass that is so tall that it reaches your knees. It makes walking a little slow at first, but you soon find a worn path to follow. In the distance, you see a brown horse with white on its nose grazing. As you pass, it looks in your direction, then returns to grazing.");
        Console.WriteLine("");
        Console.WriteLine("It doesn't take long to get to the shore of the lake. The grass thins out and ends as you step onto the lake's sandy beach. The water's edge reaches towards your feet, then retreats in small waves. There is a row boat tied to a post, with two oars inside. Further down the beach, you see another trail that leads in the direction of the back woods.");
    }

    //Options for Back Woods
    //Visit the lake
    //visit the gardnes
    //visit the crypt

    void PrintBackWoods()
    {
        Console.WriteLine("The trail you are following is all dirt and rock. As you near the tree line, you see just how big and tall the trees are. Clearly, they are very old trees that have been there a long time. Despite the sunny weather, the forest seems dark and spooky.");
        Console.WriteLine.("");
        Console.WriteLine("Eventually, the trail splits. One side of the split goes into the depths of the forest. The other way leads to an old stone structure, the Dunkeld family crypt. You see a pile of wood at the point the trail splits. Next to the wood pile is a stump with a chopping axe stuck in it.");
    }

}

