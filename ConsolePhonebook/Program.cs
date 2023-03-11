/* Телефонная книга.

//  Меню с пунктами:
//  1. Показать все контакты
//  2. Добавить контакт
//  3. Удалить контакт
//  4. Поиск
//  5. Выход

// Контакт - это Id, Имя, Фамилия, номер телефона.
// При выборе любого пункта меню очищается консоль.
// После выполнения любой операции спрашивать пользователя 
о возврате в основное меню.

// Показать все контакты - вывести ВСЮ информацию по каждому контакту.
// Добавить контакт - просить пользователя поочередно ввести каждый из параметров контакта.
// Удаление контакта - попросить ввести Id контакта, далее удалить указанный. 
// Поиск - при переходе в поиск, показывать меню с выбором критеря поиска,
// далее осуществить поиск и показать данные контакта.

// Запись инфо производить в файл, после изменений файл должен перезаписываться.

// Реализовать приложение руководствуясь принципами ООП. */


/* class Person
// string firstName, string lastName, string phoneNumber;

// interface IRepository

// interface IPersonDataCreate: IRepository
// void PersonDataCreate(string firstName, string lastName, string phoneNumber);
// check Matching with exist PersonData;

// interface IPersonDataDelete: IRepository
// void PersonDataDelete(int id);

// file PhoneBook.csv

// interface IDataIO

// interface IOutputData:IDataIO

// interface IInputData:IDataIO
// void PersonGetByFirstName(string firstName);
// void PersonGetByLastName(string lastName);
// void PersonGetByPhoneNumber(string phoneNumber);

// List<PersonData> ReportAllData;
// List<PersonData> ReportByFirstName(string firstName);
// List<PersonData> ReportByLastName(string lastName);
// List<PersonData> ReportByPhoneNumber(string phoneNumber);
*/


using ConsolePhoneBook;
using System.Reflection.PortableExecutable;
using static System.Net.Mime.MediaTypeNames;
using static System.Environment;
using System.Text;
using System.Collections.Immutable;
using System.IO;



string goToMainMenu;

do
{

    // Console window property

    Console.Title = "===== Phone Book =====";
    Console.BackgroundColor = ConsoleColor.DarkBlue;
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.White;
    Console.WindowWidth = 80;

    int menuItem;
    bool menuItemIsCorrected;
    string exit;

    string id;
    string firstName;
    string lastName;
    string phoneNumber;

    string[] oneString;



    do
    {
        Console.Write(Menu.MENU_MAIN);
        menuItem = Convert.ToInt32(Console.ReadLine());
        List<Reader> contacts = new List<Reader>();
        


        switch (menuItem)
        {
            case 1:
                {
                    menuItemIsCorrected = true;
                    Console.Clear();

                    using (StreamReader readContact = new StreamReader(@"G:\Repository\Practice\ConsolePhonebook\PhoneBook\PhoneBook.csv"))
                    {
                        while (!readContact.EndOfStream)
                        {
                            string str = readContact.ReadLine();
                            oneString = str.Split(new char[] { ',' });
                            contacts.Add(new Reader(oneString[0], oneString[1], oneString[2], oneString[3]));
                        }
                    }

                    static void ShowReaders(List<Reader> readContact)
                    {
                        Console.Write(Menu.TABLE_LINE);
                        Console.Write(Menu.TABLE_HEADER);
                        Console.Write(Menu.TABLE_LINE);

                        foreach (Reader x in readContact)
                        {
                            Console.Write($"\n | {x.Id,3}  | {x.FirstName,-12} | {x.LastName,-12} | {x.PhoneNumber,-12}   |");
                            Console.Write(Menu.TABLE_LINE);

                        }
                    }

                    ShowReaders(contacts);

                    break;
                }
            case 2:
                {
                    menuItemIsCorrected = true;
                    Console.Clear();
                    
                    Console.Write(Menu.MENU_CREATE_CONTACT);
                    Console.Write(Menu.MENU_INPUT_ID);
                    id = Console.ReadLine();
                    Console.Write(Menu.MENU_INPUT_FIRST_NAME);
                    firstName = Console.ReadLine();
                    Console.Write(Menu.MENU_INPUT_LAST_NAME);
                    lastName = Console.ReadLine();
                    Console.Write(Menu.MENU_INPUT_PHONE_NUMBER);
                    phoneNumber = Console.ReadLine();

                    string file = @"G:\Repository\Practice\ConsolePhonebook\PhoneBook\PhoneBook.csv";
                    String separator = ",";
                    StringBuilder output = new StringBuilder();

                    string newContact = string.Format("{0}, {1}, {2}, {3}", id, firstName, lastName, phoneNumber);
                    output.AppendLine(string.Join(separator, newContact));
                    
                    try
                    {
                        File.AppendAllText(file, output.ToString());
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Data could not be written to the CSV file.");
                        return;
                    }

                    Console.Write(Menu.CONTACT_SAVED);

                    break;
                }
            case 3:
                {
                    menuItemIsCorrected = true;
                    Console.Clear();
                    Console.Write(Menu.MENU_DELETE_CONTACT);
                    Console.Write(Menu.MENU_INPUT_ID);
                    id = Console.ReadLine();
                    break;
                }
            case 4:
                {
                    menuItemIsCorrected = true;
                    Console.Clear();
                    Console.Write(Menu.MENU_FIND);
                    menuItem = Convert.ToInt32(Console.ReadLine());
                    break;
                }
            case 5:
                {
                    menuItemIsCorrected = true;
                    Console.Clear();
                    Console.Write(Menu.ASK_TO_EXIT);
                    exit = Console.ReadLine();

                    if (exit == "y")
                    {
                        Console.Write(Menu.GOODBAY);
                        Thread.Sleep(1500);
                        Environment.Exit(0);
                    }

                    Console.Clear();
                    break;
                }
            default:
                {
                    menuItemIsCorrected = false;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"  Input correct item menu, please (1-2-3-4-5).");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                }

        }


    }

    while (menuItemIsCorrected == false);


    Console.Write("\n" + Menu.GO_TO_MAIN_MENU);
    goToMainMenu = Console.ReadLine();

    if (goToMainMenu.ToLower() == "y")
    {
        Console.Clear();
    }

}

while (goToMainMenu.ToLower() == "y");