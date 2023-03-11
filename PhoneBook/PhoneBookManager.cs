using Cake.Core.IO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace PhoneBook
{
    public class PhoneBookManager
    {
        private const string FILE_PATH = @"G:\Repository\Practice\PhoneBook\PhoneBook.csv";
        

        public void DisplayAllContacts()
        {
            Console.Write(Menu.MENU_ALL_CONTACT);

            var rows = ReadPhoneBook();
            if (rows.Count == 0)
            {
                Console.WriteLine("File is empty");
            }
            else
            {
                Console.Write(Menu.TABLE_LINE);
                Console.Write(Menu.TABLE_HEADER);
                Console.Write(Menu.TABLE_LINE);

                foreach (var row in rows)
                {
                    Console.Write($"\n | {row.Id,3}  | {row.FirstName,-12} | {row.LastName,-12}  |  {row.PhoneNumber,-12}   |");
                    Console.Write(Menu.TABLE_LINE);
                }
            }
        }

        public void AddContact()
        {
            //string id = Convert.ToString(File.ReadAllText(FILE_PATH) + 1);

            Console.Write(Menu.MENU_CREATE_CONTACT);
            
            Console.Write(Menu.MENU_INPUT_ID);
            string id = Console.ReadLine();
            Console.Write(Menu.MENU_INPUT_FIRST_NAME);
            string firstName = Console.ReadLine();
            Console.Write(Menu.MENU_INPUT_LAST_NAME);
            string lastName = Console.ReadLine();
            Console.Write(Menu.MENU_INPUT_PHONE_NUMBER);
            string phoneNumber = Console.ReadLine();
            
            var rows = ReadPhoneBook();
            var newPerson = new Person { Id = id, FirstName = firstName, LastName = lastName, PhoneNumber = phoneNumber };
            rows.Add(newPerson);
            WritePhoneBook(rows);
            Console.Write(Menu.CONTACT_SAVED);
        }

        public void DeleteContactById()
        {
            Console.Write(Menu.MENU_DELETE_CONTACT);
            Console.Write(Menu.MENU_INPUT_ID);
            string idToDelete = Console.ReadLine();
            var rows = ReadPhoneBook();
            var rowToDelete = rows.FirstOrDefault(row => row.Id == idToDelete);

            if (rowToDelete == null)
            {
                Console.Write("\n  Contact with id {0} did't found", idToDelete);
            }
            else
            {
                rows.Remove(rowToDelete);
                WritePhoneBook(rows);
                Console.Write(Menu.DELETE_CONTACT);
                Console.ReadKey();
                Console.Write(Menu.CONTACT_DELETED);
            }
        }

        public void FindContacts()
        {
            Console.Write(Menu.MENU_FIND);

            int itemMenuFind = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            if (itemMenuFind == 1)
            {
                Console.Write(Menu.MENU_FIND_BY_FIRST_NAME);
            }

            if (itemMenuFind == 2)
            {
                Console.Write(Menu.MENU_FIND_BY_LAST_NAME);
            }

            if (itemMenuFind == 3)
            {
                Console.Write(Menu.MENU_FIND_BY_PHONE_NUMBER);
            }

            //if (itemMenuFind == 4)
            //{
            //    Console.Write(Menu.MENU_INPUT_ID);
            //}

            string searchValue = Console.ReadLine();


            var rows = ReadPhoneBook();
            var foundContacts = rows.Where(row => row.Id.Contains(searchValue) || row.FirstName.Contains(searchValue)
                || row.LastName.Contains(searchValue) || row.PhoneNumber.Contains(searchValue)).ToList();

            if (foundContacts.Count == 0)
            {
                Console.WriteLine("This contact is not in the list");
            }
            else
            {
                Console.WriteLine("\n  Searching results:");
                
                Console.Write(Menu.TABLE_LINE);
                Console.Write(Menu.TABLE_HEADER);
                Console.Write(Menu.TABLE_LINE);

                foreach (var row in foundContacts)
                {
                    Console.Write($"\n | {row.Id,3}  | {row.FirstName,-12} | {row.LastName,-12}  |  {row.PhoneNumber,-12}   |");
                    Console.Write(Menu.TABLE_LINE);
                }
            }
        }

        private List<Person> ReadPhoneBook()
        {
            var rows = new List<Person>();
            if (File.Exists(FILE_PATH))
            {
                using (var reader = new StreamReader(FILE_PATH))
                {
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(',');
                        var row = new Person { Id = values[0], FirstName = values[1], LastName = values[2], PhoneNumber = values[3] };
                        rows.Add(row);
                    }
                }
            }
            return rows;
        }

        private void WritePhoneBook(List<Person> rows)
        {
            using (var writer = new StreamWriter(FILE_PATH))
            {
                foreach (var row in rows)
                {
                    writer.WriteLine("{0},{1},{2},{3}", row.Id, row.FirstName, row.LastName, row.PhoneNumber);
                }
            }
        }

    }
}