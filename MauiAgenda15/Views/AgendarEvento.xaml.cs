using MauiAgenda15.Models; 
namespace MauiAgenda15.Views; 

 

public partial class AgendarEvento : ContentPage 

{ 

    public AgendarEvento() 

    { 

        InitializeComponent(); 
        dtpck_inicio.MinimumDate = DateTime.Now;
        dtpck_inicio.MaximumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, DateTime.Now.Day);
        dtpck_termino.MinimumDate = dtpck_inicio.Date;
        dtpck_termino.MaximumDate = dtpck_inicio.MaximumDate.AddDays(10); 
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
 

        try 

        { 

            Evento E = new Evento 

            { 

                NomeDoEvento = nome_evento.Text,
                DataInicio = dtpck_inicio.Date,
                DataTermino = dtpck_termino.Date,
                QntParticipantes = Convert.ToInt32(qnt_Participantes.Text),
                LocalEvento = local_evento.Text,
                ValorParticipante = Convert.ToInt32(valor_participante.Text), 

            }; 

 

            await Navigation.PushAsync(new Views.Agendado()
            { 

                BindingContext = E 

            }); 

        } 
        catch (Exception ex) 

        { 

            DisplayAlert("Ops!", ex.Message, "Ok"); 

        } 

 

    } 

} 