using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Space_Invaders_OSBH
{
    internal class Program
    {
        static GameEngine gameEngine;
        static GameSettings gameSettings;

        static UIController uIController;
        static MusicController musicController;
        static void Main(string[] args)
        {
            Initialize();

            Intro.ShowIntro();
            Console.ReadKey();

            gameEngine.Run();
        }

        public static void Initialize() { 
            gameSettings = new GameSettings();
            gameEngine = GameEngine.GetGameEngine(gameSettings);
            uIController= new UIController();
            uIController.OnAPressed += (obj, arg) => gameEngine.CalculateMovePlayerShipLeft();
            uIController.OnDPressed += (obj, arg) => gameEngine.CalculateMovePlayerShipRight();
            uIController.OnSpacePressed += (obj, arg) => gameEngine.Shoot();

            Thread uIthread = new Thread(uIController.StartListning);
            uIthread.Start(); 

            musicController = new MusicController();

            Thread musicThread = new Thread(musicController.playBGMusic);
            musicThread.Start();
        }


    }
}
