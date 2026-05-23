using Godot;
using System;

public partial class BrickTiles : TileMapLayer
{
    public override void _Process(double delta)
    {
        if(Player.m_Instance._headDetection.IsColliding() && !Player.m_Instance.IsOnFloor())
        {
            Vector2 BrickPos = (Player.m_Instance._headDetection.GetCollisionPoint());
            EraseCell(LocalToMap(BrickPos));
            GD.Print("Brick detected! Position at " + BrickPos);
        }
    }
}
