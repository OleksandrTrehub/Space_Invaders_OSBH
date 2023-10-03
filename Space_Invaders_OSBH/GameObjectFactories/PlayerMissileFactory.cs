using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Invaders_OSBH.GameObjectFactories
{
    internal class PlayerMissileFactory : GameObjectFactory
    {
        public PlayerMissileFactory(GameSettings gameSettings)
            : base(gameSettings)
        {
            
        }
        public override GameObject GetGameObject(GameObjectPlace objectPlace)
        {
            GameObjectPlace missilePlace = new GameObjectPlace() {XCoordinate = objectPlace.XCoordinate, YCoordinate = objectPlace.YCoordinate-1 };
            GameObject missile = new PlayerMissile() {Figure = GameSettings.PlayerMissile, GameObjectPlace = missilePlace, GameObjectType = GameObjectType.PlayerMissile };

            return missile;



        }
    }
}
