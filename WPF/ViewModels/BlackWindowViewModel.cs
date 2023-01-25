﻿using BlackWindow.Models;
using ReactiveUI;
using System.Windows.Input;

namespace BlackWindow.ViewModels;

public class BlackWindowViewModel : ReactiveObject
{   
    public BlackWindowModel Model { get; }
    
    public BlackWindowViewModel(BlackWindowModel model)
    {
        Model = model;
        DeleteCommand = ReactiveCommand.Create<ImageModel>(Model.DeleteImage);
    }

    /// <summary>
    ///Команда удаления из коллекции по нажатию
    /// </summary>
    public ICommand DeleteCommand { get; }   
}
