using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CivilWarProject
{
    interface playerADO
    {

        int assignPlayerId();

        void createPlayer();

        Province assignProvince();

        void choseCounty(County startCounty);

        void loseCounty(County countyLost);

        void gainCounty(County countygained);

        void updateGold(int goldChange);

        int getGold();

        void updateTroops(int troopChange);

        int getTroops();
    }
}
