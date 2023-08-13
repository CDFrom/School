using System;
using System.Collections.Generic;

namespace Activity_02
{
    class Contact
    {
        public string Name { get; set; }
        public long Phone { get; set; }
    }
    class Program
    {
        public static void DisplayListAll(List<Contact> myList)
        {
            //This method is complete, you do not need to modify this method.
            if (myList.Count == 0)
            {
                Console.WriteLine("List is empty!");
            }
            else
            {
                Console.WriteLine("\nAll Contacts from the phonebook: \n");
                foreach (var item in myList)
                {
                    Console.WriteLine("Name: {0}, Phone: {1}", item.Name, item.Phone);
                }
            }
            
        }

        public static string ConvertToNameCase(string name)
        {
            //This method is complete, you do not need to modify this method.
            return name[0].ToString().ToUpper() + name.Substring(1);
        }













        //Complete the ToDo Methods, additionally, you may also add new methods, if you need.


        public static void DisplayAllContactsOfAUserName(List<Contact> myList) //you may change parameters if required
        {
            //ToDo
            //All contacts of a single user name
            //if an user have two contact number, print user name once followed by contact numbers
            //please see provided input/output for the formatting

            Console.WriteLine("\nAll Contacts of {0}:", myList[0].Name); //To keep proper format, note I use the first occurence of the name as it should
                                                                       //always be the same throughout and we know we should have at least position 0
                                                                       //or the first index
            foreach (var item in myList)
                Console.WriteLine($"Contact No {myList.IndexOf(item)+1}: {item.Phone}"); //Again keeping requested format of assignment
                                                                                         //I use IndexOf+1 to count my current position starting with 1
        }

        public static Contact FindContactGivenAPhone(List<Contact> myList, long phone)
        {
            //ToDo: remove the return null statement and complete the method
            //Note: this method should return a Contact object

            foreach(var item in myList)
                if(item.Phone == phone) return item; //Return the object when phone numbers match up
            
            return null; //I return null here in case no data can be obtained due to the number not being found by the foreach loop
                         //To be completely honest this was the quickest and easiest way I found it to work and made the most sense so I left
                         //the return null here instead of removing it, I hope this is okay
        }
        public static List<Contact> FindAllContactsOfAGivenName(List<Contact> myList, string name)
        {
            //ToDo: remove the return null statement and complete the method
            //Note: this method returns a List of Contacts; even if a single contact record exists for the given name

            List<Contact> ContactsOfGivenName = new List<Contact>(); //Create a list for the Contacts of the given name in order to store the needed numbers
            
            foreach (var item in myList)
                if (item.Name == name) ContactsOfGivenName.Add(new Contact() { Name = item.Name, Phone = item.Phone }); //Every time the name matches
                                                                                                                   //add to the list
            
            return ContactsOfGivenName; //Return the list to be looped through later in order to display the data retrieved
        }
        //ToDo Methods




        static void Main(string[] args)
        {
            List<Contact> contactList = new List<Contact>();
            string command;
            do
            {
                Console.WriteLine("\nEnter a command: ");
                command = Console.ReadLine();
                command = command.ToLower();
                while (command.Contains("  ")) command = command.Replace("  ", " ");   //replaces multiple spaces
                command = command.Trim();                                              //to remove single whitespces from start & end.
                var split = command.Split(null);
                if (split.Length == 1)
                {
                    //This conditional block is complete, you do not need to modify this block.
                    if (split[0] == "exit")
                    {
                        break;
                    }
                    else if (split[0] == "findall")
                    {
                        DisplayListAll(contactList);
                    }
                    
                }
                else if (split.Length == 0) continue; //this condition is for : "users entered nothing, stay in the loop and do nothing!"
                else if (split[0]=="add")
                {
                    //This conditional block is complete, you do not need to modify this block.
                    for (int i=1; i<split.Length-1; i++)
                    {
                        split[i] = ConvertToNameCase(split[i]);
                    }
                    contactList.Add(new Contact() { Name =string.Join(" ",split,1,split.Length-2), Phone =long.Parse(split[split.Length-1])});
                }
                else if (split[0] == "delete")
                {
                    //ToDo
                    //Complete this block
                    //separate the phone number from the 'split' array
                    //choose the method to find all contacts when given a phone number
                    //remove the contact from the contactList

                    long number = long.Parse(split[1]); //Get number and store it in a variable
                    contactList.Remove(FindContactGivenAPhone(contactList, number)); //Remove the contact found with the method using the given number
                }
                else if (split[0] == "find")
                {
                    //ToDo
                    //Complete this block
                    //separate the correctly formatted name from the 'split' array
                    //choose the method to find all contacts when given a user name
                    //choose method to display all contacts of that user name
                    //NB: A user name can have one or more contact numbers

                    for (int i = 1; i < split.Length; i++)
                    {
                        split[i] = ConvertToNameCase(split[i]); //Use a for loop to convert name to name case
                    }

                    string name = string.Join(" ", split, 1, split.Length - 1); //Join name into a single string
                    
                    var contactsOfGivenName = FindAllContactsOfAGivenName(contactList, name); //Find the contacts of a given name with the method,
                                                                                         //create a list and store it in a variable
                    
                    if(contactsOfGivenName.Count!=0) //Check that the list contains something, basically to see there was a contact found
                        DisplayAllContactsOfAUserName(contactsOfGivenName); //Call function to display contact info
                }
                else if (split[0] == "update")
                {
                    //ToDo update <Old Number> <Updated Name> <New Number>

                    //ToDo
                    //Complete this block
                    //separate old number from the 'split' array
                    //choose the method to find a contact when given the old phone number
                    //remove the contact containing the old phone number from the contactList
                    //extract the correctly formatted new user name <Updated Name> and the <New Number> from the 'split' array
                    //Add a new contact object into the contactList with <Updated Name> and <New Number>

                    long number = long.Parse(split[1]); //Get number and store it in a variable
                    contactList.Remove(FindContactGivenAPhone(contactList, number)); //Remove the contact found with the method using the given number
                    
                    for (int i = 2; i < split.Length - 1; i++) //Copied from "add" case but started i at 2 to ignore "update" and old number
                    {
                        split[i] = ConvertToNameCase(split[i]);
                    }

                    //Again copied from "add" but modified the values to account for "update" <Old Number> and <New Number>
                    contactList.Add(new Contact() { Name = string.Join(" ", split, 2, split.Length - 3), Phone = long.Parse(split[split.Length - 1]) });
                }
                else
                {
                    Console.WriteLine("Unknown command! \nPlease enter command in correct format...");
                }
            } while (true);
        }
    }
}
