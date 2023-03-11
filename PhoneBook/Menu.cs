using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhoneBook;

namespace PhoneBook
{
    public static class Menu
    {

        #region MAIN MENU

        public const string MENU_MAIN =
    "\n" +
    "  ========== MAIN MENU =========\n\n" +
    "  1. Show all contacts\n" +
    "  2. Add new contact\n" +
    "  3. Delete contact by Id\n" +
    "  4. Find contact\n" +
    "  5. Exit\n\n" +
    "  ==============================\n\n" +
    "  Input menu item: ";


        public const string GO_TO_MAIN_MENU =
            "\n" +
            "  Go to main menu press y: ";

        #endregion


        #region CONTACT LIST

        public const string MENU_ALL_CONTACT =
   "\n" +
   " ====================== CONTACT LIST ======================\n";

        public const string TABLE_LINE =
            "\n" +
            " |------|--------------|---------------|------------------|";

        public const string TABLE_HEADER =
            "\n" +
            " |  ID  |  First name  |  Last name    |   Phone number   |";

        #endregion


        #region FIND CONTACT

        public const string MENU_FIND =
    "\n" +
    "  ======== FIND CONTACT ========\n\n" +
    "  1. By First name\n" +
    "  2. By Last name\n" +
    "  3. By phone number\n" +
    "  ==============================\n\n" +
    "  Input menu item: ";

        //public const string MENU_FIND =
        //    "\n" +
        //    "  ======== FIND CONTACT ========\n\n" +
        //    "  1. By First name\n" +
        //    "  2. By Last name\n" +
        //    "  3. By phone number\n" +
        //    "  4. By Id\n\n" +
        //    "  ==============================\n\n" +
        //    "  Input menu item: ";

        public const string MENU_FIND_BY_FIRST_NAME =
            "\n" +
            "  ======== FIND CONTACT ========\n" +
            "  ==============================\n\n" +
            "  Input First name: ";

        public const string MENU_FIND_BY_LAST_NAME =
            "\n" +
            "  ======== FIND CONTACT ========\n" +
            "  ==============================\n\n" +
            "  Input Last name: ";

        public const string MENU_FIND_BY_PHONE_NUMBER =
            "\n" +
            "  ======== FIND CONTACT ========\n" +
            "  ==============================\n\n" +
            "  Input Phone number: ";

        public const string MENU_FIND_BY_ID =
            "\n" +
            "  ======== FIND CONTACT ========\n" +
            "  ==============================\n\n" +
            "  Input Id: ";
        #endregion


        #region CREATE CONTACT

        public const string MENU_CREATE_CONTACT =
    "\n" +
    "  ======= CREATE CONTACT =======\n" +
    "  ==============================\n\n";

        public const string MENU_INPUT_ID =
             "  Input Id: ";

        public const string MENU_INPUT_FIRST_NAME =
             "  Input First name: ";

        public const string MENU_INPUT_LAST_NAME =
            "  Input Last name: ";

        public const string MENU_INPUT_PHONE_NUMBER =
            "  Input phone number (ex.+380671184475)\n" +
            "                       : ";

        public const string CONTACT_SAVED =
            "\n" +
            "  The Contact has been successfully saved.";

        #endregion


        #region DELETE CONTACT

        public const string MENU_DELETE_CONTACT =
    "\n" +
    "  ======= DELETE CONTACT =======\n" +
    "  ==============================\n\n";

        public const string DELETE_CONTACT =
            "  To delete selected contact press ENTER";

        public const string CONTACT_DELETED =
            "\n" +
            "  The Contact has been successfully deleted.";

        #endregion


        #region EXIT
        
        public const string ASK_TO_EXIT =
    "\n" +
    "  Do you want exit? (y/n) ";


        public const string GOODBAY =
            "\n" +
            "  =========== Goodbay =========="; 

        #endregion

    }
}