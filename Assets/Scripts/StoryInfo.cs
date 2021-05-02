//using System;
//using System.IO;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;


//namespace Assets.Scripts
//{
//    public class StoryInfo
//    {
//        // back woods - 3 - lake, gardens, crypt
//        private void BackWoods(int optionCount) { }
//        // crypt - 4 - Go Inside Crypt, Forest, Gardens, Estate
//        private void Crypt(int optionCount) { }
//        // inner crypt - 2 - Search Coffins, Leave Crypt
//        private void InnerCrype(int optionCount) { }
//        // Search Coffins - 2 - close lid, Leave crypt
//        private void SearchCoffins(int optionCount) { }
//        // gardens - 3 - lake, crypt, estate
//        private void Gardens(int optionCount) { }
//        // main Entry Hall - Upstairs/Main Hall, Library, Explore Main Entry
//        private void MainEntryHall(int optionCount) { }
//        // Explore main entry - 2 - Upstairs/Main Hall, Library
//        private void ExploreMainEntry(int optioinCount) { }
//        // Upstairs/Main Hall - 4 - Second Floor, Sitting Room, Bathroom, Trophy Room
//        private void MainHallway(int optionCount) { }
//        // Trophy Room - 3 - Main Hall, Library, Explore Trophy Room
//        private void Trophy(int optionCount) { }
//        // Explore Trophy Room - 2 - Main Hall, library
//        private void ExploreTrophy(int optionCount) { }
//        // library - 3 - trophy room, main hall, explore library
//        private void Library(int optionCount) { }
//        // Explore Library - 3 - trophy room, main hall, read a book
//        private void ExploreLibrary(int optionCount) { }
//        // Read a Book - 3 - Trophy room, Main Hall, Secret Room(library)
//        private void ReadLibraryBook(int optionCount) { }
//        // Bathroom - 1 - Main Hall
//        private void Bathroom(int optionCount) { }
//        // Secret Room - 2 - library, Explore Secret room
//        private void SecretLibraryRoom(int optionCount) { }
//        // explore secret room - 1 - library
//        private void ExploreSecrectLibrary(int optionCount) { }
//        // sitting room - 2 - main hall, dining room
//        private void SittingRoom(int optionCount) { }
//        // dining room - 4 - sitting room, kitchen, pantry, Explore Dining Room
//        private void DiningRoom(int optionCount) { }
//        // Explore Dining room - 3 - sitting room, kitchen, pantry
//        private void ExploreDiningRoom(int optionCount) { }
//        // kitchen - small hallway, dining room, explore kitchen
//        private void Kitchen(int optionCount) { }
//        // explore kitchen - 3 - small hallway, dining room, take a brownie
//        private void ExploreKitchen(int optionCount) { }
//        // take brownie - 2 - small hallway, dining room
//        private void TakeBrownie(int optionCount) { }
//        // pantry - 2 - dining room, explore pantry
//        private void Pantry(int optionCount) { }
//        // explore pantry - dining room, pull lever
//        private void ExplorePantry(int optionCount) { }
//        // pubb lever - 2 - dining room, pool room
//        private void PullLever(int optionCount) { }
//        // small hallway - 2 - servant's hall, kitchen
//        private void SmallHallway(int optionCount) { }
//        // pool room - 2 - pantry, explore pool room
//        private void PoolRoom(int optionCount) { }
//        // explore pool room - 1 - pantry
//        private void ExplorePoolRoom(int optionCount) { }
//        // treasure room - 2 - climb ladder(guest room), explore treasure room
//        private void TreasureRoom(int optionCount) { }
//        // explore treasure room - 1 -climb ladder(guest room)
//        private void ExploreTreasureRoom(int optionCount) { }
//        // 2nd floor - 4 - back downstairs, master bedroom, first hallway, 2nd hallway
//        private void SecondFloor(int optionCount) { }
//        // 1st hallwall - 3 - guest room, 2nd floor hallway, 2nd hallway
//        private void FirstHallway(int optionCount) { }
//        // 2nd hallway - 3 - 1st hallway, upstairs(attic room), Explore hallway
//        private void SecondHallway(int optionCount) { }
//        // Explore 2nd hallway - 3 - 1st hall, upstairs(attic room), push button
//        private void ExploreSecondHallway(int optionCount) { }
//        // push button - 3 - 1st hallway, upstairs(attic room), mirror room
//        private void PushButton(int optionCount) { }
//        // master bedroom - 3 - 2nd floor hallway, walk-in closet, Explore master bedroom
//        private void MasterBedroom(int optionCount) { }
//        // explore master bedroom - 3 - 2nd floor hallway, walk-in closet, read a book
//        private void ExploreMasterBedroom(int optionCount) { }
//        // read a book(master Bedroom) - 3 - walk-in closet, 2nd floor hallway, statue room
//        private void ReadBedroomBook(int optionCount) { }
//        // walk-in closet - 1 - master bedroom
//        private void MasterCloset(int optionCount) { }
//        // statue room - 1 - master bedroom
//        private void StatueRoom(int optionCount) { }
//        // guest room - 3 - 1st hallway, walk-in closet(guest room), explore guest room
//        private void GuestRoom(int optionCount) { }
//        // explore guest room - 3 - 1st hallway, walk-in closet(guest room), climb down ladder(treasure room)
//        private void ExploreGuestRoom(int optionCount) { }
//        // guest walk-in closet - 2 - guest bedroom, explore walk-in closet(guest room)
//        private void GuestCloset(int optionCount) { }
//        // explore guest walk-in closet - 2 - guest bedroom, royal room
//        private void ExploreGuestCloset(int optionCount) { }
//        // royal room - 1 -walk-in closet(guest room)
//        private void RoyalRoom(int optionCount) { }
//        // servant's hall (small hallway) - 3 - downstairs to small hallway, servant quarters, servants bathroom
//        private void ServantsHall(int optionCount) { }
//        // servant quarters - 1 - return to servant's hall
//        private void ServantsQuarters(int optionCount) { }
//        // servant's bathroom - 1 - return to servant's hall
//        private void ServantsBathroom(int optionCount) { }
//        // mirror room - 1 - 2nd hallway
//        private void MirrorRoom(int optionCount) { }
//        // attic room - 2 - 2nd hallway, secondary attic room
//        private void AtticRoom(int optionCount) { }
//        // secondary attic room - 3 - attic space, more storage, explore secondary attic room
//        private void SecondAtticRoom(int optionCount) { }
//        // explore secondary attic room - 2 - attic space, more storage
//        private void ExploreSecondAtticRoom(int optionCount) { }
//        // more storage 1 - return to secondary attic space
//        private void Storage(int optionCount) { }




