// See https://aka.ms/new-console-template for more information


internal class Ticket
{

public string userName;
public string email;
public string issue;
public string priority;
public int ticketNumber;
public string remarks;

public Ticket (string userName, string email, string issue, string priority, int ticketNumber, string remarks)
{
    this.userName = userName;
    this.email = email;
    this.issue = issue;
    this.priority = priority;
    this.ticketNumber = ticketNumber;
    this.remarks = remarks;

    Console.WriteLine("A ticket has been created.");

}

public void ShowDetails()
{
    Console.WriteLine("Name: " + userName);
    Console.WriteLine("Email: " + email);
    Console.WriteLine("Issue: " + issue);
    Console.WriteLine("Priority: " + priority);


}


public string getName{
    get{return userName;}
}

public string getEmail
{
    get{return email;}
}

public string getIssue
{
    get{return issue;}
}

public string getPriority
{
    get{return priority;}
}

public string getRemarks
{
    get{return remarks;}
}

}

