// See https://aka.ms/new-console-template for more information

using System.Collections;

List<Ticket> openTickets = new List<Ticket>();
List<Ticket> resolvedTickets = new List<Ticket>();
List<Ticket> assignedTickets = new List<Ticket>();
List<Ticket> unassignedTickets = new List<Ticket>();
List<Ticket> robTickets = new List<Ticket>();
List<Ticket> jonTickets = new List<Ticket>();
List<Ticket> branTickets = new List<Ticket>();
List<Ticket> rickonTickets = new List<Ticket>();
List<Ticket> remarksTickets= new List<Ticket>();




int ticketNumber = 0;
Console.Clear();

bool displayMenu = false;

do{
    Console.WriteLine("Main Menu");
    Console.WriteLine(" ");
    Console.WriteLine("Who is using this system?");
    Console.WriteLine("1. User");
    Console.WriteLine("2. Technician");
    Console.WriteLine("3. Exit");
    Console.WriteLine(" ");
    string selection = Console.ReadLine();


    Console.Clear();

    if(selection == "1" || selection == "1.")
    {

            UserMenu();
            string userChoice = Console.ReadLine();
            Console.Clear();

            if(userChoice == "1" || userChoice == "1.")
            {
                Console.Write("Enter name: ");
                string name = Console.ReadLine();
                Console.Write("Enter email: ");
                string email = Console.ReadLine();
                Console.Write("What is your issue? ");
                string issue = Console.ReadLine();
                Console.Write("On a scale of 1 to 5, what is the priority level? ");
                string priority = Console.ReadLine();
                string remarks = " ";
                Console.Clear();
                
                ticketNumber++;
                Ticket ticket = new Ticket(name, email, issue, priority, ticketNumber, remarks);
                ticket.ShowDetails();
                Console.WriteLine(" ");
            
                openTickets.Add(ticket);
                unassignedTickets.Add(ticket);
                displayMenu = true;
            }
            else if(userChoice == "2" || userChoice == "2.")
            {
                
                ViewOpenTickets();
                displayMenu = true;

                
            }

            else if (userChoice == "3" || userChoice == "3.")
            {
                ViewResolvedTickets();               
                Console.WriteLine(" ");
                displayMenu = true;

            }

            else
            {
                displayMenu = true;
            }

        

        
    }

    else if (selection == "2" || selection == "2.")
    {
        

        
            Console.WriteLine("Select a technician:");
            Console.WriteLine("1. Rob");
            Console.WriteLine("2. Jon");
            Console.WriteLine("3. Bran");
            Console.WriteLine("4. Rickon");
            Console.WriteLine("5. Main Menu");
            Console.WriteLine(" ");
            string userChoice = Console.ReadLine();
            Console.Clear();


            if ( userChoice == "1" || userChoice == "1.")
            {
                TechMenu();
                string techChoice = Console.ReadLine();
                Console.Clear();

                if ( techChoice == "1" || techChoice == "1.")
                {
                    int numberofTickets = robTickets.Count();
                    Console.WriteLine("You have {0} assigned ticket(s)", numberofTickets);
                    if (numberofTickets <1)
                    {
                        displayMenu = true;
                    }
                    else
                    {
                        ViewRobTickets();
                        ActionMenu();
                        displayMenu = true;
                    }
                    
                }

                else if ( techChoice == "2" || techChoice == "2.")
                {
                    UnassignedMenu();
                }

                else
                {
                   
                    displayMenu = true;
    
                }
            } 
        
            
            else if ( userChoice == "2" || userChoice == "2.")
            {
                TechMenu();
                string tech2Choice = Console.ReadLine();
                Console.Clear();

                if ( tech2Choice == "1" || tech2Choice == "1.")
                {
                        int numberofTickets = jonTickets.Count();
                        Console.WriteLine("You have {0} assigned ticket(s)", numberofTickets);
                        if (numberofTickets <1)
                        {
                            displayMenu = true;
                        }
                        else
                        {
                            ViewJonTickets();
                            ActionMenu();
                            displayMenu = true;
                        }
                }

                else if ( tech2Choice == "2" || tech2Choice == "2.")
                {
                   UnassignedMenu();
                }

                else
                {

                    displayMenu = true;
                }


            }

            else if ( userChoice == "3" || userChoice == "3.")
                {
                    TechMenu();
                    string tech3Choice = Console.ReadLine();
                    Console.Clear();

                    if ( tech3Choice == "1" || tech3Choice == "1.")
                    {
                        int numberofTickets = branTickets.Count();
                        Console.WriteLine("You have {0} assigned ticket(s)", numberofTickets);
                        if (numberofTickets <1)
                        {
                            displayMenu = true;
                        }
                        else
                        { 
                            ViewBranTickets();
                            ActionMenu();
                            displayMenu = true;
                        }
                    }

                    else if ( tech3Choice == "2" || tech3Choice == "2.")
                    {
                        UnassignedMenu();
                    }
                    else
                    {
                        displayMenu = true;
                    }


                }

            else if ( userChoice == "4" || userChoice == "4.")
                {
                    TechMenu();
                    string tech4Choice = Console.ReadLine();
                    Console.Clear();

                   if ( tech4Choice == "1" || tech4Choice == "1.")
                    {
                        int numberofTickets = rickonTickets.Count();
                        Console.WriteLine("You have {0} assigned ticket(s)", numberofTickets);
                        if (numberofTickets <1)
                        {
                            displayMenu = true;
                        }
                        else
                        {
                        ViewRickonTickets();
                        ActionMenu();
                        
                        displayMenu = true;
                        }
                    }

                    else if ( tech4Choice == "2" || tech4Choice == "2.")
                    {
                        UnassignedMenu();

                    }

                    else
                    {
                        displayMenu = true;

                    }


                }
            else if ( userChoice == "5" || userChoice == "5." )
            {
                displayMenu = true;
            }

            else
            {
                Console.WriteLine("Invalid Selection");
                displayMenu= true;
            }

           
        
        

    }

    else if ( selection == "3" || selection == "3.")
            {
                Console.WriteLine("Goodbye");
                displayMenu= false;
            
            }
        

    else
    {
        Console.WriteLine("Invalid selection");
    }

} while (displayMenu);



