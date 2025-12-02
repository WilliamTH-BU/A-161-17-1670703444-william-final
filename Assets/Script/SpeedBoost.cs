using UnityEngine;
public class SpeedBoost : PowerUpBase
{
    Player player;

    public override void ApplyEffect(Player _player)
    {
        _player.SetMoveSpeed(player.MoveSpeed);
    }
  

}