//         if (theName == "Estate")
//        {
//            EstateButton(optionCount);
//    }
//        else if (theName == "Lake")
//        {
//            LakeButton(optionCount);
//    //Debug.Log(theName);
//}
//        else if (theName == "Back Woods")
//{
//    BackWoods(optionCount);
//}
//else if (theName == " Crypt")
//{
//    Crypt(optionCount);
//}
//else if (theName == " Inner Crypt")
//{
//    InnerCrypt(optionCount);
//}
//else if (theName == " Search Coffins")
//{
//    SearchCoffins(optionCount);
//}
//else if (theName == " Gardens")
//{
//    Gardens(optionCount);
//}
//else if (theName == " Main Entry")
//{
//    MainEntryHall(optionCount);
//}
//else if (theName == " Explore Main Entry")
//{
//    ExploreMainEntry(optionCount);
//}
//else if (theName == " Main Hall")
//{
//    MainHallway(optionCount);
//}
//else if (theName == " Trophy Room")
//{
//    Trophy(optionCount);
//}
//else if (theName == " Explore Trophy Room")
//{
//    ExploreTrophy(optionCount);
//}
//else if (theName == " Library")
//{
//    Library(optionCount);
//}
//else if (theName == " Explore Library")
//{
//    ExploreLibrary(optionCount);
//}
//else if (theName == " Read a book.")
//{
//    ReadLibraryBook(optionCount);
//}
//else if (theName == " Bathroom")
//{
//    Bathroom(optionCount);
//}
//else if (theName == " Secret Library Room")
//{
//    SecretLibraryRoom(optionCount);
//}
//else if (theName == " Explore Secret Room")
//{
//    ExploreSecrectLibrary(optionCount);
//}
//else if (theName == " Sitting Room")
//{
//    SittingRoom(optionCount);
//}
//else if (theName == " Dining Room")
//{
//    DiningRoom(optionCount);
//}
//else if (theName == " Explore Dining Room")
//{
//    ExploreDiningRoom(optionCount);
//}
//else if (theName == " Kitchen")
//{
//    Kitchen(optionCount);
//}
//else if (theName == " Explore Kitchen")
//{
//    ExploreKitchen(optionCount);
//}
//else if (theName == " Take brownie")
//{
//    TakeBrownie(optionCount);
//}
//else if (theName == " Pantry")
//{
//    Pantry(optionCount);
//}
//else if (theName == " Explore Pantry")
//{
//    ExplorePantry(optionCount);
//}
//else if (theName == " Pull Lever")
//{
//    PullLever(optionCount);
//}
//else if (theName == " Small hallway")
//{
//    SmallHallway(optionCount);
//}
//else if (theName == " Pool Room")
//{
//    PoolRoom(optionCount);
//}
//else if (theName == " Explore Pool Room")
//{
//    ExplorePoolRoom(optionCount);
//}
//else if (theName == " Treasure Room")
//{
//    TreasureRoom(optionCount);
//}
//else if (theName == " Explore Treasure Room")
//{
//    ExploreTreasureRoom(optionCount);
//}
//else if (theName == " Second Floor")
//{
//    SecondFloor(optionCount);
//}
//else if (theName == " First Hallway")
//{
//    FirstHallway(optionCount);
//}
//else if (theName == " Second Hallway")
//{
//    SecondHallway(optionCount);
//}
//else if (theName == " Explore the Hallway")
//{
//    ExploreSecondHallway(optionCount);
//}
//else if (theName == " Push the button")
//{
//    PushButton(optionCount);
//}
//else if (theName == " Master Bedroom")
//{
//    MasterBedroom(optionCount);
//}
//else if (theName == " Explore Master Bedroom")
//{
//    ExploreMasterBedroom(optionCount);
//}
//else if (theName == " Read the Book")
//{
//    ReadBedroomBook(optionCount);
//}
//else if (theName == " Large closet")
//{
//    MasterCloset(optionCount);
//}
//else if (theName == " Statue Room")
//{
//    StatueRoom(optionCount);
//}
//else if (theName == " Guest Room")
//{
//    GuestRoom(optionCount);
//}
//else if (theName == " Explore Guest Room")
//{
//    ExploreGuestRoom(optionCount);
//}
//else if (theName == " Small Closet")
//{
//    GuestCloset(optionCount);
//}
//else if (theName == " Explore the closet.")
//{
//    ExploreGuestCloset(optionCount);
//}
//else if (theName == " Roayl Room")
//{
//    RoyalRoom(optionCount);
//}
//else if (theName == " Servant's Hall")
//{
//    ServantsHall(optionCount);
//}
//else if (theName == " Servant's Quarters")
//{
//    ServantsQuarters(optionCount);
//}
//else if (theName == " Servant's Bathroom")
//{
//    ServantsBathroom(optionCount);
//}
//else if (theName == " Mirror Room")
//{
//    MirrorRoom(optionCount);
//}
//else if (theName == " Attic ")
//{
//    AtticRoom(optionCount);
//}
//else if (theName == " Second Attic Room")
//{
//    SecondAtticRoom(optionCount);
//}
//else if (theName == " Explore Second Room")
//{
//    ExploreSecondAtticRoom(optionCount);
//}
//else if (theName == " Storage")
//{
//    Storage(optionCount);
//}

//    }
//}
