using TaskSystem;

TaskManager taskManager = new TaskManager(); 


bool showMenu = true; 

while (showMenu)
{
    showMenu = MainMenu();

}  

static bool MainMenu()
{
    Console.Clear();
    Console.WriteLine("Choose an option");
    Console.WriteLine( "1. Add a task " );
    Console.WriteLine(" 2. View a task " );
    Console.WriteLine( "3. Change a task");
    Console.WriteLine( "4. De;ete a task");

    switch (Console.ReadLine())
    { 

            
    //}
      
}    
