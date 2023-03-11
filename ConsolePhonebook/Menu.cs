using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePhoneBook
{
    public class Menu
    {
        public const string MENU_MAIN =
            "\n" +
            "  ===== MAIN MENU =====\n" +
            "  1. Show all contacts\n" +
            "  2. Add new contact\n" +
            "  3. Delete contact\n" +
            "  4. Find contact\n" +
            "  5. Exit\n" +
            "  =====================\n" +
            "  Input menu item: ";

        public const string MENU_FIND =
            "\n" +
            "  === FIND CONTACT ===\n" +
            "  1. By First Name\n" +
            "  2. By Last Name\n" +
            "  3. By phone number\n" +
            "  4. By Id\n" +
            "  ====================\n" +
            "  Input menu item: ";

        public const string MENU_CREATE_CONTACT =
            "\n" +
            "  == CREATE CONTACT ==\n" +
            "  ====================\n";

        public const string MENU_INPUT_ID =
             "  Input Id: ";

        public const string MENU_INPUT_FIRST_NAME =
             "  Input First Name: ";

        public const string MENU_INPUT_LAST_NAME =
            "  Input Last Name: ";

        public const string MENU_INPUT_PHONE_NUMBER =
            "  Input phone number (ex.+380671184475)\n" +
            "                       : ";

        public const string MENU_DELETE_CONTACT =
            "\n" +
            "  == DELETE CONTACT ==\n" +
            "  ====================\n";

        public const string DELETE_CONTACT =
            "  To delete selected contact press ENTER";

        public const string TABLE_LINE =
            "\n" +
            " |------|--------------|--------------|------------------|";

        public const string TABLE_HEADER =
            "\n" +
            " |  ID  |  First Name  |  Last Name   |   Phone number   |";
            
        public const string GO_TO_MAIN_MENU =
            "\n" +
            "  Go to main menu press y: ";

        public const string ASK_TO_EXIT =
            "\n" +
            "  Do you want exit? (y/n) ";


        public const string GOODBAY =
            "\n" +
            "  ===== Goodbay =====";

        public const string CONTACT_SAVED =
            "\n" +
            "  The Contact has been successfully saved.";
    }
}