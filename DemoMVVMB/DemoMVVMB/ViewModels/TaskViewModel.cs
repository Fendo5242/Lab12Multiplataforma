using DemoMVVMB.Models;
using DemoMVVMB.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace DemoMVVMB.ViewModels
{
    public class TaskViewModel : ViewModelBase
    {
        string title;
        public string Title
        {
            get { return title; }
            set
            {
                if (title != value)
                {
                    title = value;
                    OnPropertyChanged();
                }
            }
        }
        string description;
        public string Description
        {
            get { return description; }
            set
            {
                if (description != value)
                {
                    description = value;
                    OnPropertyChanged();
                }
            }
        }
        bool status;
        public bool Status
        {
            get { return status; }
            set
            {
                if (status != value)
                {
                    status = value;
                    OnPropertyChanged();
                }
            }
        }

        ObservableCollection<TaskModel> tasks;
        public ObservableCollection<TaskModel> Tasks
        {
            get { return tasks; }
            set
            {
                if (tasks != value)
                {
                    tasks = value;
                    OnPropertyChanged();
                }
            }
        }

        public ICommand Grabar { get; set; }

        public ICommand Listar { get; set; }

        public TaskViewModel()
        {
            // Inicializa la colección Tasks
            Tasks = new ObservableCollection<TaskModel>();

            Grabar = new Command(() => {
                // Crea un nuevo objeto TaskModel
                TaskModel task = new TaskModel();
                task.Title = this.Title;
                task.Description = this.Description;
                task.Status = this.Status;

                // Agrega el nuevo objeto a la colección
                Tasks.Add(task);

                // Limpia los campos después de grabar
                Title = string.Empty;
                Description = string.Empty;
                Status = false;
            });

            Listar = new Command(() =>
            {
                Console.WriteLine("Listar button clicked"); // Asegúrate de que este mensaje aparezca en la consola
                MostrarLista();
            });
        }

        private void MostrarLista()
        {
            // Aquí puedes agregar lógica adicional si es necesario
            // Por ejemplo, puedes imprimir en la consola o realizar alguna operación específica.
            foreach (var task in Tasks)
            {
                Console.WriteLine($"Title: {task.Title}, Description: {task.Description}, Status: {task.Status}");
            }
        }
    }
}
