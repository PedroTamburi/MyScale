using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MyScale.App.Infra;
using MyScale.App.Pages;
using MyScale.Domain.Base;
using MyScale.Domain.Entities;
using MyScale.Domain.Interfaces;
using MyScale.Repository.Context;
using MyScale.Repository.Repository;
using MyScale.Service.Interfaces;
using MyScale.Service.Services;
using MyScale.Service.Validators;
using System.Windows.Forms;

namespace MyScale.App
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            
            ConfigureDI.ConfigureServices();

            var loginForm = ConfigureDI.ServiceProvider.GetRequiredService<LoginForm>();

            System.Windows.Forms.Application.Run(loginForm);
        }

    }
}