//METHODS BELOW THIS LINE


void UserMenu()
{
    Console.WriteLine("What would you like to do?");
    Console.WriteLine("1. Create a ticket");
    Console.WriteLine("2. View open tickets");
    Console.WriteLine("3. View resolved tickets");
    Console.WriteLine("4. Main Menu");
    Console.WriteLine(" ");
}

void TechMenu()
{
   
    Console.WriteLine("1. View assigned open tickets");
    Console.WriteLine("2. View un-assigned open tickets");
    Console.WriteLine("3. Main Menu");
    Console.WriteLine(" ");

}

void TechSubMenu()
{
    Console.WriteLine("What would you like to do?");
    Console.WriteLine("1. Add a response ");
    Console.WriteLine("2. Mark ticket resolved");
    Console.WriteLine("3. Reassign ticket to a technician");
    Console.WriteLine("4. Main Menu");
    Console.WriteLine(" ");
}



void ActionMenu()
{
    Console.WriteLine("Would you like to address a ticket?");
    Console.WriteLine("1. Yes ");
    Console.WriteLine("2. No ");
    string address = Console.ReadLine();

    if (address == "1" || address == "Yes" || address == "yes")
    {
        
        Console.WriteLine("Enter the ticket number you wish to address:");

        int selectedTicket = Convert.ToInt32(Console.ReadLine());
        int i = selectedTicket;
        Console.WriteLine("");

        TechSubMenu();

        string subMenuChoice= Console.ReadLine();
        if (subMenuChoice == "1" || subMenuChoice == "1.")
        {
            Console.WriteLine("Add a response");
            AddRobResponse(i);
            AddJonResponse(i);
            AddBranResponse(i);
            AddRickonResponse(i);
            ActionMenu();

        }

        else if (subMenuChoice == "2" || subMenuChoice == "2.")
        {
            ResolveRobTicket(i);
            ResolveJonTicket(i);
            ResolveBranTicket(i);
            ResolveRickonTicket(i);

                                    
        }

        else if (subMenuChoice == "3" || subMenuChoice == "3.")
        {
            ReassignTicket(i);
                    
        }

        else
        {
        displayMenu = true;
        
        }
    }
    else
    {
        displayMenu = true;
    }
}



void ReassignTicket(int ticketID)
{
       
        int i = ticketID;
        Console.WriteLine("");

        Console.WriteLine("Who would you like to reassign this ticket to?");
        Console.WriteLine("1. Rob");
        Console.WriteLine("2. Jon");
        Console.WriteLine("3. Bran");
        Console.WriteLine("4. Rickon");
        Console.WriteLine("5. Main Menu");

        int techAssign = Convert.ToInt32(Console.ReadLine());

        if (techAssign == 1 )
            {
                RickonAssignRob(i);
                JonAssignRob(i);
                BranAssignRob(i);
            }
                                
        else if (techAssign == 2)
            {
                RobAssignJon(i);
                BranAssignJon(i);
                RickonAssignJon(i);
                
            }

        else if (techAssign == 3)
            {
                RobAssignBran(i);
                JonAssignBran(i);
                RickonAssignBran(i);
            }

        else if (techAssign == 4)
            {
                RobAssignRickon(i);
                JonAssignRickon(i);
                BranAssignRickon(i);
            }
                            
        else
            {
                displayMenu = true;
            }


}

