using Unity.VisualScripting;
using UnityEngine;

public class PlayerIdleState : PlayerGroundedState
{
    public PlayerIdleState(Player _player, PlayerStateMachine _stateMachine, string _animBoolName) : base(_player, _stateMachine, _animBoolName)
    {
    }


    override public void Enter()
    {
        base.Enter();

        rb.linearVelocity = new Vector2(0, 0);
    }

    override public void Exit()
    {
        base.Exit();
    }
    override public void Update()
    {
        base.Update();

        if (xInput == player.facingDir && player.IsWallDetected())
            return;

        if (xInput != 0)
            stateMachine.ChangeState(player.moveState);

    }
}
