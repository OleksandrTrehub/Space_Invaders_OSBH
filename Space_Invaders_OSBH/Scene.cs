using Space_Invaders_OSBH.GameObjectFactories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Invaders_OSBH
{
    internal class Scene
    {
        public List<GameObject> swarm;
        public List<GameObject> ground;
        public GameObject playerShip;
        public List<GameObject> playerShipMissile;
        private static Scene _scene;
        GameSettings _gameSettings;

        private Scene(GameSettings gameSrttings) { 
            _gameSettings = gameSrttings;
            swarm = new AlienShipFactory(_gameSettings).GetSwarm();
            ground = new GroundFactory(_gameSettings).GetGround();
            playerShip = new PlayerShipFactory(_gameSettings).GetGameObject();
            playerShipMissile = new List<GameObject>();

        }

        public static Scene GetScene(GameSettings gameSettings) {
            if (_scene == null) {
                _scene = new Scene(gameSettings);
            }
            return _scene;
        }

        


    }
}
