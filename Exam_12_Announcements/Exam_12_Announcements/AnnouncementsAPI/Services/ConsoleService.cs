using System;
using System.Collections.Generic;
using System.Text;

namespace AnnouncementsAPI.Services
{
    public class ConsoleService
    {
        private readonly EditorService _editorService;

        public ConsoleService()
        {
            _editorService = new EditorService();
            DisplayWelcomeMessage();
        }

        public bool IsOver { get; set; }

        private const string CommandExit = "EXIT";
        private const string CommandClear = "CLEAR";
        private const string CommandHelp = "HELP";
        private const string CommandDelete = "DELETE";
        private const string CommandList = "LIST";
        private const string CommandEdit = "EDIT";
        private const string CommandDetails = "DETAILS";
        private const string CommandAdd = "ADD";
        private const string CommandSearch = "SEARCH";
        private const string src = @"saves.json";

        private void DisplayWelcomeMessage()
        {
            Console.WriteLine();
            Console.WriteLine("Welcome to Announcements API");
            PrintAvaielableCommands();
            Console.WriteLine();
        }
        internal void Begin()
        {
            while (true)
            {
                var input = ProcessInput();
                ExecuteCommand(input);
                if (IsOver)
                    return;
            }
        }

        private string ProcessInput()
        {
            Console.WriteLine();
            Console.Write("Enter one of available command: ");
            var input = Console.ReadLine();
            return input;
        }

        private void ExecuteCommand(string command)
        {
            switch (command.ToUpper())
            {
                case CommandExit:
                    IsOver = true;
                    Console.WriteLine("Уou left the editor");
                    break;
                case CommandClear:
                    Console.Clear();
                    break;
                case CommandHelp:
                    PrintAvaielableCommands();
                    break;
                case CommandAdd:
                    _editorService.AddAnnouncement();
                    break;
                case CommandEdit:
                    _editorService.EditAnnouncement();
                    break;
                case CommandList:
                    _editorService.LoadListOfAnnouncement();
                    break;
                case CommandDelete:
                    _editorService.DeleteAnnoucement();
                    break;
                case CommandDetails:
                    _editorService.DetailsOfAnnouncement();
                    break;
                case CommandSearch:
                    _editorService.SearchAnnouncement();
                    break;
            }
        }
        private void PrintAvaielableCommands()
        {
            Console.WriteLine("Available commands:");
            Console.WriteLine($"{CommandExit.ToLower()} - leave editor");
            Console.WriteLine($"{CommandClear.ToLower()} - clear console");
            Console.WriteLine($"{CommandHelp.ToLower()} - display abailable commands");
            Console.WriteLine($"{CommandAdd.ToLower()} - add announcement");
            Console.WriteLine($"{CommandDelete.ToLower()} - delete announcement");
            Console.WriteLine($"{CommandList.ToLower()} - load list of announcements");
            Console.WriteLine($"{CommandDetails.ToLower()} - continue game");
            Console.WriteLine($"{CommandEdit.ToLower()} - edit announcement");
            Console.WriteLine($"{CommandSearch.ToLower()} - search announcement");
        }
    }
}
