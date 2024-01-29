using System.Threading.Tasks;
using TaskSystem;

TaskManager taskManager = new TaskManager();


bool showMenu = true; 

while (showMenu)
{
    showMenu = MainMenu();

}  

 bool MainMenu()
{

    Console.Clear();
    Console.WriteLine("Choose an option");
    Console.WriteLine("1.Add a task ");
    Console.WriteLine("2.View a task ");
    Console.WriteLine("3.Change a task");
    Console.WriteLine("4.Delete a task");
    Console.WriteLine("5.Filter a task");

    switch (Console.ReadLine())
    {
       
        case "1":

            AddTask();
            return true;
        case "2":
            taskManager.ViewTask();
            Console.ReadLine();///  нужно будет кое-что подправить 
            return true;
        case "3":
            ChangeTask();
            return true;
        case "4":
            DeleteTask();
            return true;
        case "5":
            FilterTask();
            return true;
        case "6":
            return false;
        default:
            return true;

    }


}


 void AddTask()
{
    Console.WriteLine("Enter task details:");
    Tasko newTask = new Tasko();
    Console.WriteLine("Enter Task ID:");
    newTask.Id = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter Task Description:");
    newTask.Description = Console.ReadLine();
    taskManager.AddTask(newTask);
    Console.ReadLine(); 
}

 void ChangeTask()
{
    Console.WriteLine("Enter task details to update:");
    Tasko taskToUpdate = new Tasko();
    Console.WriteLine("Enter Task ID:");
    taskToUpdate.Id = int.Parse(Console.ReadLine());
    taskManager.ChangeTask(taskToUpdate);
    Console.ReadLine(); 
}

void DeleteTask()
{
    Console.WriteLine("Enter task ID to delete:");
    Tasko taskToDelete = new Tasko();
    Console.WriteLine("Enter Task ID:");
    taskToDelete.Id = int.Parse(Console.ReadLine());
    taskManager.DeleteTask(taskToDelete);
    Console.ReadLine(); 
}


void FilterTask()
{
    Tasko taskFilter = new Tasko();
    Console.WriteLine("Enter Task ID:");
    taskFilter.Id = int.Parse(Console.ReadLine()); 
    taskManager.FilterTask(taskFilter); 
    Console.ReadLine();  
}