void UnassignedMenu()
{
    Console.Clear();
    int numberofTickets = unassignedTickets.Count();
    Console.WriteLine("You have {0} unassigned ticket(s)", numberofTickets);

    if( numberofTickets < 1)
        { displayMenu = true; }
    else
    {
        ViewUnassignedTickets();
        Console.WriteLine("Would you like to assign a ticket to a technician?");
        Console.WriteLine("1. Yes");
        Console.WriteLine("2. No");

        string assign = Console.ReadLine();
        if (assign == "yes" || assign =="1")
        {
    //    AssignTicket();
            Console.WriteLine("Enter the ticket number you wish to assign:");
            int selectedTicket = Convert.ToInt32(Console.ReadLine());
            int i = selectedTicket;
            Console.WriteLine("");

            Console.WriteLine("Which technician would you like to assign this ticket to?");
            Console.WriteLine("1. Rob");
            Console.WriteLine("2. Jon");
            Console.WriteLine("3. Bran");
            Console.WriteLine("4. Rickon");
            Console.WriteLine("5. Main Menu");

            int techAssign = Convert.ToInt32(Console.ReadLine());

             if (techAssign == 1 )
            {
                AssignRobTicket(i);
                if( numberofTickets < 1)
                {
                    displayMenu = true;
                }
                else{
                    UnassignedMenu();
                }



            }
                                
            else if (techAssign == 2)
            {
                AssignJonTicket(i);
                if( numberofTickets < 1)
                {
                    displayMenu = true;
                }
                else{
                    UnassignedMenu();
                }
                
            }

            else if (techAssign == 3)
            {
                AssignBranTicket(i);
                if( numberofTickets < 1)
                {
                    displayMenu = true;
                }
                else{
                    UnassignedMenu();
                }

            }

            else if (techAssign == 4)
            {
                AssignRickonTicket(i);
                if( numberofTickets < 1)
                {
                    displayMenu = true;
                }
                else{
                    UnassignedMenu();
                }

            }
                            
            else
            {
                displayMenu = true;
            }



        }
        else
        {
            displayMenu = true;
        }
    }
}



void ViewOpenTickets()
{
    int numberofTickets = openTickets.Count();
    Console.WriteLine("You have {0} open ticket(s)", numberofTickets);
    Console.WriteLine("");

    foreach (Ticket ticket in openTickets)
    {
                    
    Console.WriteLine("Ticket Number: {0}", ticket.ticketNumber);        
    Console.WriteLine("Name: {0}", ticket.getName);
    Console.WriteLine("Email: {0}", ticket.getEmail);
    Console.WriteLine("Issue: {0}", ticket.getIssue);
    Console.WriteLine("Priority: {0}", ticket.getPriority);
    Console.WriteLine("Remarks: {0}", ticket.getRemarks);
    Console.WriteLine(" ");

    }
}

void ViewResolvedTickets()
{
    int numberofTickets = resolvedTickets.Count();
    Console.WriteLine("You have {0} resolved ticket(s)", numberofTickets);
    Console.WriteLine("");


    foreach (Ticket ticket in resolvedTickets)
    {
                    
    Console.WriteLine("Ticket Number: {0}", ticket.ticketNumber);        
    Console.WriteLine("Name: {0}", ticket.getName);
    Console.WriteLine("Email: {0}", ticket.getEmail);
    Console.WriteLine("Issue: {0}", ticket.getIssue);
    Console.WriteLine("Priority: {0}", ticket.getPriority);
    Console.WriteLine("Remarks: {0}", ticket.getRemarks);
    Console.WriteLine(" ");

    }
}



void AddRobResponse(int ticketID)
{
    var item = robTickets.SingleOrDefault(x => x.ticketNumber == ticketID);
        if (item != null)
        remarksTickets.Add(item);
    foreach (Ticket ticket in remarksTickets)
    { 
        ticket.remarks = Console.ReadLine();
    }
        remarksTickets.Remove(item);
}

void AddJonResponse(int ticketID)
{
    var item = jonTickets.SingleOrDefault(x => x.ticketNumber == ticketID);
        if (item != null)
        remarksTickets.Add(item);
    foreach (Ticket ticket in remarksTickets)
    { 
        ticket.remarks = Console.ReadLine();
    }
        remarksTickets.Remove(item);
}

