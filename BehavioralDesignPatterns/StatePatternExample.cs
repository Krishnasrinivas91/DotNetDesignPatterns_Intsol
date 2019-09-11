using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralDesignPatterns
{
    public interface State
    {
        void ExecuteCommand(Player player);
    }

    //Context Class
    public class Player
    {
        State CurrentState;
        public Player()
        {
            this.CurrentState = new HealthyState();
        }

        public void BulletsHit(int bullets)
        {
            Console.WriteLine("Bullets hits to the Player : " + bullets);
            if (bullets < 5)
                this.CurrentState = new HealthyState();
            else if (bullets >= 5 && bullets <= 10)
                this.CurrentState = new HurtState();
            else
                this.CurrentState = new DeadState();

            CurrentState.ExecuteCommand(this);
        }
    }

    public class HurtState : State
    {
        public void ExecuteCommand(Player player)
        {
            Console.WriteLine("Player is Wounded.");
        }
    }

    public class DeadState : State
    {
        public void ExecuteCommand(Player player)
        {
            Console.WriteLine("Player is Dead. Game Over");
        }
    }

    public class HealthyState : State
    {
        public void ExecuteCommand(Player player)
        {
            Console.WriteLine("Player is Healthy.");
        }
    }


    class StatePatternExample
    {  

        //static void Main(string[] args)
        //{
        //    Player player = new Player();
        //    player.BulletsHit(3);
        //    player.BulletsHit(9);
        //    player.BulletsHit(12);

        //    Console.Read();
        //}
    }
}
