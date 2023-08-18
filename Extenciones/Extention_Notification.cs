using Microsoft.JSInterop;

namespace Sistema_Guarderia.Extenciones
{
    public static class Extention_Notificacion
    {
        public static Task MostrarMensaje(this IJSRuntime js, string titulo, string mensaje, TipoMensajeSweetAlert tipoMensajeSweetAlert)
        {
            //Convertir de ValueTask a Task
            Task task = Task.FromResult(js.InvokeAsync<object>("Swal.fire", titulo, mensaje, tipoMensajeSweetAlert.ToString()));
            //Returnando el Task
            return task;
        }

        public async static Task<bool> Confirmar(this IJSRuntime js, string titulo, string mensaje, TipoMensajeSweetAlert tipoMensajeSweetAlert)
        {
            //Convertir de ValueTask a Task
            return await js.InvokeAsync<bool>("CustomConfirm", titulo, mensaje, tipoMensajeSweetAlert.ToString());
        }
    }
    public enum TipoMensajeSweetAlert
    {
        question, warning, error, success, info
    }
}
