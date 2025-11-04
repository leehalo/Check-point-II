public class whatsapp
{
    public void EnviarMensagem (string numero, TextMessage message)
    {
        console.writeLine ($"Enviando a mensagem de texto para o número {numero}");
    }

    public void EnviarMensagem (string numero, VideoMessage message)
     {
        console.writeLine ($"Enviando a mensagem de video para o número {numero}");
    }

    public void EnviarMensagem (string numero, photoMessage message)
     {
        console.writeLine ($"Enviando a mensagem de foto para o número {numero}");
    }

    public void EnviarMensagem (string numero, FileMessage message)
     {
        console.writeLine ($"Enviando a mensagem de arquivo para o número {numero}");
    }

}