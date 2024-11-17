using MauiAgenda15.Models;
namespace MauiAgenda15.Views; 

 

public partial class Agendado : ContentPage 

{ 

    public Agendado() 

    { 

        InitializeComponent(); 

    }

    private void Button_Clicked(object sender, EventArgs e)
    {
   try 

        { 

            Navigation.PopAsync(); 

        } 

        catch (Exception ex) 

        { 

            DisplayAlert("Ops!", ex.Message, "Ok"); 

        } 

    } 

} 