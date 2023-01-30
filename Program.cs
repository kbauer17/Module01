// See https://aka.ms/new-console-template for more information
string file = "Tickets.csv";
string choice;
do
{
    // ask user a question
    Console.WriteLine("1) Read data from file.");
    Console.WriteLine("2) Create file from data.");
    Console.WriteLine("Enter any other key to exit.");
    // input response
    choice = Console.ReadLine();

    if (choice == "1")
    {
        // read data from file
        if (File.Exists(file))
        {
            // read data from file
            StreamReader sr = new StreamReader(file);
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                // convert string to array
                string[] arr = line.Split('|');
                // display array data
                Console.WriteLine("Ticket ID: {0}, Summary: {1}, Status:  {2}, Priority:  {3}, Submitter:  {4}, Assigned:  {5}, Watcher:  {6}", arr[0], arr[1], arr[2],arr[3], arr[4], arr[5], arr[6]);
                
            }
            sr.Close();
            
        }
        else
        {
            Console.WriteLine("File does not exist");
        }
    }
    else if (choice == "2")
    {
        // create file from data
            StreamWriter sw = new StreamWriter(file);
            for (int i = 0; i < 7; i++)
            {
                // ask a question
                Console.WriteLine("Enter a ticket (Y/N)?");
                // input the response
                string resp = Console.ReadLine().ToUpper();
                // if the response is anything other than "Y", stop asking
                if (resp != "Y") { break; }
                // prompt for a ticket id number
                Console.WriteLine("Enter a Ticket Number: ");
                // save the Ticket id number
                string id = Console.ReadLine();
                // prompt for ticket Summary
                Console.WriteLine("Enter a Summary for the ticket:  ");
                // save the ticket Summary
                string summary = Console.ReadLine();
                // prompt for ticket status
                Console.WriteLine("Enter the ticket status (open/closed).");
                // save the ticket status
                string status = Console.ReadLine();
                // prompt for priority
                Console.WriteLine("Enter the ticket priority (high/low).");
                // save the ticket priority
                string priority = Console.ReadLine();
                // prompt for the name of the ticket submitter
                Console.WriteLine("Enter the name of the person submitting the ticket.");
                // save the name of the submitter
                string submitter = Console.ReadLine();
                // prompt for the name of the person to whom the ticket is assigned
                Console.WriteLine("Enter the name of the person to whom the ticket is assigned.");
                // save the name of the assignee
                string assigned = Console.ReadLine();
                // prompt for the name of the ticket watcher
                Console.WriteLine("Enter the name of the person watching the ticket.");
                // save the name of the watcher
                string watcher = Console.ReadLine();
                sw.WriteLine("{0}|{1}|{2}|{3}|{4}|{5}|{6}",id,summary, status,priority,submitter,assigned,watcher);
                
            }
            sw.Close();
    }
} while (choice == "1" || choice == "2");

