using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface INotificable
{
    void Notificar(string mensaje);
}

// Implementación de la notificación por correo electrónico
public class NotificacionEmail : INotificable
{
    private string direccionCorreo;

    public NotificacionEmail(string correo)
    {
        direccionCorreo = correo;
    }

    public void Notificar(string mensaje)
    {
        Console.WriteLine($"Enviando correo electrónico a {direccionCorreo}: {mensaje}");
    }
}

// Implementación de la notificación por WhatsApp
public class NotificacionWhatsapp : INotificable
{
    private string numeroTelefono;

    public NotificacionWhatsapp(string telefono)
    {
        numeroTelefono = telefono;
    }

    public void Notificar(string mensaje)
    {
        Console.WriteLine($"Enviando mensaje por WhatsApp al número {numeroTelefono}: {mensaje}");
    }
}

// Implementación de la notificación por SMS
public class NotificacionSMS : INotificable
{
    private string numeroTelefono;

    public NotificacionSMS(string telefono)
    {
        numeroTelefono = telefono;
    }

    public void Notificar(string mensaje)
    {
        Console.WriteLine($"Enviando SMS al número {numeroTelefono}: {mensaje}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Ejemplo de uso de las notificaciones
        NotificacionEmail emailNotificacion = new NotificacionEmail("correo@example.com");
        emailNotificacion.Notificar("¡Hola! Este es un mensaje de prueba.");

        NotificacionWhatsapp whatsappNotificacion = new NotificacionWhatsapp("+1234567890");
        whatsappNotificacion.Notificar("¡Hola! Este es un mensaje de prueba.");

        NotificacionSMS smsNotificacion = new NotificacionSMS("+1234567890");
        smsNotificacion.Notificar("¡Hola! Este es un mensaje de prueba.");

    }
}