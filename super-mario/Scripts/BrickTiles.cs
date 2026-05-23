using Godot;
using System;

public partial class BrickTiles : TileMapLayer
{
    public override void _Process(double delta)
    {
        if(Player.m_Instance._headDetection.IsColliding() && !Player.m_Instance.IsOnFloor())
        {
            Node2D Brick = (Node2D)Player.m_Instance._headDetection.GetCollider();
            EraseCell((Vector2I)Brick.Position);
            GD.Print("Brick detected! Position at " + Brick.Position);
        }
    }
}
