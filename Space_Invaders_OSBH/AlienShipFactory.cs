using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Invaders_OSBH.GameObjectFactories
{
    internal class AlienShipFactory : GameObjectFactory
    {
        public AlienShipFactory(GameSettings gameSettings)
            :base(gameSettings) 
        {
            
        }
        public override GameObject GetGameObject(GameObjectPlace objectPlace)
        {
            GameObject alienShip = new AlianShip() { Figure = GameSettings.AlienShip, GameObjectPlace = objectPlace };
            return alienShip;
        }

        public List<GameObject> GetSwarm() {
            List<GameObject> swarm = new List<GameObject>();

            int startX = GameSettings.SwarmStartXCoordinate;
            int startY = GameSettings.SwarmStartYCoordinate;

            for (int y = 0; y < 5; y++)
            //for (int y = 5; y < 0; y--)
            {
                    GameObjectPlace objectPlace = new GameObjectPlace() { XCoordinate = startX, YCoordinate = startY + y };
                    GameObject alienShip = GetGameObject(objectPlace);
                    swarm.Add(alienShip);
            }
            return swarm;


        }
    }
}
