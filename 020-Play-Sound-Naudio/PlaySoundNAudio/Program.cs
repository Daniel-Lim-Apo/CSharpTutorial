using System;
using System.IO;
using System.Reflection;
using NAudio.Wave;

public class Mp3Player
{
    private IWavePlayer wavePlayer;
    private WaveStream waveStream;

    public void PlayMp3FromResources()
    {
        // Substitua "YourNamespace" pelo namespace do seu projeto e "YourMp3ResourceName" pelo nome do seu recurso MP3
        string resourceName = "PlaySoundNAudio.Resources.sound.mp3";
        
        // Carregando o recurso MP3
        var assembly = Assembly.GetExecutingAssembly();
        using (Stream resourceStream = assembly.GetManifestResourceStream(resourceName))
        {
            if (resourceStream == null)
                throw new InvalidOperationException("Could not find embedded resource");

            // Use NAudio para tocar o stream
            waveStream = new Mp3FileReader(resourceStream);
            wavePlayer = new WaveOutEvent();
            wavePlayer.Init(waveStream);
            wavePlayer.Play();
        }
    }

    public void Stop()
    {
        wavePlayer?.Stop();
        wavePlayer?.Dispose();
        waveStream?.Dispose();
    }
}

class Program
{
    static void Main()
    {
        var mp3Player = new Mp3Player();
        mp3Player.PlayMp3FromResources();

        Console.WriteLine("Press any key to stop...");
        Console.ReadKey();

        mp3Player.Stop();
    }
}
