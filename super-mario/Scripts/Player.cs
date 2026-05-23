using Godot;
using System;

public partial class Player : CharacterBody2D
{
    [Export] private float _speed, _jumpForce;
    [Export] private Timer _coyoteTimer;
    [Export] public Area2D _feetCollision;
    [Export] public RayCast2D _headDetection;

    public static Player m_Instance;

    private bool CanJump()
    {
        if(IsOnFloor() || !_coyoteTimer.IsStopped())
            return true;
        else
            return false;
    }

    public override void _PhysicsProcess(double delta)
    {
        float direction = Input.GetAxis("MoveLeft", "MoveRight");
        if(!IsOnFloor())
            Velocity = new Vector2(Velocity.X, Velocity.Y + GameManager.Instance._gravity * (float)delta);
        if(Input.IsActionPressed("Jump") && CanJump())
            Velocity = new Vector2(Velocity.X, Velocity.Y - _jumpForce * (float)delta);
        Velocity = new Vector2(direction * _speed * (float)delta, Velocity.Y);
        MoveAndSlide();
    }

    public override void _Ready()
    {
        m_Instance = this;
    }
}
