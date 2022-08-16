using AddressBookNew;

AddressBook address = new AddressBook();
int option = 1;

while (option != 4)
{
    Console.WriteLine("Please enter a Num: 1- add , 2 - edit, 3 - display, 4 - exit: ");
    option = int.Parse(Console.ReadLine().ToLower());

    switch (option)
    {
        case 1:
            address.AddNewContact();
            break;
        case 2:
            address.EditContact();
            break;
        case 3:
            address.Display();
            break;
        default:
            break;
    }
}