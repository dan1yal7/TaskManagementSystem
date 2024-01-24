using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskSystem
{
    class TaskManager
    { 
        List<Tasko> tasks = new List<Tasko>();
         

        /// <summary>
        /// Добавление задачи
        /// </summary>
        /// <param name="task"></param>
        public void AddTask(Tasko task )
        {
            if(tasks.Any(t => t.Id == task.Id))
            {
                Console.WriteLine("Error: Task with this Id is already exists");
                return; 
            }
            tasks.Add(task);
            Console.WriteLine("Task has been added successfully");
        }
          

        /// <summary>
        /// Просмотр задачи
        /// </summary>
        public void ViewTask()
        {
            Console.WriteLine(" Here the list of tasks for developers:");
            foreach (var task in tasks)
            {
                Console.WriteLine($" TaskId: {task.Id}, Description: {task.Description}, Assignee: {task.Assignee}, " +
                    $"Priority: {task.Priority}, Status: {task.Status}, Create At: {task.CreatedAt}");
            }

        } 
        

        /// <summary>
        /// Изменение задчи
        /// </summary>
        /// <param name="taskToUpdate"></param>
        public void ChangeTask(Tasko taskToUpdate)
        {
            // Поиск задачи в списке по идентификатору
            Tasko existingTask = tasks.FirstOrDefault(t => t.Id == taskToUpdate.Id); 

            if (existingTask != null)
            {
                existingTask.Description = taskToUpdate.Description;
                existingTask.Assignee = taskToUpdate.Assignee;
                existingTask.Priority = taskToUpdate.Priority;
                existingTask.Status = taskToUpdate.Status;

                Console.WriteLine($"Task ID {taskToUpdate.Id} has been successfully updated.");
            }
            else
            {
                Console.WriteLine($"Error: Task with ID {taskToUpdate.Id} not found.");
            }
        }


        /// <summary>
        ///Фильтрация задач по списку
        /// </summary>
        /// <param name="taskFIlter"></param>
        public void FilterTask(Tasko taskFilter)
        {
            var taskoFilter = tasks
                .Where(task =>
                    task.Id == taskFilter.Id &&
                    task.Description == taskFilter.Description &&
                    task.Assignee == taskFilter.Assignee &&
                    task.Priority == taskFilter.Priority &&
                    task.Status == taskFilter.Status &&
                    task.CreatedAt == taskFilter.CreatedAt)
                .ToList();

            foreach (var task in taskoFilter)
            {
                Console.WriteLine(task);
            }
        }
         /// <summary>
         /// Удаление задачи
         /// </summary>
         /// <param name="taskToDelete"></param>
        public void DeleteTask(Tasko taskToDelete)
        {
            var itemToRemove = tasks.Single(t => t.Id == taskToDelete.Id); 
            tasks.Remove(itemToRemove);

            Console.WriteLine(" Task has been deleted");

        }
     
    }
}
