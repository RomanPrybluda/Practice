using PhoneBook;

var setWin = new ConsoleWindowProperty();
setWin.SetWindowProperty();
var csvFileManager = new PhoneBookManager();

while (true)
{   
    Console.Write(Menu.MENU_MAIN);
    int menuItem;
    menuItem = Convert.ToInt32(Console.ReadLine());
    Console.Clear();

    switch (menuItem)
    {

        case 1: // SHOW ALL CONTACT
            {                
                csvFileManager.DisplayAllContacts();
                break;
            }

        case 2: // CREATE_CONTACT
            {
                csvFileManager.AddContact();
                break;
            }

        case 3: // DELETE_CONTACT
            {
                csvFileManager.DeleteContactById();
                break;
            }

        case 4: // FIND_CONTACT
            {
                csvFileManager.FindContacts();
                break;
            }
            
        case 5: // EXIT
            {
                var close = new CloseApp();
                close.CloseApplication();
                break;
            }

        default:
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\n  Input correct item menu, please (1-2-3-4-5).");
                Console.ForegroundColor = ConsoleColor.White;
                break;
            }
    }

    Console.Write("\n" + Menu.GO_TO_MAIN_MENU);
    string goToMainMenu = Console.ReadLine();

    if (goToMainMenu.ToLower() == "y")
    {
        Console.Clear();
    }

}