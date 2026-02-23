# 020 – Play Sound with NAudio

## Overview

Demonstrates how to use the **NAudio NuGet package** to play an MP3 file that is embedded as a resource inside the application assembly. The program plays the sound until the user presses any key.

## Concepts Covered

- Adding a third-party NuGet package (`NAudio`)
- Embedding a file as an **assembly resource** (`.csproj` `EmbeddedResource`)
- `Assembly.GetManifestResourceStream` to read embedded resources at runtime
- `Mp3FileReader` and `WaveOutEvent` from NAudio
- `IWavePlayer` and `WaveStream` for playback control
- Graceful resource disposal with `Dispose()`

## Project Structure

```
020-Play-Sound-Naudio/
└── PlaySoundNAudio/
    ├── PlaySoundNAudio.csproj
    ├── PlaySoundNAudio.sln
    ├── Program.cs
    └── sound.mp3     ← embedded MP3 resource
```

## Code Summary

```csharp
using NAudio.Wave;

public class Mp3Player
{
    public void PlayMp3FromResources()
    {
        string resourceName = "PlaySoundNAudio.Resources.sound.mp3";
        var assembly = Assembly.GetExecutingAssembly();

        using (Stream resourceStream = assembly.GetManifestResourceStream(resourceName))
        {
            waveStream = new Mp3FileReader(resourceStream);
            wavePlayer = new WaveOutEvent();
            wavePlayer.Init(waveStream);
            wavePlayer.Play();
        }
    }
}
```

## Dependencies

```
NAudio (install via NuGet)
```

```bash
dotnet add package NAudio
```

## How to Run

```bash
dotnet run --project PlaySoundNAudio
```

The MP3 will begin playing. Press any key to stop playback.
