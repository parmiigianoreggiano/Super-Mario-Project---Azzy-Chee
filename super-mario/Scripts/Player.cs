using Godot;
using System;

public partial class Player : CharacterBody2D
{
    [Export] public float speed;

    public override void _PhysicsProcess(double delta)
    {
        float direction = Input.GetAxis("MoveLeft", "MoveRight");
        if(!IsOnFloor())
            GD.Print("nervous gulp");
        Velocity = new Vector2(direction * speed, Velocity.Y) * (float)delta;
        MoveAndSlide();
    }
}
