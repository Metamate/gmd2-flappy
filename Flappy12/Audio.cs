using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Media;

namespace Flappy12;

public static class Audio
{
    public static SoundEffect Flap { get; set; }
    public static SoundEffect Hurt { get; set; }
    public static SoundEffect Explosion { get; set; }
    public static SoundEffect Score { get; set; }
    public static Song BackgroundMusic { get; set; }

    public static void LoadContent(ContentManager content)
    {
        Flap = content.Load<SoundEffect>("audio/flap");
        Hurt = content.Load<SoundEffect>("audio/hurt");
        Explosion = content.Load<SoundEffect>("audio/explosion");
        Score = content.Load<SoundEffect>("audio/score");
        BackgroundMusic = content.Load<Song>("audio/marios_way");
    }
}