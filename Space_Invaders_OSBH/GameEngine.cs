using Space_Invaders_OSBH.GameObjectFactories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Space_Invaders_OSBH
{
    internal class GameEngine
    {
        private bool _isNotOver;
        private Scene _scene;
        private SceneRender _sceneRender;
        private static GameEngine _gameEngine;
        private GameSettings _gameSettings;
        private GameEngine()
        {
            
        }

        public static GameEngine GetGameEngine(GameSettings gameSettings)
        {
            if (_gameEngine == null)
            {
                _gameEngine= new GameEngine(gameSettings);
            }
            return _gameEngine;
        }
        private GameEngine(GameSettings gameSettings)
        {
            _gameSettings = gameSettings;
            _isNotOver = true;
            _scene = Scene.GetScene(gameSettings);
            _sceneRender = new SceneRender(gameSettings);
        }

        public void Run() {
            int swarmMoveCounter = 0;
            int playerMissileCounter = 0;
            do
            {
                
                _sceneRender.Render(_scene);
                

                Thread.Sleep(_gameSettings.GameSpeed);
                _sceneRender.ClearScreen();



                if (swarmMoveCounter == _gameSettings.SwarmSpeed)
                {
                    CalculateSwarmMove();
                    swarmMoveCounter = 0;
                }
                swarmMoveCounter++;

                if (playerMissileCounter == _gameSettings.PlayerMissileSpeed) {
                    CalculateMissileMove();
                    playerMissileCounter = 0;
                }
                playerMissileCounter++;
                


            } while (_isNotOver);

            if (_scene.swarm.Count > 0)
            {
                Intro.ShowGameOver();
            }
            else {
                Intro.ShowWin();
            }


            
        }


        public void CalculateMovePlayerShipLeft()
        {
            if (_scene.playerShip.GameObjectPlace.XCoordinate > 1)
            {
                _scene.playerShip.GameObjectPlace.XCoordinate--;
            }
        }

        public void CalculateMovePlayerShipRight()
        {
            if (_scene.playerShip.GameObjectPlace.XCoordinate < _gameSettings.ConsoleWidth)
            {
                _scene.playerShip.GameObjectPlace.XCoordinate++;
            }
        }

        public void CalculateSwarmMove()
        {
            for (int i = 0; i < _scene.swarm.Count; i++)
            {
                GameObject alianShip = _scene.swarm[i];
                alianShip.GameObjectPlace.YCoordinate++;

                if (alianShip.GameObjectPlace.YCoordinate == _scene.playerShip.GameObjectPlace.YCoordinate)
                {
                    _isNotOver = false;
                }
            }
        }

        public void Shoot() {

            PlayerMissileFactory missileFactory = new PlayerMissileFactory(_gameSettings);
            GameObject missile = missileFactory.GetGameObject(_scene.playerShip.GameObjectPlace);

            _scene.playerShipMissile.Add(missile);
            Console.Beep(1000, 300);
        }

        public void CalculateMissileMove() { 
            if(_scene.playerShipMissile.Count ==0 )
            {
                return;
            }
            for (int x = 0; x < _scene.playerShipMissile.Count; x++)
            {
                GameObject missile = _scene.playerShipMissile[x];

                if(missile.GameObjectPlace.YCoordinate ==1)
                {
                    _scene.playerShipMissile.RemoveAt(x);
                }
                missile.GameObjectPlace.YCoordinate--;

                if (_scene.swarm.Count > 0)
                {
                    for (int i = 0; i < _scene.swarm.Count; i++)
                    {
                        GameObject alianShip = _scene.swarm[i];
                        if (missile.GameObjectPlace.Equals(alianShip.GameObjectPlace))
                        {
                            _scene.swarm.RemoveAt(i);
                            _scene.playerShipMissile.RemoveAt(x);
                            Console.Beep(500, 300);
                            break;
                        }
                    }
                }
                else {
                    _isNotOver = false;
                }
            }
        }


    }
}
