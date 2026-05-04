using Godot;
using System;

public partial class Player : CharacterBody2D
{
    [Export] private float speed;

    public override void _Process(double delta)
    {

    }
    public override void _PhysicsProcess(double delta)
    {
        float direction = Input.GetAxis("MoveLeft", "MoveRight");
        if(!IsOnFloor())
            Velocity = new Vector2(Velocity.X, Velocity.Y + GameManager.Instance.gravity);
        Velocity = new Vector2(direction * speed, Velocity.Y);
        MoveAndSlide();
    }
}
