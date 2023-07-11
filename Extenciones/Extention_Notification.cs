using Radzen;

namespace Sistema_Guarderia.Extenciones
{
    public static class Extention_Notificacion
    {
       public static void ShowNotification(this NotificationService notifier, string mensaje, NotificationSeverity severity = NotificationSeverity.Success)
        {
            var message = new NotificationMessage
            {
                Severity = severity,
                Summary = mensaje
            };

            notifier.Notify(message);
        }

    }
}