using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine.UI;
using UnityEngine;
using System.Collections;

public class StoryInf:buttonListControl
{
    public static void Lake(int optionCount) 
    {
    }
}
public  class StoryInfo : MonoBehaviour
{

    // lake - 3 - swim, estate, back woods
    public void Lake(int optionCount)
    {
        
    }
    // back woods - 3 - lake, gardens, crypt
    public static void BackWoods(int optionCount) { }
    // crypt - 4 - Go Inside Crypt, Forest, Gardens, Estate
    public static void Crypt(int optionCount) { }
    // inner crypt - 2 - Search Coffins, Leave Crypt
    public static void InnerCrype(int optionCount) { }
    // Search Coffins - 2 - close lid, Leave crypt
    public static void SearchCoffins(int optionCount) { }
    // gardens - 3 - lake, crypt, estate
    public static void Gardens(int optionCount) { }
    // main Entry Hall - Upstairs/Main Hall, Library, Explore Main Entry
    public static void MainEntryHall(int optionCount) { }
    // Explore main entry - 2 - Upstairs/Main Hall, Library
    public static void ExploreMainEntry(int optioinCount) { }
    // Upstairs/Main Hall - 4 - Second Floor, Sitting Room, Bathroom, Trophy Room
    public static void MainHallway(int optionCount) { }
    // Trophy Room - 3 - Main Hall, Library, Explore Trophy Room
    public static void Trophy(int optionCount) { }
    // Explore Trophy Room - 2 - Main Hall, library
    public static void ExploreTrophy(int optionCount) { }
    // library - 3 - trophy room, main hall, explore library
    public static void Library(int optionCount) { }
    // Explore Library - 3 - trophy room, main hall, read a book
    public static void ExploreLibrary(int optionCount) { }
    // Read a Book - 3 - Trophy room, Main Hall, Secret Room(library)
    public static void ReadLibraryBook(int optionCount) { }
    // Bathroom - 1 - Main Hall
    public static void Bathroom(int optionCount) { }
    // Secret Room - 2 - library, Explore Secret room
    public static void SecretLibraryRoom(int optionCount) { }
    // explore secret room - 1 - library
    public static void ExploreSecrectLibrary(int optionCount) { }
    // sitting room - 2 - main hall, dining room
    public static void SittingRoom(int optionCount) { }
    // dining room - 4 - sitting room, kitchen, pantry, Explore Dining Room
    public static void DiningRoom(int optionCount) { }
    // Explore Dining room - 3 - sitting room, kitchen, pantry
    public static void ExploreDiningRoom(int optionCount) { }
    // kitchen - small hallway, dining room, explore kitchen
    public static void Kitchen(int optionCount) { }
    // explore kitchen - 3 - small hallway, dining room, take a brownie
    public static void ExploreKitchen(int optionCount) { }
    // take brownie - 2 - small hallway, dining room
    public static void TakeBrownie(int optionCount) { }
    // pantry - 2 - dining room, explore pantry
    public static void Pantry(int optionCount) { }
    // explore pantry - dining room, pull lever
    public static void ExplorePantry(int optionCount) { }
    // pubb lever - 2 - dining room, pool room
    public static void PullLever(int optionCount) { }
    // small hallway - 2 - servant's hall, kitchen
    public static void SmallHallway(int optionCount) { }
    // pool room - 2 - pantry, explore pool room
    public static void PoolRoom(int optionCount) { }
    // explore pool room - 1 - pantry
    public static void ExplorePoolRoom(int optionCount) { }
    // treasure room - 2 - climb ladder(guest room), explore treasure room
    public static void TreasureRoom(int optionCount) { }
    // explore treasure room - 1 -climb ladder(guest room)
    public static void ExploreTreasureRoom(int optionCount) { }
    // 2nd floor - 4 - back downstairs, master bedroom, first hallway, 2nd hallway
    public static void SecondFloor(int optionCount) { }
    // 1st hallwall - 3 - guest room, 2nd floor hallway, 2nd hallway
    public static void FirstHallway(int optionCount) { }
    // 2nd hallway - 3 - 1st hallway, upstairs(attic room), Explore hallway
    public static void SecondHallway(int optionCount) { }
    // Explore 2nd hallway - 3 - 1st hall, upstairs(attic room), push button
    public static void ExploreSecondHallway(int optionCount) { }
    // push button - 3 - 1st hallway, upstairs(attic room), mirror room
    public static void PushButton(int optionCount) { }
    // master bedroom - 3 - 2nd floor hallway, walk-in closet, Explore master bedroom
    public static void MasterBedroom(int optionCount) { }
    // explore master bedroom - 3 - 2nd floor hallway, walk-in closet, read a book
    public static void ExploreMasterBedroom(int optionCount) { }
    // read a book(master Bedroom) - 3 - walk-in closet, 2nd floor hallway, statue room
    public static void ReadBedroomBook(int optionCount) { }
    // walk-in closet - 1 - master bedroom
    public static void MasterCloset(int optionCount) { }
    // statue room - 1 - master bedroom
    public static void StatueRoom(int optionCount) { }
    // guest room - 3 - 1st hallway, walk-in closet(guest room), explore guest room
    public static void GuestRoom(int optionCount) { }
    // explore guest room - 3 - 1st hallway, walk-in closet(guest room), climb down ladder(treasure room)
    public static void ExploreGuestRoom(int optionCount) { }
    // guest walk-in closet - 2 - guest bedroom, explore walk-in closet(guest room)
    public static void GuestCloset(int optionCount) { }
    // explore guest walk-in closet - 2 - guest bedroom, royal room
    public static void ExploreGuestCloset(int optionCount) { }
    // royal room - 1 -walk-in closet(guest room)
    public static void RoyalRoom(int optionCount) { }
    // servant's hall (small hallway) - 3 - downstairs to small hallway, servant quarters, servants bathroom
    public static void ServantsHall(int optionCount) { }
    // servant quarters - 1 - return to servant's hall
    public static void ServantsQuarters(int optionCount) { }
    // servant's bathroom - 1 - return to servant's hall
    public static void ServantsBathroom(int optionCount) { }
    // mirror room - 1 - 2nd hallway
    public static void MirrorRoom(int optionCount) { }
    // attic room - 2 - 2nd hallway, secondary attic room
    public static void AtticRoom(int optionCount) { }
    // secondary attic room - 3 - attic space, more storage, explore secondary attic room
    public static void SecondAtticRoom(int optionCount) { }
    // explore secondary attic room - 2 - attic space, more storage
    public static void ExploreSecondAtticRoom(int optionCount) { }
    // more storage 1 - return to secondary attic space
    public static void Storage(int optionCount) { }




}
