using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using IronHelmOrderSystem.Entities;
using IronHelmOrderSystem.Models;
using IronHelmOrderSystem.Presenters;
using IronHelmOrderSystem.Views;

namespace IronHelmOrderSystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // configure data directory
            var dir = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            AppDomain.CurrentDomain.SetData("DataDirectory", dir);

            EntertainmentScheduleModel.RegisterSchedule();
            GovernmentScheduleModel.RegisterSchedule();
            CollectorScheduleModel.RegisterSchedule();

            // Main Menu UI
            MainMenuUI mainMenuUI = new MainMenuUI();
            MainMenuPresenter mainMenuPresenter = new MainMenuPresenter();
            mainMenuUI.Register(mainMenuPresenter);
            Application.Run(mainMenuUI);
        }
    }
}