void AddBranResponse(int ticketID)
{
    var item = branTickets.SingleOrDefault(x => x.ticketNumber == ticketID);
        if (item != null)
        remarksTickets.Add(item);
    foreach (Ticket ticket in remarksTickets)
    { 
        ticket.remarks = Console.ReadLine();
    }
        remarksTickets.Remove(item);
}

void AddRickonResponse(int ticketID)
{
    var item = rickonTickets.SingleOrDefault(x => x.ticketNumber == ticketID);
        if (item != null)
        remarksTickets.Add(item);
    foreach (Ticket ticket in remarksTickets)
    { 
        ticket.remarks = Console.ReadLine();
    }
        remarksTickets.Remove(item);
}



void ResolveRobTicket(int ticketID)
{
    var item = robTickets.SingleOrDefault(x => x.ticketNumber == ticketID);
        if (item != null)
        robTickets.Remove(item);
        if (item != null)
        resolvedTickets.Add(item);
        if (item != null)
        openTickets.Remove(item);
}

void ResolveJonTicket(int ticketID)
{
    var item = jonTickets.SingleOrDefault(x => x.ticketNumber == ticketID);
        if (item != null)
        jonTickets.Remove(item);
        if (item != null)
        resolvedTickets.Add(item);
        if (item != null)
        openTickets.Remove(item);
    
}

void ResolveBranTicket(int ticketID)
{
    var item = branTickets.SingleOrDefault(x => x.ticketNumber == ticketID);
        if (item != null)
        branTickets.Remove(item);
        if (item != null)
        resolvedTickets.Add(item);
        if (item != null)
        openTickets.Remove(item);
}

void ResolveRickonTicket(int ticketID)
{
    var item = rickonTickets.SingleOrDefault(x => x.ticketNumber == ticketID);
        if (item != null)
        rickonTickets.Remove(item);
        if (item != null)
        resolvedTickets.Add(item);
        if (item != null)
        openTickets.Remove(item);
}

void AssignRobTicket(int ticketID)
{
        var item = unassignedTickets.SingleOrDefault(x => x.ticketNumber == ticketID);
        if (item != null)
        robTickets.Add(item);
        if (item != null)
        unassignedTickets.Remove(item);

}

void RickonAssignRob(int ticketID)
{
        var item = rickonTickets.SingleOrDefault(x => x.ticketNumber == ticketID);
        if (item != null)
        robTickets.Add(item);
        if (item != null)
        rickonTickets.Remove(item);
}

void JonAssignRob(int ticketID)
{
        var item = jonTickets.SingleOrDefault(x => x.ticketNumber == ticketID);
        if (item != null)
        robTickets.Add(item);
        if (item != null)
        jonTickets.Remove(item);
}

void BranAssignRob(int ticketID)
{
        var item = branTickets.SingleOrDefault(x => x.ticketNumber == ticketID);
        if (item != null)
        robTickets.Add(item);
        if (item != null)
        branTickets.Remove(item);
}


void AssignJonTicket(int ticketID)
{
        var item = unassignedTickets.SingleOrDefault(x => x.ticketNumber == ticketID);
        if (item != null)
        jonTickets.Add(item);
        if (item != null)
        unassignedTickets.Remove(item);

}

void RobAssignJon(int ticketID)
{
        var item = robTickets.SingleOrDefault(x => x.ticketNumber == ticketID);
        if (item != null)
        jonTickets.Add(item);
        if (item != null)
        robTickets.Remove(item);
}

void BranAssignJon(int ticketID)
{
        var item = branTickets.SingleOrDefault(x => x.ticketNumber == ticketID);
        if (item != null)
        jonTickets.Add(item);
        if (item != null)
        branTickets.Remove(item);
}

void RickonAssignJon(int ticketID)
{
        var item = rickonTickets.SingleOrDefault(x => x.ticketNumber == ticketID);
        if (item != null)
        jonTickets.Add(item);
        if (item != null)
        rickonTickets.Remove(item);
}

void AssignBranTicket(int ticketID)
{
        var item = unassignedTickets.SingleOrDefault(x => x.ticketNumber == ticketID);
        if (item != null)
        branTickets.Add(item);
        if (item != null)
        unassignedTickets.Remove(item);

}

void RobAssignBran(int ticketID)
{
        var item = robTickets.SingleOrDefault(x => x.ticketNumber == ticketID);
        if (item != null)
        branTickets.Add(item);
        if (item != null)
        robTickets.Remove(item);
}

