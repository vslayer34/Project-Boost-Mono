using Godot;
using ProjectBoostMono.Scripts.Helper;
using System;

namespace ProjectBoostMono.Scripts.Characters;
public partial class Player : RigidBody3D
{
    [Export]
    private float _velocity = 1000.0f;

    [Export]
    private float _rotationSpeed = 100.0f;
    private Vector3 _movementVector;



    // Game Loop Methods---------------------------------------------------------------------------
    public override void _Process(double delta)
    {
        // _movementVector = Vector3.Zero;

        if (Input.IsActionPressed(InputActionNames.BuiltIn.UI_ACCEPT))
        {
            ApplyCentralForce(Basis.Y * _velocity * (float)delta);
        }

        if (Input.IsActionPressed(InputActionNames.BuiltIn.UI_LEFT))
        {
            ApplyTorque(new Vector3(0.0f, 0.0f, _rotationSpeed * (float)delta));
        }

        if (Input.IsActionPressed(InputActionNames.BuiltIn.UI_RIGHT))
        {
            ApplyTorque(new Vector3(0.0f, 0.0f, -1 * _rotationSpeed * (float)delta));
        }
    }
}
