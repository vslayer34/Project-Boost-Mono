using Godot;
using ProjectBoostMono.Scripts.Helper;
using System;

namespace ProjectBoostMono.Scripts.Characters;
public partial class Player : RigidBody3D
{
    [Export]
    private float _velocity = 1000.0f;
    private Vector3 _movementVector;



    // Game Loop Methods---------------------------------------------------------------------------
    public override void _Process(double delta)
    {
        // _movementVector = Vector3.Zero;

        if (Input.IsActionPressed(InputActionNames.BuiltIn.UI_ACCEPT))
        {
            // Position = new Vector3(Position.X, Position.Y + (float)delta, Position.Z);
            ApplyCentralForce(Vector3.Up * _velocity * (float)delta);
        }

        if (Input.IsActionPressed(InputActionNames.BuiltIn.UI_LEFT))
        {
            RotateZ((float)delta);
        }

        if (Input.IsActionPressed(InputActionNames.BuiltIn.UI_RIGHT))
        {
            RotateZ(-(float)delta );
        }
    }
}