void JonAssignBran(int ticketID)
{
        var item = jonTickets.SingleOrDefault(x => x.ticketNumber == ticketID);
        if (item != null)
        branTickets.Add(item);
        if (item != null)
        jonTickets.Remove(item);
}

void RickonAssignBran(int ticketID)
{
        var item = rickonTickets.SingleOrDefault(x => x.ticketNumber == ticketID);
        if (item != null)
        branTickets.Add(item);
        if (item != null)
        rickonTickets.Remove(item);
}


void AssignRickonTicket(int ticketID)
{
        var item = unassignedTickets.SingleOrDefault(x => x.ticketNumber == ticketID);
        if (item != null)
        rickonTickets.Add(item);
        if (item != null)
        unassignedTickets.Remove(item);
}

void RobAssignRickon(int ticketID)
{
        var item = robTickets.SingleOrDefault(x => x.ticketNumber == ticketID);
        if (item != null)
        rickonTickets.Add(item);
        if (item != null)
        robTickets.Remove(item);
}

void JonAssignRickon(int ticketID)
{
        var item = jonTickets.SingleOrDefault(x => x.ticketNumber == ticketID);
        if (item != null)
        rickonTickets.Add(item);
        if (item != null)
        jonTickets.Remove(item);
}

void BranAssignRickon(int ticketID)
{
        var item = branTickets.SingleOrDefault(x => x.ticketNumber == ticketID);
        if (item != null)
        rickonTickets.Add(item);
        if (item != null)
        branTickets.Remove(item);
}

void ViewRobTickets()
{
    Console.WriteLine("");

    foreach (Ticket ticket in robTickets)
    {
    Console.WriteLine("Ticket Number: {0}", ticket.ticketNumber);        
    Console.WriteLine("Name: {0}", ticket.getName);
    Console.WriteLine("Email: {0}", ticket.getEmail);
    Console.WriteLine("Issue: {0}", ticket.getIssue);
    Console.WriteLine("Priority: {0}", ticket.getPriority);
    Console.WriteLine("Remarks: {0}", ticket.getRemarks);
    Console.WriteLine(" ");
    }
}

void ViewJonTickets()
{
    Console.WriteLine("");

    foreach (Ticket ticket in jonTickets)
    {
                    
    Console.WriteLine("Ticket Number: {0}", ticket.ticketNumber);        
    Console.WriteLine("Name: {0}", ticket.getName);
    Console.WriteLine("Email: {0}", ticket.getEmail);
    Console.WriteLine("Issue: {0}", ticket.getIssue);
    Console.WriteLine("Priority: {0}", ticket.getPriority);
    Console.WriteLine("Remarks: {0}", ticket.getRemarks);
    Console.WriteLine(" ");
    }
}

void ViewBranTickets()
{
    Console.WriteLine("");

    foreach (Ticket ticket in branTickets)
    {
                    
    Console.WriteLine("Ticket Number: {0}", ticket.ticketNumber);        
    Console.WriteLine("Name: {0}", ticket.getName);
    Console.WriteLine("Email: {0}", ticket.getEmail);
    Console.WriteLine("Issue: {0}", ticket.getIssue);
    Console.WriteLine("Priority: {0}", ticket.getPriority);
    Console.WriteLine("Remarks: {0}", ticket.getRemarks);
    Console.WriteLine(" ");
    }
}

void ViewRickonTickets()
{
    Console.WriteLine("");

    foreach (Ticket ticket in rickonTickets)
    {
                    
    Console.WriteLine("Ticket Number: {0}", ticket.ticketNumber);        
    Console.WriteLine("Name: {0}", ticket.getName);
    Console.WriteLine("Email: {0}", ticket.getEmail);
    Console.WriteLine("Issue: {0}", ticket.getIssue);
    Console.WriteLine("Priority: {0}", ticket.getPriority);
    Console.WriteLine("Remarks: {0}", ticket.getRemarks);
    Console.WriteLine(" ");
    }
}

void ViewUnassignedTickets()
{
    Console.WriteLine("");

    foreach (Ticket ticket in unassignedTickets)
    {
                    
    Console.WriteLine("Ticket Number: {0}", ticket.ticketNumber);        
    Console.WriteLine("Name: {0}", ticket.getName);
    Console.WriteLine("Email: {0}", ticket.getEmail);
    Console.WriteLine("Issue: {0}", ticket.getIssue);
    Console.WriteLine("Priority: {0}", ticket.getPriority);
    Console.WriteLine("Remarks: {0}", ticket.getRemarks);
    Console.WriteLine(" ");
    }
}



Console.ReadLine();












