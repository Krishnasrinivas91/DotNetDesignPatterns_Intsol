using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BehavioralDesignPatterns
{
    public class Memento
    {
        public int Level;
        public int Score;
        public string Health;

        public Memento(int level, int score, string health)
        {
            Level = level;
            Score = score;
            Health = health;
        }
    }

    public class CareTaker
    {
        public Memento LevelMarker;
    }

    public class PlayerM
    {
        public int Level;
        public int Score;
        public string Health;
        public int lifeline = 3;

        public Memento CreateMarker(PlayerM player)
        {
            return new Memento(player.Level, player.Score, player.Health);
        }

        public void RestoreLevel(Memento playerMemento)
        {
            this.Level = playerMemento.Level;
            this.Score = playerMemento.Score;
            this.Health = playerMemento.Health;
            this.lifeline -= 1;
        }

        public void DisplayPlayerInfo()
        {
            Console.WriteLine("Level :" + this.Level);
            Console.WriteLine("Score :" + this.Score);
            Console.WriteLine("Health :" + this.Health);
            Console.WriteLine("LifeLine :" + this.lifeline);
        }
    }
    class MementoPatternExample
    {
        //static void Main(string[] args)
        //{
        //    PlayerM player = new PlayerM();
        //    player.Level = 1;
        //    player.Score = 100;
        //    player.Health = "100%";
        //    Console.WriteLine("Player Information After Completing one Level:");
        //    player.DisplayPlayerInfo();

        //    //When Player completes any level then create a checkpoint for that level
        //    CareTaker careTaker = new CareTaker();
        //    careTaker.LevelMarker = player.CreateMarker(player);

        //    //Sleep to show some delay
        //    Thread.Sleep(2000);

        //    player.Level = 2;
        //    player.Score = 120;
        //    player.Health = "70%";
        //    Console.WriteLine("Player Information After Completing Second Level:");

        //    //Player looses all the lifeline then restore the game from level 1
        //    player.RestoreLevel(careTaker.LevelMarker);
        //    player.DisplayPlayerInfo();

        //    Console.Read();

        //}
    }

}
